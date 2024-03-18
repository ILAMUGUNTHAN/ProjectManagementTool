using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public enum TaskStatus
    {
        NotYetStarted,
        Stuck,
        OnProcess,
        Done
    }

    public enum Priority
    {
        Critical,
        Hard,
        Medium,
        Easy
    }

    public class Task
    {
        public int TaskID;
        public string TaskName;
        public string TaskDesc;
        public int TeamLeadID;
        public int TeamMemberID;
        public int ProjectID;
        public TaskStatus StatusOfTask;
        public Priority TaskPriority;
        public DateTime StartDate;
        public DateTime EndDate;
    }
}
