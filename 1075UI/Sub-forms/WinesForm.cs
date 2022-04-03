using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1075Library.Models;

namespace _1075UI
{
    public partial class WinesForm : Form
    {
        public WinesForm()
        {
            InitializeComponent();
            List<WineModel> wines = PopulateWines();

            LoadWines(wines);
        }

        private List<WineModel> PopulateWines()
        {
            string wineDirectory = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName) + "\\media\\wines";

            var wineFiles = Directory.GetFiles(wineDirectory, "*.png", SearchOption.AllDirectories);
            var wineImages = wineFiles.Select(Image.FromFile).ToArray();
            var wineNames = wineFiles.Select(file => Path.GetFileName(file)).ToArray().Select(a => a.Replace(".png", "")).ToArray();

            List <WineModel> wines = new List<WineModel>();

            for (int i = 0; i < wineNames.Length; i++)
            {
                WineModel wine = new WineModel();
                wine.Name = wineNames[i];
                wine.Image = wineImages[i];

                wines.Add(wine);
            }

            return wines;
        }

        private void LoadWines(List<WineModel> wines)
        {
            int counter = 0;
            int X = 20, Y = 0;

            foreach (WineModel wine in wines)
            {
                if (counter == 4)
                {
                    X = 20;
                    Y += 280;
                    counter = 0;
                }

                WineControl wineControl = new WineControl() { Location = new Point(X, Y) };
                wineControl.SetWineName(wine.Name);
                wineControl.SetWineImage(wine.Image);
                this.Controls.Add(wineControl);

                X += 178;
                counter++;
            }
        }

    }
}
