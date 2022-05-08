using _1075Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace _1075UI
{
    public partial class LoginForm : Form
    {

        //FOR MOVING THE BORDERLESS WINDOW
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        //CONSTRUCTOR
        public LoginForm()
        {
            InitializeComponent();
        }

        //FOR MOVING THE BORDERLESS WINDOW
        private void brightPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void woodPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        //\FOR MOVING THE BORDERLESS WINDOW

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usernameTextBox_Click(object sender, EventArgs e)
        {
            usernameTextBox.BackColor = Color.White;
            usernamePanel.BackColor = Color.White;

            passwordPanel.BackColor = SystemColors.Control;
            passwordTextBox.BackColor = SystemColors.Control;
        }

        private void passwordTextBox_Click(object sender, EventArgs e)
        {
            passwordPanel.BackColor = Color.White;
            passwordTextBox.BackColor = Color.White;

            usernameTextBox.BackColor = SystemColors.Control;
            usernamePanel.BackColor = SystemColors.Control;


        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm(this);
            this.Hide();
            registerForm.Show();
            
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();

            if (SqlTools.CheckValidLogin(username,password))
            {
                MainForm mainForm = new MainForm(this,username);
                this.Hide();
                usernameTextBox.Text ="";
                passwordTextBox.Text = "";
                mainForm.Show();
        }
            else 
            {
                MessageBox.Show("Login details incorrect.");
            }
        }

    }
}
