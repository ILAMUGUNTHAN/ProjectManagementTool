using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public static class VersionManager
    {

        public static ProjectVersion CurrentVersion { get; set; }

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

        public static void UpdateVersion(int versionID, string versionName, string versionDesc, DateTime startDate, DateTime endDate, string clientEmail, List<VersionAttachment> versionAttachments)
        {
            foreach(var Iter in VersionCollection)
            {
                if(Iter.VersionID == versionID)
                {
                    Iter.VersionName = versionName;
                    Iter.VersionDescription = versionDesc;
                    Iter.StartDate = startDate;
                    Iter.EndDate = endDate;
                    Iter.ClientEmail = clientEmail;
                    DataHandler.UpdateVersion(Iter);
                    DataHandler.UpdateVersionAttachments(Iter.VersionID, versionAttachments);
                    return;
                }
            }
        }

        //Sets Current On Process Project Version for Logged In Employee
        public static void SetCurrentWorkingVersion(int teamLeadID)
        {
            foreach(var Iter in ProjectCollection)
            {
                if (Iter.TeamLeadID == teamLeadID)
                {
                    foreach (var ctr in VersionCollection)
                    {
                        if (ctr.ProjectID == Iter.ProjectID && ctr.StatusOfVersion == ProjectStatus.OnProcess)
                        {
                            CurrentVersion = ctr;
                            return;
                        }
                    }
                }

            }
        }

        //Fetch All Version Names From Project ID Order By Descending Order
        public static List<ProjectVersion> FetchAllVersionFromProjectID(int projectID)
        {
            List<ProjectVersion> result = new List<ProjectVersion>();

            foreach(var Iter in VersionCollection)
            {
                if(Iter.ProjectID == projectID)
                {
                    result.Add(Iter);
                }
            }

            result.Sort((r1, r2) => r2.EndDate.CompareTo(r1.EndDate));

            return result;
        }

        //Fetches Team Leader Available Date for Project /  Version
        public static DateTime FetchTeamLeadAvailableDate(int teamLeadID)
        {
            DateTime availableDate = DateTime.MinValue;

            foreach(var Iter in VersionCollection)
            {
                if(teamLeadID == FetchTeamLeadIDFromProjectID(Iter.ProjectID) && (availableDate <= Iter.EndDate))
                {
                    availableDate = Iter.EndDate;
                }
            }

            return availableDate;
        }

        //Fetched Project's Latest Version
        public static ProjectVersion FetchProjectLatestVersion(int projectID)
        {
            ProjectVersion latestVersion = new ProjectVersion();
            DateTime latestDate = DateTime.MinValue;

            foreach(var Iter in VersionCollection)
            {
                if(Iter.ProjectID == projectID && (latestDate <= Iter.EndDate))
                {
                    latestVersion = Iter;
                    latestDate = Iter.EndDate;
                }
            }

            return latestVersion;
        }

        //Checks if Project Name is Already Available
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

        //Checks if Version Name is Already Available for the Project
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

        //Checks if Team Leader is Available for Version Upgrade for Project or New Project
        public static bool IsTeamAvailableForProject(int teamLeadID, DateTime startDate, DateTime endDate)
        {
            foreach(var Iter in VersionCollection)
            {
                if(teamLeadID == FetchTeamLeadIDFromProjectID(Iter.ProjectID) && ((Iter.StartDate <= startDate && startDate <= Iter.EndDate) || (Iter.StartDate <= endDate && endDate<= Iter.EndDate)))
                {
                    return false;
                }
            }

            return true;
        }

        //Available Team Leaders for Assigning New Projects
        public static HashSet<int> AvailableTeamIDs(HashSet<int> teamIDs, DateTime projectStartDate, DateTime projectEndDate)     
        {
            int teamID = -1;
            foreach(var Iter in VersionCollection)
            {
                if(teamIDs.Contains(teamID = FetchTeamLeadIDFromProjectID(Iter.ProjectID)) && ((Iter.StartDate <= projectStartDate && projectStartDate <= Iter.EndDate) || (Iter.StartDate <= projectEndDate && projectEndDate <= Iter.EndDate)))
                {
                    teamIDs.Remove(teamID);
                    teamID = -1;
                }
            }

            return teamIDs;
        }

        //Gets Team Leaders ID from Project ID
        public static int FetchTeamLeadIDFromProjectID(int projectID)
        {
            foreach(var Iter in ProjectCollection)
            {
                if(Iter.ProjectID == projectID)
                {
                    return Iter.TeamLeadID;
                }
            }

            return -1;
        }

        public static List<Projects> ProjectCollection;
        public static List<ProjectVersion> VersionCollection;
    }
}
