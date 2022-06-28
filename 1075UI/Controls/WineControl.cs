using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1075Library;
using _1075Library.Models;
using _1075UI.Sub_forms.Sub_sub;

namespace _1075UI
{
    public partial class WineControl : UserControl
    {
        public WineModel currentWine;
        WinesForm currentWinesForm;

        public WineControl(WineModel wine, WinesForm winesForm)
        { 
            InitializeComponent();

            currentWine = wine;
            currentWinesForm = winesForm;
        }
        
        public void SetWineName(string wineName)
        {
            this.wineNameLabel.Text = wineName;
        }

        public void SetWineImage(Image wineImage)
        {
            this.winePictureBox.Image = wineImage;
        }

        private void winePictureBox_Click(object sender, EventArgs e)
        {
            EditWineForm editWineForm = new EditWineForm(this, currentWine);
            editWineForm.FormClosing += new FormClosingEventHandler(EditWineFormClosing);
            editWineForm.Show();
        }

        private void EditWineFormClosing(object sender, FormClosingEventArgs e)
        {
            ////this is absolutely not sure
            currentWinesForm.Initialize();
        }

        private void wineNameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
