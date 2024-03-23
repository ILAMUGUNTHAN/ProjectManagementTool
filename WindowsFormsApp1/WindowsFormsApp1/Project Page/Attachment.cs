using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Project_Page
{
    public partial class Attachment : UserControl
    {
        public Attachment()
        {
            InitializeComponent();
        }

        private void OnResize(object sender, EventArgs e)
        {
            int value = (tableLayoutPanel1.Width - 200) / 2;
            label1.Margin = new Padding(value, 0, value, 0);
        }
    }
}
