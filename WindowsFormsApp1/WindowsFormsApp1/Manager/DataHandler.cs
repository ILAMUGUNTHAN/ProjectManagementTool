using DatabaseLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public static class DataHandler
    {
        public static void ConnectDatabase()
        {
            manager = new MySqlHandler("localhost", "root", "Lucid123", "projectmanagement");
            manager.Connect();
        }

        public static Projects AddProject(Projects project)
        {
            manager.InsertData("project", new ParameterData[] 
            {
                new ParameterData("ProjectName", project.ProjectName),
                new ParameterData("ManagerID", project.ManagerID),
                new ParameterData("TeamLeaderID", project.TeamLeadID)
            });

            var result = manager.FetchData("project", "ProjectName = " + project.ProjectName).Value;

            return project;
        }

        public static ProjectVersion AddVersion(ProjectVersion version)
        {
            manager.InsertData("projectversion", new ParameterData[] 
            {
                new ParameterData("ProjectID", version.ProjectID),
                new ParameterData("VersionName", version.VersionName),
                new ParameterData("VersionDesc", version.VersionDescription),
                new ParameterData("ClientEmail", version.ClientEmail),
                new ParameterData("StartDate", version.StartDate),
                new ParameterData("EndDate", version.EndDate),
                new ParameterData("StatusOfProject", version.StatusOfVersion)
            });

            var result = manager.FetchData("projectversion", "VersionName = " + version.VersionName).Value;

            return version;
        }

        public static void AddVersionAttachments(List<VersionAttachment> versionAttachments)
        {
            foreach(var Iter in versionAttachments)
            {
                manager.InsertData("versionattachment", new ParameterData[]
                {
                    new ParameterData("VersionID", Iter.VersionID),
                    new ParameterData("AttachmentName", Iter.AttachmentName),
                    new ParameterData("AttachmentLocation", Iter.AttachmentLocation)
                });
            }
        }

        public static void StoreEmployeeDetails()
        {
            var result = manager.FetchData("employee", "").Value;
            List<Employee> employeeResult = new List<Employee>();
            for(int ctr=0; ctr < result["EmpID"].Count; ctr++)
            {
                employeeResult.Add(new Employee()
                {
                    EmployeeID = Convert.ToInt32(result["EmpID"][ctr]),
                    EmployeeFirstName = result["EmpFirstName"][ctr].ToString(),
                    EmployeeLastName = result["EmpLastName"][ctr].ToString(),
                    EmpRoleName = result["EmpDesignation"][ctr].ToString(),
                    EmpEmail = result["EmpEmail"][ctr].ToString(),
                    EmpDOB = Convert.ToDateTime(result["EmpDOB"][ctr]),
                    EmpProfileLocation = result["EmpProfileLocation"][ctr].ToString(),
                    EmpPassword = result["EmpPassword"][ctr].ToString()
                });
            }

            EmployeeManager.EmployeeCollection = employeeResult;
        }

        public static void StoreEmployeeManagingDetails()
        {
            var result = manager.FetchData("projectmanaging", "").Value;
            List<ManagingEmployee> employeeResult = new List<ManagingEmployee>();
            for (int ctr = 0; ctr < result["ProjectManagingID"].Count; ctr++)
            {
                employeeResult.Add(new ManagingEmployee()
                {
                    ManagingEmployeeID = Convert.ToInt32(result["ProjectManagingID"][ctr]),
                    ManagerID = Convert.ToInt32(result["ManagerID"][ctr]),
                    TeamLeadID = Convert.ToInt32(result["TeamLeadID"][ctr]),
                    TeamMemberID = Convert.ToInt32(result["TeamMemberID"][ctr]),
                });
            }

            EmployeeManager.ManagingEmployeeCollection = employeeResult;
        }

        public static void StoreProjectDetails()
        {
            var result = manager.FetchData("project", "").Value;
            List<Projects> employeeResult = new List<Projects>();
            for (int ctr = 0; ctr < result["ProjectID"].Count; ctr++)
            {
                employeeResult.Add(new Projects()
                {
                    ProjectID = Convert.ToInt32(result["ProjectID"][ctr]),
                    ProjectName = Convert.ToString(result["ProjectName"][ctr]),
                    ManagerID = Convert.ToInt32(result["ManagerID"][ctr]),
                    TeamLeadID = Convert.ToInt32(result["TeamLeadID"][ctr]),
                });
            }

            VersionManager.ProjectCollection = employeeResult;
        }

        public static void StoreProjectVersionDetails()
        {
            ProjectStatus status;
            string sts;
            var result = manager.FetchData("ProjectVersion", "").Value;
            List<ProjectVersion> employeeResult = new List<ProjectVersion>();
            for (int ctr = 0; ctr < result["VersionID"].Count; ctr++)
            {
                sts = Convert.ToString(result["StatusOfProject"][ctr]);
                if(sts == "OnProcess")
                {
                    status = ProjectStatus.OnProcess;
                }
                else if(sts == "Upcoming")
                {
                    status = ProjectStatus.Upcoming;
                }
                else
                {
                    status = ProjectStatus.Completed;
                }

                employeeResult.Add(new ProjectVersion()
                {
                    VersionID = Convert.ToInt32(result["VersionID"][ctr]),
                    VersionName = Convert.ToString(result["VersionName"][ctr]),
                    VersionDescription = Convert.ToString(result["VersionDesc"][ctr]),
                    ClientEmail = Convert.ToString(result["ClientEmail"][ctr]),
                    StartDate = Convert.ToDateTime(result["StartDate"][ctr]),
                    EndDate = Convert.ToDateTime(result["EndDate"][ctr]),
                    StatusOfVersion = status,
                    ProjectID = Convert.ToInt32(result["ProjectID"][ctr])
                });
            }

            VersionManager.VersionCollection = employeeResult;
        }

        private static DatabaseManager manager;
    }
}
