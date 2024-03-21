namespace WindowsFormsApp1
{
    partial class AddProject
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.versionUpgradeButton = new System.Windows.Forms.Button();
            this.initializeButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.initializePage1 = new WindowsFormsApp1.InitializePage();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 44);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.versionUpgradeButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.initializeButton, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(662, 44);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // versionUpgradeButton
            // 
            this.versionUpgradeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.versionUpgradeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.versionUpgradeButton.FlatAppearance.BorderSize = 0;
            this.versionUpgradeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.versionUpgradeButton.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionUpgradeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.versionUpgradeButton.Location = new System.Drawing.Point(331, 0);
            this.versionUpgradeButton.Margin = new System.Windows.Forms.Padding(0);
            this.versionUpgradeButton.Name = "versionUpgradeButton";
            this.versionUpgradeButton.Size = new System.Drawing.Size(331, 44);
            this.versionUpgradeButton.TabIndex = 0;
            this.versionUpgradeButton.Text = "Version Upgrade";
            this.versionUpgradeButton.UseVisualStyleBackColor = false;
            this.versionUpgradeButton.Click += new System.EventHandler(this.versionUpgradeButton_Click);
            // 
            // initializeButton
            // 
            this.initializeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.initializeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.initializeButton.FlatAppearance.BorderSize = 0;
            this.initializeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.initializeButton.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initializeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.initializeButton.Location = new System.Drawing.Point(0, 0);
            this.initializeButton.Margin = new System.Windows.Forms.Padding(0);
            this.initializeButton.Name = "initializeButton";
            this.initializeButton.Size = new System.Drawing.Size(331, 44);
            this.initializeButton.TabIndex = 1;
            this.initializeButton.Text = "Initialize";
            this.initializeButton.UseVisualStyleBackColor = false;
            this.initializeButton.Click += new System.EventHandler(this.initializeButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.initializePage1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(662, 444);
            this.panel2.TabIndex = 1;
            // 
            // initializePage1
            // 
            this.initializePage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.initializePage1.Location = new System.Drawing.Point(0, 0);
            this.initializePage1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.initializePage1.Name = "initializePage1";
            this.initializePage1.Size = new System.Drawing.Size(662, 444);
            this.initializePage1.TabIndex = 0;
            // 
            // AddProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddProject";
            this.Size = new System.Drawing.Size(662, 488);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button versionUpgradeButton;
        private System.Windows.Forms.Button initializeButton;
        private System.Windows.Forms.Panel panel2;
        private InitializePage initializePage1;
    }
}
