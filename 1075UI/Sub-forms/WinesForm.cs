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
using _1075Library;
using _1075Library.Models;
using _1075UI.Sub_forms.Sub_sub;

namespace _1075UI
{
    public partial class WinesForm : Form
    {
        public WinesForm(Button addWineButton)
        {
            InitializeComponent();

            addWineButton.Click += new EventHandler(addWineButton_Click);

            List<WineModel> wines = SqlTools.GetWines();
            LoadWines(wines);
        }

        //private List<WineModel> PopulateWinesFromDirectory()
        //{
        //    string wineDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\1075UI\\Resources\\wines";
        //    var wineFiles = Directory.GetFiles(wineDirectory, "*.png", SearchOption.AllDirectories);
        //    var wineImages = wineFiles.Select(Image.FromFile).ToArray();
        //    var wineNames = wineFiles.Select(file => Path.GetFileName(file)).ToArray().Select(a => a.Replace(".png", "")).ToArray();

        //    List <WineModel> wines = new List<WineModel>();

        //    for (int i = 0; i < wineNames.Length; i++)
        //    {
        //        WineModel wine = new WineModel();
        //        wine.Name = wineNames[i];
        //        wine.Image = wineImages[i];

        //        wines.Add(wine);
        //    }

        //    return wines;
        //}

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
                wineControl.SetWineName(wine.bor_nev);
                if(wine.Image != null)
                {
                    wineControl.SetWineImage(wine.Image);
                }
                
                this.Controls.Add(wineControl);

                X += 178;
                counter++;
            }
        }

        protected void addWineButton_Click(object sender, EventArgs e)
        {
            CreateWineForm createWineForm = new CreateWineForm();
            createWineForm.Show();
        }

        private void WinesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
