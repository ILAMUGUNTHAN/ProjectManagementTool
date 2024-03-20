using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public static class EmployeeManager
    {
        public static Employee CurrentEmployee { get; private set; }
        static EmployeeManager()
        {
            CurrentEmployee = new Employee()
            {
                EmpRoleName = "Team Leader",
                EmployeeFirstName = "Pugazhenthi",
                EmpProfileLocation = "\\\\SPARE-2709DFQ\\Project Management Tool\\Profiles\\pugazhenthiir2002.jpg"
            };
        }

        public static bool LogInEmployee(string username, string password)
        {
            foreach(var Iter in EmployeeCollection)
            {
                if(Iter.EmpEmail == username && Iter.EmpPassword == password)
                {
                    CurrentEmployee = Iter;
                    return true;
                }
            }

            return false;
        }

        public static List<Employee> FetchAvailableTeamLeaders(DateTime projectStartDate, DateTime projectEndDate)
        {
            List<Employee> result = new List<Employee>();
            List<int> teamLeadIDs = new List<int>();

            foreach(var Iter in ManagingEmployeeCollection)
            {
                if(Iter.ManagerID == CurrentEmployee.EmployeeID)
                {
                    teamLeadIDs.Add(Iter.TeamLeadID);
                }
            }

            teamLeadIDs = VersionManager.AvailableTeamIDs(teamLeadIDs, projectStartDate, projectEndDate);

            foreach(var Iter in EmployeeCollection)
            {
                if (teamLeadIDs.Contains(Iter.EmployeeID))
                {
                    result.Add(Iter);
                }
            }

            return result;
        }

        public static List<Employee> EmployeeCollection;
        public static List<ManagingEmployee> ManagingEmployeeCollection;
    }
}
