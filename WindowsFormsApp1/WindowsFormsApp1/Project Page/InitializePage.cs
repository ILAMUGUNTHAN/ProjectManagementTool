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
    public partial class InitializePage : UserControl
    {
        public InitializePage()
        {
            InitializeComponent();
            InitializeRoundedEdge();
        }

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
            e.Graphics.DrawLine(pen, new Point(10, projectTitleTextBox.Location.Y + projectTitleTextBox.Height + 1), new Point(ProjectEntryTablePanel.Width - 10, projectTitleTextBox.Location.Y + projectTitleTextBox.Height + 1));
            e.Graphics.DrawLine(pen, new Point(10, projectDescTextBox.Location.Y + projectDescTextBox.Height + 1), new Point(ProjectEntryTablePanel.Width - 10, projectDescTextBox.Location.Y + projectDescTextBox.Height + 1));
            pen.Dispose();
        }

        private void ProjectEntryTablePanel_Resize(object sender, EventArgs e)
        {
            ProjectEntryTablePanel.Invalidate();
        }
    }
}
