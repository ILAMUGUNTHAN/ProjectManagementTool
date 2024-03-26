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
    public partial class UCCreateProject : UserControl
    {
        public UCCreateProject()
        {
            InitializeComponent();
            

        }

        public int BorderRadius { get; set; }


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

        private void OnLoad(object sender, EventArgs e)
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, BorderRadius, BorderRadius));
        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            Button curBtn = sender as Button;

            curBtn.BackColor = Color.FromArgb(221, 230, 237);
            curBtn.ForeColor = Color.FromArgb(82, 109, 130);

            if (curBtn ==  button1)
            {
                button2.ForeColor = Color.FromArgb(221, 230, 237);
                button2.BackColor = Color.FromArgb(82, 109, 130);
            }
            else
            {
                button1.ForeColor = Color.FromArgb(221, 230, 237);
                button1.BackColor = Color.FromArgb(82, 109, 130);
            }
        }

        private void OnClickNewProject(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void OnClickVersionUpgrade(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }
    }
}
