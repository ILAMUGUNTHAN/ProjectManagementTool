using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    static class ProjectsManager
    {
        public static Projects CurrentProject { get; set; }

        public static List<Projects> FetchAllProjects()         //View Project Panel
        {
            List<Projects> ResultProjects = new List<Projects>();
            if(EmployeeManager.RoleName == "Senior Developer" || EmployeeManager.RoleName == "Junior Developer")
            {
                foreach(var Iter in ProjectsCollection)
                {
                    ResultProjects.Add(new Projects()
                    {
                        ProjectID = Iter.ProjectID,
                        ProjectName = Iter.ProjectName,
                        ProjectDesc = Iter.ProjectDesc,
                        ProjectStatus = Iter.ProjectStatus,
                        ManagerID = Iter.ManagerID,
                        StartDate = Iter.StartDate,
                        EndDate = Iter.EndDate,
                        ClientEmail = Iter.ClientEmail,
                        ProjectTaskCollection = TaskManager.FetchAllTaskByProjects(Iter.ProjectID)
                    });

                    if(ResultProjects[ResultProjects.Count-1].ProjectTaskCollection.Count == 0)
                    {
                        ResultProjects.RemoveAt(ResultProjects.Count - 1);
                    }
                }
            }
            else
            {
                foreach (var Iter in ProjectsCollection)
                {
                    ResultProjects.Add(new Projects()
                    {
                        ProjectID = Iter.ProjectID,
                        ProjectName = Iter.ProjectName,
                        ProjectDesc = Iter.ProjectDesc,
                        ProjectStatus = Iter.ProjectStatus,
                        ManagerID = Iter.ManagerID,
                        StartDate = Iter.StartDate,
                        EndDate = Iter.EndDate,
                        ClientEmail = Iter.ClientEmail,
                        ProjectTaskCollection = TaskManager.FetchAllTaskByProjects(Iter.ProjectID, EmployeeManager.GetTeamMembersID())
                    });

                    if (ResultProjects[ResultProjects.Count - 1].ProjectTaskCollection.Count == 0)
                    {
                        ResultProjects.RemoveAt(ResultProjects.Count - 1);
                    }
                }
            }
           
            return ResultProjects;
        }

        public static DateTime GetProjectStartDate(int projectID)
        {
            foreach(var Iter in ProjectsCollection)
            {
                if(Iter.ProjectID == projectID)
                {
                    return Iter.StartDate;
                }
            }

            return new DateTime();
        }

        public static DateTime GetProjectEndDate(int projectID)
        {
            foreach (var Iter in ProjectsCollection)
            {
                if (Iter.ProjectID == projectID)
                {
                    return Iter.EndDate;
                }
            }

            return new DateTime();
        }

        public static void AssignProjects()
        {
            ProjectsCollection = new List<Projects>();
            ProjectsCollection.Add(new Projects
            {
                ProjectID = 1,
                ProjectName = "Expense Tracker",
                ProjectDesc = "AAAAA",
                ProjectStatus = Status.Completed,
                ClientEmail = "abc@gmail.com",
                ManagerID = 19,
                StartDate = new DateTime(2023, 11, 29),
                EndDate = new DateTime(2024, 01, 05)
            });
            ProjectsCollection.Add(new Projects
            {
                ProjectID = 2,
                ProjectName = "Pedestrian Detection",
                ProjectDesc = "BBBBB",
                ProjectStatus = Status.OnProcess,
                ClientEmail = "abc@gmail.com",
                ManagerID = 19,
                StartDate = new DateTime(2024, 02, 29),
                EndDate = new DateTime(2024, 04, 12)
            });

            foreach(var Iter in ProjectsCollection)
            {
                if(Iter.ProjectStatus == Status.OnProcess)
                {
                    CurrentProject = Iter;
                    break;
                }
            }
        }

        public static List<Projects> ProjectsCollection;
    }
}
