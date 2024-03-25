using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            DataHandler.ConnectDatabase();
            DataHandler.StoreEmployeeDetails();
            EmployeeManager.LogInEmployee("paulrobin98@gmail.com", "Lucid123");
            subPagePanel.Visible = false;
            profilePictureBox1.Image =Image.FromFile(EmployeeManager.CurrentEmployee.EmpProfileLocation);
            profilePicAndName1.EmployeeProfile = EmployeeManager.CurrentEmployee;
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
        private void OnMouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            (sender as PictureBox).Parent.BackColor = Color.FromArgb(201, 210, 217);
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            (sender as PictureBox).Parent.BackColor = Color.FromArgb(221, 230, 237);
        }
        private void OnMainSectionPictureBoxMouseEnter(object sender, EventArgs e)
        {
            PictureBox picBox = sender as PictureBox;

            if (picBox.Image != null)
            {
                picBox.Image.Dispose();
            }

            if (picBox.Name == "homePictureBox")
            {
                picBox.Image = Properties.Resources.Home_Hover;
            }
            else if (picBox.Name == "projectPictureBox")
            {
                picBox.Image = Properties.Resources.Project_Hover;
            }
            else
            {
                picBox.Image = Properties.Resources.Ticket_Hover;
            }
        }
        private void OnMainSectionPictureBoxMouseLeave(object sender, EventArgs e)
        {
            PictureBox picBox = sender as PictureBox;

            if (picBox.Image != null)
            {
                picBox.Image.Dispose();
            }

            if (picBox.Name == "homePictureBox") 
            {
                picBox.Image = Properties.Resources.Home_Normal;
            }
            else if(picBox.Name == "projectPictureBox")
            {
                picBox.Image = Properties.Resources.Project_Normal;
            }
            else
            {
                picBox.Image = Properties.Resources.Ticket_Normal;
            }
        }

        private void OnDashboardButtonClick(object sender, EventArgs e)
        {
            SetSubPagesControlability((sender as PictureBox).Name);
            HighlightDashboardButton((sender as PictureBox).Name);
        }

        private void SetSubPagesControlability(string buttonName)
        {
            string roleName = EmployeeManager.CurrentEmployee.EmpRoleName;

            if (buttonName == "homePictureBox")
            {
                subPagePanel.Visible = false;
            }
            else if (buttonName == "projectPictureBox")
            {
                subPagePanel.Visible = true;
                subPage1.Visible = true;
                subPage2.Visible = true;
                subPage1.Text = "Create Project";
                subPage2.Text = "View Projects";
                if (roleName == "Project Manager")
                {
                    subPage3.Visible = false;
                    subPage4.Visible = false;
                }
                else if (roleName == "Team Leader")
                {
                    subPage3.Visible = true;
                    subPage4.Visible = true;
                    subPage3.Text = "Create Task";
                    subPage4.Text = "My Task";
                }
                else
                {
                    subPage3.Visible = true;
                    subPage4.Visible = false;
                    subPage3.Text = "My Task";
                }
            }
            else
            {
                subPagePanel.Visible = true;
                subPage1.Visible = true;
                subPage2.Visible = true;
                subPage3.Visible = false;
                subPage4.Visible = false;
                subPage1.Text = "View Issue";
                subPage2.Text = "My Issue";
                if (roleName == "Project Manager")
                {
                    subPage2.Visible = false;
                }
            }
        }

        private void HighlightDashboardButton(string buttonName)
        {
            if (buttonName == "homePictureBox")
            {
                homeTriPanel.IsHighlighted = true;
                issueTriPanel.IsHighlighted = false;
                projectTriPanel.IsHighlighted = false;
            }
            else if (buttonName == "projectPictureBox")
            {
                homeTriPanel.IsHighlighted = false;
                issueTriPanel.IsHighlighted = false;
                projectTriPanel.IsHighlighted = true;
            }
            else
            {
                homeTriPanel.IsHighlighted = false;
                issueTriPanel.IsHighlighted = true;
                projectTriPanel.IsHighlighted = false;
            }
        }

        private void OnSubHeadingsClicked(object sender, EventArgs e)
        {
            ChooseTabPage((sender as Label).Text);
        }

        private void ChooseTabPage(string controlName)
        {

        }

        private void OnClosePictureBox(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
