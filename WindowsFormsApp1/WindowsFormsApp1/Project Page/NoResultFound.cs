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
    public partial class NoResultFound : UserControl
    {

        public string MessageText
        {
            get
            {
                return label1.Text;
            }

            set
            {
                label1.Text = "* " + value;
            }
        }

        public NoResultFound()
        {
            InitializeComponent();
        }
    }
}
