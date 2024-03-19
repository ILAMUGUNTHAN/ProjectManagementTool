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
    public partial class AddProject : UserControl
    {
        public AddProject()
        {
            InitializeComponent();
        }

        private void initializeButton_Click(object sender, EventArgs e)
        {
            versionUpgradeButton.BackColor = initializeButton.ForeColor =  Color.FromArgb(39, 55, 77);
            versionUpgradeButton.ForeColor = initializeButton.BackColor =  Color.FromArgb(221, 230, 237);
        }

        private void versionUpgradeButton_Click(object sender, EventArgs e)
        {
            versionUpgradeButton.BackColor = initializeButton.ForeColor = Color.FromArgb(221, 230, 237);
            versionUpgradeButton.ForeColor = initializeButton.BackColor = Color.FromArgb(39, 55, 77);
        }
    }
}
