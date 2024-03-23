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
                if(value!=null && value.Count > 0)
                {
                    InitializeProfiles();
                }
            }
        }

        public delegate void EmployeeHandler(Employee employee);
        public event EmployeeHandler TeamLeaderClick;

        public AvailableTeamLeaders()
        {
            InitializeComponent();
        }

        private void InitializeProfiles()
        {
            TeamLeaderPicAndName uc;
            foreach (var Iter in teamLeaders)
            {
                uc = new TeamLeaderPicAndName();
                uc.EmployeeProfile = Iter;
                uc.Dock = DockStyle.Top;
                uc.TeamLeaderClick += OnTeamLeaderClicked;
            }
        }

        private void OnTeamLeaderClicked(Employee teamLead)
        {
            TeamLeaderClick?.Invoke(teamLead);
        }

        private List<Employee> teamLeaders;
    }
}
