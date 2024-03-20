using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public static class VersionManager
    {
        public static List<int> AvailableTeams(List<int> teamIDs)
        {
            List<int> result = new List<int>();
            int id = -1;
            foreach(var Iter in VersionCollection)
            {
                if(Iter.StatusOfVersion == ProjectStatus.Completed && teamIDs.Contains(id = FetchTeamLeadID(Iter.ProjectID)))
                {
                    result.Add(id);
                }
            }

            return result;
        }

        private static int FetchTeamLeadID(int projectID)
        {
            foreach(var Iter in ProjectCollection)
            {
                if(projectID == Iter.ProjectID)
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
