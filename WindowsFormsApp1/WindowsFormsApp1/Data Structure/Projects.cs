using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public enum Status
    {
        OnProcess,
        Completed,
        BugResolve
    }
    class Projects
    {
        public int ProjectID;
        public string ProjectName;
        public string ProjectDesc;
        public string ClientEmail;
        public DateTime StartDate;
        public DateTime EndDate;
        public int ManagerID;
        public Status ProjectStatus;
        public List<Task> ProjectTaskCollection;

        public Projects()
        {
            ProjectTaskCollection = null;
        }
    }
}
