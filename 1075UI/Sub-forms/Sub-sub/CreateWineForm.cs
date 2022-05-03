using System;
using System.ComponentModel;
using System.Drawing;
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

        public CreateWineForm()
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
        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void InnerForm10751_Load(object sender, EventArgs e)
        {

        }

        
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
                MessageBox.Show(dialog.SafeFileName + " selected");

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
                string asd = dialog.FileName.Split(new string[] { "1075Manager" }, StringSplitOptions.RemoveEmptyEntries)[1];
                DialogResult dr = MessageBox.Show
                ("A new wine will get created with the following properties: " +
                "\n" +"Name: "+nameTB.Text+
                "\n" + "Vintage: " + vintageTB.Text +
                "\n" + "Grapes: " + grapesTB.Text +
                "\n" + "Sulfites: " + sulfitesTB.Text +
                "\n" + "Alcohol: " + alcoholTB.Text +
                "\n" + "Sugar: " + sugarTB.Text +
                "\n" + "Extract: " + extractTB.Text +
                "\n" + "Bottling date: " + bdateTB.Text +
                "\n" + "Price: " + priceTB.Text  +
                "\n" + "In stock: " + instockTB.Text +
                "\n" + "Picture: " + dialog.SafeFileName +
                "\n\n" + "Would you like to create this wine?",

                    
                "Data validation", MessageBoxButtons.YesNo);

                switch (dr)
                {
                    case DialogResult.Yes:
                        //database logic
                        string price = priceTB.Text;
                        price += "€";

                        ///preparing prerequisites
                        int instock = Int32.Parse(instockTB.Text);
                        string picturepath = dialog.FileName.Split(new string[] { "1075Manager" }, StringSplitOptions.RemoveEmptyEntries)[1];

                        //DB returns id
                        int id = SqlTools.CreateWine(nameTB.Text, vintageTB.Text, grapesTB.Text, sulfitesTB.Text, alcoholTB.Text, sugarTB.Text, extractTB.Text, bdateTB.Text, price, instock, picturepath);

                        Console.WriteLine("ID:"+id);

                        //call constructor with id from db
                        WineModel newWine = new WineModel(id,nameTB.Text, vintageTB.Text, grapesTB.Text, sulfitesTB.Text, alcoholTB.Text, sugarTB.Text, extractTB.Text, bdateTB.Text, price, instock, dialog.FileName);
                        Console.WriteLine(newWine.bor_nev);
                        MessageBox.Show("Wine added succesfully.");
                        ///
                        ResetForm();
                        break;
                    case DialogResult.No:
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

            if ((nameTB.Text.Length < 0 && nameTB.Text.Length > 50))
            {
                valid = false;
            }

            if ((vintageTB.Text.Length < 0 && vintageTB.Text.Length > 50))
            {
                valid = false;
            }

            if ((grapesTB.Text.Length < 0 && grapesTB.Text.Length > 50))
            {
                valid = false;
            }

            if ((sulfitesTB.Text.Length < 0 && sulfitesTB.Text.Length > 50))
            {
                valid = false;
            }

            if ((alcoholTB.Text.Length < 0 && alcoholTB.Text.Length > 50))
            {
                valid = false;
            }

            if ((sugarTB.Text.Length < 0 && sugarTB.Text.Length > 50))
            {
                valid = false;
            }

            if ((extractTB.Text.Length < 0 && extractTB.Text.Length > 50))
            {
                valid = false;
            }

            if ((bdateTB.Text.Length < 0 && bdateTB.Text.Length > 50))
            {
                valid = false;
            }

            if ((priceTB.Text.Length < 0 && priceTB.Text.Length > 50))
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
            bdateTB.Text = "";
            priceTB.Text = "";
            instockTB.Text = "";

            dialog.Reset();
            selectedPictureLabel.Visible = false;
        }

        private void CreateWineForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
