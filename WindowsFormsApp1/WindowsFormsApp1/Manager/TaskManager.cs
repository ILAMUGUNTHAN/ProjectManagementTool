using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{

    class RandomDateTime
    {
        public DateTime start;
        public DateTime end;
        Random gen;
        int range;

        public RandomDateTime()
        {
            gen = new Random();
            
        }

        public DateTime Next()
        {
            range = (end - start).Days;
            return start.AddDays(gen.Next(range)).AddHours(gen.Next(0, 24)).AddMinutes(gen.Next(0, 60)).AddSeconds(gen.Next(0, 60));
        }
    }

    static class TaskManager
    {
        public static void AddTask(string taskName, string taskDesc, int teamLeadID, int teamMemberID, Priority taskPriority, DateTime start, DateTime end)
        {
            Task newTask = new Task()
            {
                TaskID = ++taskID,
                TaskName = taskName,
                TaskDesc = taskDesc,
                ProjectID = ProjectsManager.CurrentProject.ProjectID,
                TeamLeadID = teamLeadID,
                TeamMemberID = teamMemberID,
                TaskPriority = taskPriority,
                StatusOfTask = TaskStatus.NotYetStarted,
                StartDate = start,
                EndDate = end
            };

            TaskCollection.Add(newTask);
        }

        public static void UpdateTask(string taskName, string taskDesc, int teamLeadID, int teamMemberID, Priority taskPriority, DateTime start, DateTime end)
        {
            Task newTask = new Task()
            {
                TaskID = ++taskID,
                TaskName = taskName,
                TaskDesc = taskDesc,
                ProjectID = ProjectsManager.CurrentProject.ProjectID,
                TeamLeadID = teamLeadID,
                TeamMemberID = teamMemberID,
                TaskPriority = taskPriority,
                StatusOfTask = TaskStatus.NotYetStarted,
                StartDate = start,
                EndDate = end
            };

            TaskCollection.Add(newTask);
        }

        public static List<Task> FetchAllTaskByProjects(int projectID)
        {
            List<Task> ResultTasks = new List<Task>();
            foreach(var Iter in TaskCollection)
            {
                if(projectID == Iter.ProjectID && Iter.TeamMemberID == EmployeeManager.Employee.EmployeeID)
                {
                    ResultTasks.Add(Iter);
                }
            }

            return ResultTasks;
        }

        public static List<Task> FetchAllTaskByProjects(int projectID, List<int> teamMemberIDCollection)
        {
            List<Task> ResultTasks = new List<Task>();

            foreach (var Iter in TaskCollection)
            {
                if (projectID == Iter.ProjectID && teamMemberIDCollection.Contains(Iter.TeamMemberID))
                {
                    ResultTasks.Add(Iter);
                }
            }

            return ResultTasks;
        }

        public static void SortTaskByMember(int empID, List<Task> results)
        {
            for (int ctr = 0; ctr < results.Count; ctr++)
            {
                if(results[ctr].TeamMemberID == empID)
                {
                    results.RemoveAt(ctr);
                    ctr--;
                }
            }
        }

        public static void SortTaskByDate(List<Task> results)
        {
            Task temp;
            DateTime curr = DateTime.MaxValue;
            int currIdx = 0;
            for (int row = 0; row < results.Count; row++)
            {
                curr = DateTime.MaxValue;
                currIdx = 0;
                for (int col = row; col < results.Count; col++)
                {
                    if (curr > results[col].EndDate)
                    {
                        curr = results[col].EndDate;
                        currIdx = col;
                    }
                }

                temp = results[row];
                results[row] = results[currIdx];
                results[currIdx] = temp;
            }

        }

        public static void AssignTask()
        {
            Random ran = new Random();
            TaskCollection = new List<Task>();
            int counter = 0;

            for (int ctr = 0; ctr < 60; ctr++)
            {
                int projectID = ran.Next(1, 3);

                RandomDateTime date = new RandomDateTime();
                date.start = ProjectsManager.GetProjectStartDate(projectID);
                date.end = ProjectsManager.GetProjectEndDate(projectID);
                var startDate = date.Next();

                date = new RandomDateTime();
                date.start = startDate;
                date.end = ProjectsManager.GetProjectEndDate(projectID);
                var endDate = date.Next();

                int teamMemberID = ran.Next(1, 16);
                int teamLeadID = EmployeeManager.GetSuperiorID(teamMemberID);

                TaskCollection.Add(new Task()
                {
                    TaskID = counter,
                    TaskName = "Task" + counter,
                    TaskDesc = ""+counter+counter+counter,
                    TaskPriority = (Priority)ran.Next(0, 4),
                    StatusOfTask = (TaskStatus)ran.Next(0,4),
                    ProjectID = projectID,
                    TeamLeadID = teamLeadID,
                    TeamMemberID = teamMemberID,
                    StartDate = startDate,
                    EndDate = endDate
                });
                
                counter++;
            }

            taskID = int.MinValue;

            foreach (var Iter in TaskCollection)
            {
                taskID = Math.Max(taskID, Iter.TaskID);
            }
        }

        public static List<Task> TaskCollection;
        private static int taskID;
    }
}
