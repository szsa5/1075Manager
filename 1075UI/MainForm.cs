using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace _1075UI
{
    public partial class MainForm : Form
    {
        private LoginForm _loginForm;
        string user_name;

        //FOR MOVING THE BORDERLESS WINDOW
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public MainForm(LoginForm loginForm, string username)
        {
            InitializeComponent();
            _loginForm = loginForm;
            user_name = username;
            usernameLabel.Text = username;
            navPanel.Height = dashboardButton.Height;
            navPanel.Top = dashboardButton.Top;
            navPanel.Left = dashboardButton.Left;
            dashboardButton.PerformClick();
        }

        //FOR MOVING THE BORDERLESS WINDOW
        private void DashboardForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        //\FOR MOVING THE BORDERLESS WINDOW

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            navPanel.Height = dashboardButton.Height;
            navPanel.Top = dashboardButton.Top;
            navPanel.Left = dashboardButton.Left;
            dashboardButton.BackColor = Color.FromArgb(50, Color.BurlyWood);

            titleLabel.Text = "Dashboard";
            this.formLoaderPanel.Controls.Clear();
            DashboardForm dashboardForm = new DashboardForm() {Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            dashboardForm.FormBorderStyle = FormBorderStyle.None;
            this.formLoaderPanel.Controls.Add(dashboardForm);

            addWineButton.Visible = false;

            dashboardForm.Show();
        }
        private void winesButton_Click(object sender, EventArgs e)
        {
            navPanel.Height = winesButton.Height;
            navPanel.Top = winesButton.Top;
            winesButton.BackColor = Color.FromArgb(50, Color.BurlyWood);

            titleLabel.Text = "Wines";
            this.formLoaderPanel.Controls.Clear();
            WinesForm winesForm = new WinesForm(addWineButton) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            winesForm.FormBorderStyle = FormBorderStyle.None;
            this.formLoaderPanel.Controls.Add(winesForm);

            addWineButton.Text = "ADD WINE";
            addWineButton.Visible = true;

            winesForm.Show();
        }
        private void inventoryButton_Click(object sender, EventArgs e)
        {
            navPanel.Height = inventoryButton.Height;
            navPanel.Top = inventoryButton.Top;
            inventoryButton.BackColor = Color.FromArgb(50, Color.BurlyWood);

            titleLabel.Text = "Inventory";
            this.formLoaderPanel.Controls.Clear();
            InventoryForm inventoryForm = new InventoryForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            inventoryForm.FormBorderStyle = FormBorderStyle.None;
            this.formLoaderPanel.Controls.Add(inventoryForm);

            addWineButton.Visible = false;

            inventoryForm.Show();
        }

        private void shipmentsButton_Click(object sender, EventArgs e)
        {
            navPanel.Height = shipmentsButton.Height;
            navPanel.Top = shipmentsButton.Top;
            shipmentsButton.BackColor = Color.FromArgb(50, Color.BurlyWood);

            titleLabel.Text = "Shipments";
            this.formLoaderPanel.Controls.Clear();
            ShipmentsForm shipmentsForm = new ShipmentsForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            shipmentsForm.FormBorderStyle = FormBorderStyle.None;
            this.formLoaderPanel.Controls.Add(shipmentsForm);

            addWineButton.Visible = false;

            shipmentsForm.Show();
        }
        private void settingsButton_Click(object sender, EventArgs e)
        {
            navPanel.Height = settingsButton.Height;
            navPanel.Top = settingsButton.Top;
            settingsButton.BackColor = Color.FromArgb(50, Color.BurlyWood);

            titleLabel.Text = "Settings";
            this.formLoaderPanel.Controls.Clear();
            SettingsForm settingsForm = new SettingsForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            settingsForm.FormBorderStyle = FormBorderStyle.None;
            this.formLoaderPanel.Controls.Add(settingsForm);

            addWineButton.Visible = false;

            settingsForm.Show();
        }

        private void dashboardButton_Leave(object sender, EventArgs e)
        {
            dashboardButton.BackColor = Color.Transparent;
        }

        private void winesButton_Leave(object sender, EventArgs e)
        {
            winesButton.BackColor = Color.Transparent;
        }

        private void inventoryButton_Leave(object sender, EventArgs e)
        {
            inventoryButton.BackColor = Color.Transparent;
        }

        private void shipmentsButton_Leave(object sender, EventArgs e)
        {
            shipmentsButton.BackColor = Color.Transparent;
        }

        private void settingsButton_Leave(object sender, EventArgs e)
        {
            settingsButton.BackColor = Color.Transparent;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logout(object sender, EventArgs e)
        {
            this.Close();
            _loginForm.Show();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox1.ContextMenu = new ContextMenu();
            pictureBox1.ContextMenu.MenuItems.Add("Log out", logout);

            pictureBox1.ContextMenu.Show(pictureBox1, new Point(e.X, e.Y));
        }

        private void addWineButton_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
