using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    static class TaskManager
    {
        //Created a new Task
        public static void AddTask(string taskName, string taskDescription, DateTime startDate, DateTime endDate, Priority priority, int assignedTo, List<TaskAttachment> taskAttachments)
        {
            Task task = new Task()
            {
                TaskName = taskName,
                TaskDesc = taskDescription,
                StartDate = startDate,
                EndDate = endDate,
                TaskPriority = priority,
                StatusOfTask = TaskStatus.NotYetStarted,
                VersionID = VersionManager.CurrentVersion.VersionID,
                AssignedBy = EmployeeManager.CurrentEmployee.EmployeeID,
                AssignedTo = assignedTo,
            };

            task = DataHandler.AddTask(task);

            DataHandler.AddTaskAttachment(taskAttachments);
        }

        //Update a Task
        public static void UpdateTask(int taskID, string taskName, string taskDescription, DateTime startDate, DateTime endDate, Priority priority, int assignedTo, List<TaskAttachment> taskAttachments)
        {

            foreach(var Iter in TaskCollection)
            {
                if(Iter.TaskID == taskID)
                {
                    Iter.TaskName = taskName;   Iter.TaskDesc = taskDescription;
                    Iter.StartDate = startDate; Iter.EndDate = endDate;
                    Iter.TaskPriority = priority;   Iter.AssignedTo = assignedTo;
                    DataHandler.UpdateTask(Iter);
                }
            }
            DataHandler.UpdateTaskAttachment(taskID, taskAttachments);
        }

        //Change Status of Task
        public static void ChangeTaskStatus(int taskID, TaskStatus status)
        {
            foreach(var Iter in TaskCollection)
            {
                if(Iter.TaskID == taskID)
                {
                    Iter.StatusOfTask = status;
                    DataHandler.UpdateTask(Iter);
                    return;
                }
            }
        }

        //Fetches Task Class by Selected Version ID For Project
        public static List<Task> FetchTasksByVersionID(int versionID)
        {
            List<Task> result = new List<Task>();
            foreach(var Iter in TaskCollection)
            {
                if(Iter.VersionID == versionID)
                {
                    result.Add(Iter);
                }
            }

            result.Sort((r1, r2) => r1.EndDate.CompareTo(r2.EndDate));

            return result;
        }

        //Checks Whether Selected Date is Between Currently Working Version Project's Date Or Not
        public static bool CheckTaskDate(DateTime start, DateTime end)
        {
            if (VersionManager.CurrentVersion.StartDate<=start && VersionManager.CurrentVersion.StartDate <= end && start <= VersionManager.CurrentVersion.EndDate && end <= VersionManager.CurrentVersion.EndDate)
                return true;
            return false;
        }

        public static List<Task> TaskCollection;
    }
}
