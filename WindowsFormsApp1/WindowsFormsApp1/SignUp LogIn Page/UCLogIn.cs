using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public partial class UCLogIn : UserControl
    {
        public UCLogIn()
        {
            InitializeComponent();
            InitializeRoundedEdge();

        }

        private string EmailId = "";
        private string Password = "";

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        private void InitializeRoundedEdge()
        {
            UserIdPanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, UserIdPanel.Width, UserIdPanel.Height, 20, 20));
            PasswordPanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, PasswordPanel.Width, PasswordPanel.Height, 20, 20));
            BtnLogin.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, BtnLogin.Width, BtnLogin.Height, 20, 20));
            BtnClose.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, BtnClose.Width, BtnClose.Height, 20, 20));

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            textBoxUserID.Font = new Font(textBoxUserID.Font.FontFamily, UserIdPanel.Height/2.2f , FontStyle.Regular);
            textBoxPassword.Font = new Font(textBoxPassword.Font.FontFamily, PasswordPanel.Height/2.2f, FontStyle.Regular);
        }

        
        private void OnClickTextBox(object sender, EventArgs e)
        {

            if (textBoxUserID.Text == "")
            {
                textBoxUserID.Text = "Enter UserName";
            }

            if (textBoxPassword.Text == "")
            {

                textBoxPassword.Text = "Enter Password";

            }

            if ((sender as TextBox).Text == "Enter Password")
            {
                (sender as TextBox).Text = "";
            }
            else if ((sender as TextBox).Text == "Enter UserName")
            {
                (sender as TextBox).Text = "";
            }
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            (sender as Label).Font = new Font("Ebrima", (sender as Label).Height/3.2f, FontStyle.Bold);
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            (sender as Label).Font = new Font("Ebrima", (sender as Label).Height/3.2f, FontStyle.Regular);

        }

        private void OnMouseEnterEyePicBox(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = Properties.Resources.icons8_eye_24;
        }

        private void OnMouseLeaveEyePicBox(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = Properties.Resources.eye_Hover;

        }

        private void OnClickEye(object sender, EventArgs e)
        {
            if (textBoxPassword.UseSystemPasswordChar == false) textBoxPassword.UseSystemPasswordChar = true;
            else textBoxPassword.UseSystemPasswordChar = false;

        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            Regex regex = new Regex(pattern);

            return regex.IsMatch(email);
        }

        private void OnClickLogin(object sender, EventArgs e)
        {
            if(IsValidEmail(textBoxUserID.Text))
            {
                EmailId = textBoxUserID.Text;
                Password = textBoxPassword.Text;
            }
            else
            {
                //alter!!!!!
                MessageBox.Show("Enter Valid Email");
            }
        }
    }
}
