using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    static class ProjectManagingManager
    {
        public static void AssignProjectManaging()
        {
            ProjectManagingCollection = new List<ProjectManaging>();
            ProjectManagingCollection.Add(new ProjectManaging()
            {
                ProjectID = 1,
                ManagerID = 19,
                TeamLeadID = 17,
            });
            ProjectManagingCollection.Add(new ProjectManaging()
            {
                ProjectID = 1,
                ManagerID = 19,
                TeamLeadID = 16,
            });
            ProjectManagingCollection.Add(new ProjectManaging()
            {
                ProjectID = 2,
                ManagerID = 19,
                TeamLeadID = 18,
            });
            ProjectManagingCollection.Add(new ProjectManaging()
            {
                ProjectID = 2,
                ManagerID = 19,
                TeamLeadID = 16,
            });
            ProjectManagingCollection.Add(new ProjectManaging()
            {
                ProjectID = 2,
                ManagerID = 19,
                TeamLeadID = 17,
            });
        }

        private static List<ProjectManaging> ProjectManagingCollection;
    }
}
