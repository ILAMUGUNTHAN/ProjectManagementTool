using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class TeamLeaderPicAndName : UserControl
    {
        public Employee EmployeeProfile
        {
            get
            {
                return employee;
            }

            set
            {
                employee = value;
                if (value != null)
                {
                    teamLeaderName.Text = value.EmployeeFirstName;
                    profilePictureBox1.Image = Image.FromFile(value.EmpProfileLocation);
                }
            }
        }
        public TeamLeaderPicAndName()
        {
            InitializeComponent();
        }

        private Employee employee;

        private void OnProfileClicked(object sender, EventArgs e)
        {

        }
    }
}
