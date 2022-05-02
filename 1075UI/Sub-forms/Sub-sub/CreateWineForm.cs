using System;
using System.Windows.Forms;

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

        private void loginLabel_Click(object sender, EventArgs e)
        {

        }

        private void InnerForm10751_Load(object sender, EventArgs e)
        {

        }

        private void createNewWineLabel_Click(object sender, EventArgs e)
        {

        }

        private void selectPictureButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
    }
}
