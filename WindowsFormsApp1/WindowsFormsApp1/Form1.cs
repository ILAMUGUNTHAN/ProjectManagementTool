using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
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
            DataHandler.ConnectDatabase();
            DataHandler.StoreEmployeeDetails();
            DataHandler.StoreEmployeeManagingDetails();
            DataHandler.StoreProjectDetails();
            DataHandler.StoreProjectVersionDetails();
            EmployeeManager.LogInEmployee("paulrobin98@gmail.com", "Lucid123");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calendar c = new Calendar();
            c.StartDate = DateTime.Today;
            c.EndDate = DateTime.Today;
            c.Show();
        }


    }
}
