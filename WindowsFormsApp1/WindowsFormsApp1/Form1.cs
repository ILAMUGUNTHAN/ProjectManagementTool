using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            EmployeeManager.AssignEmployee();
            ProjectsManager.AssignProjects();
            EmployeeManager.AssignEmployeeRole();
            ProjectManagingManager.AssignProjectManaging();
            TaskManager.AssignTask();
            SetTextBox1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeManager.SetEmployee(textBox1.Text);
            List<Projects> collection = ProjectsManager.FetchAllProjects();

            foreach (var Iter in collection)
            {
                richTextBox2.Text += Iter.ProjectName + "\n" + Iter.StartDate.ToShortDateString() + " - " + Iter.EndDate.ToShortDateString() + "\n";
                foreach(var Task in Iter.ProjectTaskCollection)
                {
                    richTextBox2.Text = richTextBox2.Text + Task.TaskID + " " + Task.TaskName + " " + Task.TeamMemberID + " " + Task.TeamLeadID + " " + Task.EndDate + "\n";
                }
                richTextBox2.Text += "\n\n\n";
            }
        }

        private void SetTextBox1()
        {
            List<Employee> collection = EmployeeManager.EmployeeCollection;

            foreach(var Iter in collection)
            {
                richTextBox1.Text = richTextBox1.Text + Iter.EmployeeID + " " + Iter.EmployeeName + " " + Iter.EmpSuperiorID + "\n";
            }

            List<Task> tasks = TaskManager.TaskCollection;

            foreach(var Iter in tasks)
            {
                richTextBox3.Text = richTextBox3.Text + "Project Name - " + Iter.ProjectID + "\tTeam Member - " + Iter.TeamMemberID + "\tTeam Lead - " + Iter.TeamLeadID + "\n";
            }
        }
    }
}
