using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1075UI
{
    public partial class WineControl : UserControl
    {

        public WineControl()
        {
            InitializeComponent();
        }

        public void SetWineName(string wineName)
        {
            this.wineNameLabel.Text = wineName;
        }

        public void SetWineImage(Image wineImage)
        {
            this.winePictureBox.Image = wineImage;
        }
    }
}
