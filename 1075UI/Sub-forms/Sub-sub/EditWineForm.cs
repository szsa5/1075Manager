using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1075Library;
using _1075Library.Models;
using _1075UI.Sub_forms.Sub_sub;

namespace _1075UI.Sub_forms.Sub_sub
{
    public partial class EditWineForm : Form
    {
        WineControl parentWineControl;
        WineModel c_Wine;


        public EditWineForm(WineControl wineControl, WineModel currentWine)
        {
            InitializeComponent();
            parentWineControl = wineControl;
            c_Wine = currentWine;
            showDetails();
        }


        private void showDetails()
        {
            WineModel sqlwine = SqlTools.GetWine(parentWineControl.currentWine.bor_id);

            if (sqlwine != null)
            {
                titleWineNameLabel.Text = sqlwine.bor_nev + " " + sqlwine.bor_evjarat;

                nameValueLabel.Text = sqlwine.bor_nev;
                vintageValueLabel.Text = sqlwine.bor_evjarat;
                grapesValueLabel.Text = sqlwine.bor_szolo;
                sulfitesValueLabel.Text = sqlwine.bor_ken;
                alcoholValueLabel.Text = sqlwine.bor_alkohol;
                sugarValueLabel.Text = sqlwine.bor_cukor;
                extractValueLabel.Text = sqlwine.bor_extrakt;
                bdateValueLabel.Text = sqlwine.bor_pdatum;
                priceValueLabel.Text = sqlwine.bor_ar;
                instockValueLabel.Text = sqlwine.bor_raktar.ToString();

                if (c_Wine.Image != null)
                {
                    winePictureBox.Image = c_Wine.Image;
                }
            }
            else
            {
                MessageBox.Show("Problem loading wine...");
            }
        }

        private void editWineButton_Click(object sender, EventArgs e)
        {
            //change labels to textboxes, make update button and postfixes visible

            postFixLabel1.Visible = true;
            postFixLabel2.Visible = true;
            postFixLabel3.Visible = true;
            postFixLabel4.Visible = true;
            postFixLabel5.Visible = true;

            nameTB.Visible = true;
            vintageTB.Visible = true;
            grapesTB.Visible = true;
            sulfitesTB.Visible = true;
            alcoholTB.Visible = true;
            sugarTB.Visible = true;
            extractTB.Visible = true;
            bdateTB.Visible = true;
            priceTB.Visible = true;
            instockTB.Visible = true;

            nameTB.Text = nameValueLabel.Text;
            vintageTB.Text = vintageValueLabel.Text;
            grapesTB.Text = grapesValueLabel.Text;
            sulfitesTB.Text = RemoveEndSymbol(sulfitesValueLabel.Text);
            alcoholTB.Text = RemoveEndSymbol(alcoholValueLabel.Text);
            sugarTB.Text = RemoveEndSymbol(sugarValueLabel.Text);
            extractTB.Text = RemoveEndSymbol(extractValueLabel.Text);
            bdateTB.Text = bdateValueLabel.Text;
            priceTB.Text = RemoveEndSymbol(priceValueLabel.Text);
            instockTB.Text = instockValueLabel.Text;

            nameValueLabel.Visible = false;
            vintageValueLabel.Visible = false;
            grapesValueLabel.Visible = false;
            sulfitesValueLabel.Visible = false;
            alcoholValueLabel.Visible = false;
            sugarValueLabel.Visible = false;
            extractValueLabel.Visible = false;
            bdateValueLabel.Visible = false;
            priceValueLabel.Visible = false;
            instockValueLabel.Visible = false;

            updateButton.Visible = true;

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (FormIsValid())
            {
                DialogResult dr = MessageBox.Show
                ("The wine will have the following properties: " +
                "\n" + "Name: " + nameTB.Text +
                "\n" + "Vintage: " + vintageTB.Text +
                "\n" + "Grapes: " + grapesTB.Text +
                "\n" + "Sulfites: " + sulfitesTB.Text + "mg/l" +
                "\n" + "Alcohol: " + alcoholTB.Text + "%" +
                "\n" + "Sugar: " + sugarTB.Text + "g/l" +
                "\n" + "Extract: " + extractTB.Text + "g/l" +
                "\n" + "Bottling date: " + bdateTB.Text +
                "\n" + "Price: " + priceTB.Text + "€" +
                "\n" + "In stock: " + instockTB.Text + " btls" +
                "\n\n" + "Would you like to apply these changes?",

                "Data validation", MessageBoxButtons.YesNo);

                switch (dr)
                {
                    case DialogResult.Yes:

                        //database logic
                        SqlTools.EditWine(c_Wine.bor_id, nameTB.Text, vintageTB.Text, grapesTB.Text, sulfitesTB.Text + "mg/l", alcoholTB.Text + "%", sugarTB.Text + "g/l",  extractTB.Text + "g/l", bdateTB.Text, priceTB.Text + "€",Int32.Parse(instockTB.Text));
                        MessageBox.Show("Wine edited succesfully.");
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

            if (nameTB.Text.Length == 0 || nameTB.Text.Length > 50 ||
               vintageTB.Text.Length > 50 || grapesTB.Text.Length > 50 ||
               sulfitesTB.Text.Length > 50 || alcoholTB.Text.Length > 50 ||
               sugarTB.Text.Length > 50 || extractTB.Text.Length > 50 ||
               bdateTB.Text.Length > 50 || priceTB.Text.Length == 0 ||
               priceTB.Text.Length > 50)
            {
                valid = false;
            }

            if (int.TryParse(instockTB.Text, out parser))
            {
                if (parser < 0 || parser > 1000000)
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
        private static string RemoveEndSymbol(string inputText)
        {
            //if input string ends with any of these substrings, it removes it
            string[] remove = { "mg/l", "%", "g/l", "€" };
            foreach (string item in remove)
                if (inputText.EndsWith(item))
                {
                    inputText = inputText.Substring(0, inputText.LastIndexOf(item));
                    break; //only allow one match at most
                }

            return inputText;
        }
    }
}
