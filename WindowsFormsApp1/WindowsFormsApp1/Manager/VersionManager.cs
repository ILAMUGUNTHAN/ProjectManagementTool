using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public static class VersionManager
    {

        public static void AddProject(string projectName, string versionDesc, int teamLeadID, DateTime startDate, DateTime endDate, string clientEmail, List<VersionAttachment> versionAttachments)
        {
            Projects newProject = new Projects()
            {
                ProjectName = projectName,
                ManagerID = EmployeeManager.CurrentEmployee.EmployeeID,
                TeamLeadID = teamLeadID
            };

            newProject = DataHandler.AddProject(newProject);

            ProjectVersion newVersion = new ProjectVersion()
            {
                VersionName = "1.0",
                VersionDescription = versionDesc,
                ClientEmail = clientEmail,
                StartDate = startDate,
                EndDate = endDate,
                ProjectID = newProject.ProjectID,
                StatusOfVersion = (DateTime.Today.Day == startDate.Day && DateTime.Today.Month == startDate.Month && DateTime.Today.Year == startDate.Year) ? ProjectStatus.OnProcess : ProjectStatus.Upcoming
            };

            newVersion = DataHandler.AddVersion(newVersion);

            DataHandler.AddVersionAttachments(versionAttachments);

            ProjectCollection.Add(newProject);
            VersionCollection.Add(newVersion);
        }

        public static void AddVersion(string versionName, string versionDesc, int teamLeadID, DateTime startDate, DateTime endDate, string clientEmail, int projectID, List<VersionAttachment> versionAttachments)
        {
            ProjectVersion newVersion = new ProjectVersion()
            {
                VersionName = versionName,
                VersionDescription = versionDesc,
                ClientEmail = clientEmail,
                StartDate = startDate,
                EndDate = endDate,
                ProjectID = projectID,
                StatusOfVersion = (DateTime.Today.Day == startDate.Day && DateTime.Today.Month == startDate.Month && DateTime.Today.Year == startDate.Year) ? ProjectStatus.OnProcess : ProjectStatus.Upcoming
            };

            newVersion = DataHandler.AddVersion(newVersion);

            DataHandler.AddVersionAttachments(versionAttachments);

            VersionCollection.Add(newVersion);
        }

        public static void UpdateVersion()
        {

        }

        //Checks if Project is Already Available for the Project
        public static bool CanAddProject(string projectName)
        {
            foreach(var Iter in ProjectCollection)
            {
                if(Iter.ProjectName == projectName)
                {
                    return false;
                }
            }

            return true;
        }

        //Checks if Version is Already Available for the Project
        public static bool CanAddVersion(string versionName, int projectID)
        {
            foreach(var Iter in VersionCollection)
            {
                if(Iter.ProjectID == projectID && Iter.VersionName == versionName)
                {
                    return false;
                }
            }

            return true;
        }

        //Checks if Team Leader is Available for Version Upgrade for Project
        public static bool IsTeamLeadAvailableForVersionUpgrade(int projectID, DateTime startDate, DateTime endDate)
        {
            foreach(var Iter in VersionCollection)
            {
                if(Iter.ProjectID == projectID && ((Iter.StartDate <= startDate && startDate <= Iter.EndDate) || (Iter.StartDate <= endDate && endDate<= Iter.EndDate)))
                {
                    return false;
                }
            }

            return true;
        }

        //Based on Not in UpcomingProjects and Not in OnProcessProjects
        public static List<int> AvailableTeamIDs(List<int> teamIDs, DateTime projectStartDate, DateTime projectEndDate)     
        {
            List<int> result = new List<int>();

            foreach(var Iter in teamIDs)
            {
                if (IsTLEligibleForProjectVersion(Iter, projectStartDate, projectEndDate))
                {
                    result.Add(Iter);
                }
            }

            return result;
        }

        //Is Team Leader is Eligible for Created Project Version
        private static bool IsTLEligibleForProjectVersion(int teamLeadID, DateTime projectStartDate, DateTime projectEndDate)
        {
            foreach(var Iter in VersionCollection)
            {
                if (((Iter.StatusOfVersion == ProjectStatus.OnProcess && IsTLEligibleForProject(teamLeadID, Iter.ProjectID)) || (Iter.StatusOfVersion == ProjectStatus.Upcoming && IsTLEligibleForProject(teamLeadID, Iter.ProjectID))) && (Iter.StartDate <= projectStartDate && projectStartDate <= Iter.EndDate) || (Iter.StartDate <= projectEndDate && projectEndDate <= Iter.EndDate))
                {
                    return false;
                } 
            }

            return true;
        }

        //To Check the Team Leader is in Project Version from Project Collection
        private static bool IsTLEligibleForProject(int teamLeadID, int projectID)
        {
            foreach(var Iter in ProjectCollection)
            {
                if(Iter.ProjectID == projectID && Iter.TeamLeadID == teamLeadID)
                {
                    return true;
                }
            }
            return false;
        }

        public static List<Projects> ProjectCollection;
        public static List<ProjectVersion> VersionCollection;
    }
}
