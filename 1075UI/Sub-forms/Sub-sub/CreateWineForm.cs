using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using _1075Library;
using _1075Library.Models;

namespace _1075UI.Sub_forms.Sub_sub
{
    public partial class CreateWineForm : Form
    {

        //FOR MOVING THE BORDERLESS WINDOW
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public CreateWineForm(WinesForm wineForm)
        {
            InitializeComponent();
        }

        //FOR MOVING THE BORDERLESS WINDOW
        private void CreateWineForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        //\FOR MOVING THE BORDERLESS WINDOW
        
        private void selectPictureButton_Click(object sender, EventArgs e)
        {
            dialog.Filter = "Image files|*.png";

            dialog.FileOk += delegate (object s, CancelEventArgs ev) {
                var size = new FileInfo(dialog.FileName).Length;
                if (size > 500000)
                {
                    MessageBox.Show("Sorry, file is too large, the limit is 500KBs");
                    ev.Cancel = true;
                }
                if (!dialog.FileName.Contains("1075Manager"))
                {
                    MessageBox.Show("Image not withing project boundaries. " +
                                    "Make sure the file is somewhere beyond the 1075Manager folder.");
                    ev.Cancel = true;
                }

            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                //show filename
                selectedPictureLabel.Visible = true;
                selectedPictureLabel.Text = dialog.SafeFileName;

                //show image in picturebox
                winePictureBox.Image = new Bitmap(dialog.FileName);
            }
        }

        private void createWineButton_Click(object sender, EventArgs e)
        {
            if(FormIsValid())
            {
                DialogResult dr = MessageBox.Show
                ("A new wine will get created with the following properties: " +
                "\n" +"Name: "+nameTB.Text+
                "\n" + "Vintage: " + vintageTB.Text +
                "\n" + "Grapes: " + grapesTB.Text + 
                "\n" + "Sulfites: " + sulfitesTB.Text + "mg/l"+
                "\n" + "Alcohol: " + alcoholTB.Text + "%" +
                "\n" + "Sugar: " + sugarTB.Text + "g/l" +
                "\n" + "Extract: " + extractTB.Text + "g/l" +
                "\n" + "Bottling date: " + bdateTB.Text +
                "\n" + "Price: " + priceTB.Text  + "€" +
                "\n" + "In stock: " + instockTB.Text + " btls" +
                "\n" + "Picture: " + dialog.SafeFileName +
                "\n\n" + "Would you like to create this wine?",

                    
                "Data validation", MessageBoxButtons.YesNo);

                switch (dr)
                {
                    case DialogResult.Yes:
                        //database logic

                        ///preparing prerequisites
                        int instock = Int32.Parse(instockTB.Text);
                        string picturepath = null;

                        bool image_isselected = dialog.FileName != "dialog";
                        //check if there is a file selected
                        if (image_isselected)
                        {
                            picturepath = dialog.FileName.Split(new string[] { "1075Manager" }, StringSplitOptions.RemoveEmptyEntries)[1];
                        }
                        
                        //DB returns id
                        int id = SqlTools.CreateWine(nameTB.Text, vintageTB.Text, grapesTB.Text, sulfitesTB.Text + "mg/l", alcoholTB.Text + "%", sugarTB.Text + "g/l", extractTB.Text + "g/l", bdateTB.Text, priceTB.Text + "€", instock, picturepath);

                        //call constructor with id from db
                        if (image_isselected)
                        {
                            WineModel newWine = new WineModel(id, nameTB.Text, vintageTB.Text, grapesTB.Text, sulfitesTB.Text, alcoholTB.Text, sugarTB.Text, extractTB.Text, bdateTB.Text, priceTB.Text, instock, dialog.FileName);
                        }
                        else
                        {
                            WineModel newWine = new WineModel(id, nameTB.Text, vintageTB.Text, grapesTB.Text, sulfitesTB.Text, alcoholTB.Text, sugarTB.Text, extractTB.Text, bdateTB.Text, priceTB.Text, instock);
                        }
                        
                        MessageBox.Show("Wine added succesfully.");
                        ///
                        ResetForm();
                        break;
                    
                }
            }
            else
            {
                MessageBox.Show("You've provided invalid info.");
            }
        }
        private bool FormIsValid()
        {
            bool valid = true;
            int parser;

            if (nameTB.Text.Length == 0  || nameTB.Text.Length > 50  || 
               vintageTB.Text.Length > 50 || grapesTB.Text.Length > 50 || 
               sulfitesTB.Text.Length > 50 || alcoholTB.Text.Length > 50 || 
               sugarTB.Text.Length > 50 || extractTB.Text.Length > 50 || 
               bdateTB.Text.Length > 50 ||priceTB.Text.Length == 0 || 
               priceTB.Text.Length > 50)
            {
                valid = false;
            }

            if (int.TryParse(instockTB.Text, out parser))
            {
                if (parser<0 || parser>1000000)
                {
                    valid = false;
                }
            }
            else
            {
                valid = false;
            }

            DateTime dt;
            if (!DateTime.TryParseExact(bdateTB.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out dt))
            {
                valid = false;
            }
           
            return valid;
        }

        private void ResetForm()
        {
            nameTB.Text = "";
            vintageTB.Text = "";
            grapesTB.Text = "";
            sulfitesTB.Text = "";
            alcoholTB.Text = "";
            sugarTB.Text = "";
            extractTB.Text = "";
            bdateTB.Text = "yyyy-MM-dd";
            bdateTB.ForeColor = Color.Bisque;
            priceTB.Text = "";
            instockTB.Text = "";

            dialog.Reset();
            selectedPictureLabel.Visible = false;
        }

        private void CreateWineForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void bdateTB_Enter(object sender, EventArgs e)
        {
            if (bdateTB.Text == "yyyy-MM-dd")
            {
                bdateTB.ForeColor = Color.BurlyWood;
                bdateTB.Text = "";
            }
        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void vintageLabel_Click(object sender, EventArgs e)
        {

        }

        private void vintageTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void grapesLabel_Click(object sender, EventArgs e)
        {

        }

        private void grapesTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void sulfitesLabel_Click(object sender, EventArgs e)
        {

        }

        private void sulfitesTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void alcoholLabel_Click(object sender, EventArgs e)
        {

        }

        private void alcoholTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void sugarLabel_Click(object sender, EventArgs e)
        {

        }

        private void sugarTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void extractTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void extractLabel_Click(object sender, EventArgs e)
        {

        }

        private void bdateLabel_Click(object sender, EventArgs e)
        {

        }

        private void bdateTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
