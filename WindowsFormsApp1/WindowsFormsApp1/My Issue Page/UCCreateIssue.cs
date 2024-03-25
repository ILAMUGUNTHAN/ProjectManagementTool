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

namespace WindowsFormsApp1
{
    public partial class UCCreateIssue : UserControl
    {
        public UCCreateIssue()
        {
            InitializeComponent();
            InitializeRoundedEdge();

            panelTags.HorizontalScroll.Enabled = false;
            panelTags.HorizontalScroll.Visible = false;
        }

        PriorityDropDownForm PriorityForm;
        TypeDropDownForm TypeForm;
        private UCTags tag;


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
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 20, 20));
            panel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width, panel2.Height, 20, 20));
            panel3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel3.Width, panel3.Height, 20, 20));
            panel4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel4.Width, panel4.Height, 20, 20));
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            InitializeRoundedEdge();
        }

        private void ProjectEntryTablePanel_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb(39, 55, 77));
            e.Graphics.DrawLine(pen, new Point(10, IssueTitleTextBox.Location.Y + IssueTitleTextBox.Height + 1), new Point(ProjectEntryTablePanel.Width - 10, IssueTitleTextBox.Location.Y + IssueTitleTextBox.Height + 1));
            e.Graphics.DrawLine(pen, new Point(10, IssueDescTextBox.Location.Y + IssueDescTextBox.Height + 1), new Point(ProjectEntryTablePanel.Width - 10, IssueDescTextBox.Location.Y + IssueDescTextBox.Height + 1));
            pen.Dispose();
        }

        private void ProjectEntryTablePanel_Resize(object sender, EventArgs e)
        {
            ProjectEntryTablePanel.Invalidate();
        }

        private void OnClickSetPriority(object sender, EventArgs e)
        {
            if(Application.OpenForms.OfType<PriorityDropDownForm>().Any())
            {
                CloseForm();
                return;
            }
            else if (Application.OpenForms.OfType<TypeDropDownForm>().Any())
            {
                CloseForm();
            }

            Button PriorityBtn = sender as Button;
            Point BtnPoint = PriorityBtn.PointToScreen(new Point(PriorityBtn.Location.X, PriorityBtn.Location.Y));

            PriorityForm = new PriorityDropDownForm();
            PriorityForm.Location = new Point(BtnPoint.X, BtnPoint.Y + PriorityBtn.Height);
            PriorityForm.Size = new Size(PriorityBtn.Width-3, PriorityForm.Height);

            PriorityForm.Show();

        }


        private void OnClickSetType(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<TypeDropDownForm>().Any())
            {
                CloseForm();
                return;
            }
            else if (Application.OpenForms.OfType<PriorityDropDownForm>().Any())
            {
                CloseForm();
            }

            Button TypeBtn = sender as Button;
            Point BtnPoint = TypeBtn.PointToScreen(new Point(TypeBtn.Location.X, TypeBtn.Location.Y));

            TypeForm = new TypeDropDownForm();
            TypeForm.Location = new Point(BtnPoint.X-TypeBtn.Width-7, BtnPoint.Y + TypeBtn.Height);
            TypeForm.Size = new Size(TypeBtn.Width - 3, TypeForm.Height);

            TypeForm.Show();
        }

        private void CloseForm()
        {
            var f1 = (Application.OpenForms.OfType<PriorityDropDownForm>().FirstOrDefault());
            var f2 = (Application.OpenForms.OfType<TypeDropDownForm>().FirstOrDefault());

            if (f1 != null)
            {
                f1.Close();
            }
            if (f2 != null)
            {
                f2.Close();
            }

        }

        private void OnClickAddTag(object sender, EventArgs e)
        {
            if(textBoxTags.Text =="")
            {
                return;
            }

            tag = new UCTags();
            tag.Size = new Size(panelTags.Width-20, panelTags.Height / 4 - 5);
            tag.Dock = DockStyle.Top;

            tag.SetText(textBoxTags.Text);

            panelTags.Controls.Add(tag);
            tag.BringToFront();

            textBoxTags.Text = "";


        }

        private void OnClickTextBox(object sender, EventArgs e)
        {
            if(textBoxTags.Text == "") textBoxTags.Text = "Enter Tags";
            if (IssueTitleTextBox.Text == "") IssueTitleTextBox.Text = "Enter Issue Name";
            if (IssueDescTextBox.Text == "") IssueDescTextBox.Text = "Enter Your Text";
            if ((sender as TextBox).Text == "Enter Tags"|| (sender as TextBox).Text== "Enter Issue Name" || (sender as TextBox).Text == "Enter Your Text")
            {
                (sender as TextBox).Text = "";
            }
        }
    }
}
