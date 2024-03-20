using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AvailableTeamLeaders : UserControl
    {
        public List<Employee> TeamLeaders
        {
            get
            {
                return teamLeaders;
            }

            set
            {
                teamLeaders = value;
                if(value!=null)
                {
                    InitializeProfiles();
                }
            }
        }

        public AvailableTeamLeaders()
        {
            InitializeComponent();
        }

        private void InitializeProfiles()
        {
            foreach(var Iter in teamLeaders)
            {
                Panel newPanel = new Panel();
                newPanel.Dock = DockStyle.Top;
                profilePanel.Controls.Add(newPanel);
                ProfilePicAndName newProfilePicAndName = new ProfilePicAndName();
                newProfilePicAndName.EmployeeProfile = Iter;
                newProfilePicAndName.Dock = DockStyle.Top;
                profilePanel.Controls.Add(newProfilePicAndName);
            }
        }

        private List<Employee> teamLeaders;
    }
}
