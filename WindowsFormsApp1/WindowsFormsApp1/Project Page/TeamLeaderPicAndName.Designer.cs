namespace WindowsFormsApp1
{
    partial class TeamLeaderPicAndName
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.teamLeaderName = new System.Windows.Forms.Label();
            this.profilePictureBox1 = new WindowsFormsApp1.ProfilePictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(327, 67);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.teamLeaderName);
            this.panel1.Controls.Add(this.profilePictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 54);
            this.panel1.TabIndex = 0;
            // 
            // teamLeaderName
            // 
            this.teamLeaderName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teamLeaderName.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamLeaderName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.teamLeaderName.Location = new System.Drawing.Point(54, 0);
            this.teamLeaderName.Name = "teamLeaderName";
            this.teamLeaderName.Size = new System.Drawing.Size(267, 54);
            this.teamLeaderName.TabIndex = 2;
            this.teamLeaderName.Text = "Team Leader Name";
            this.teamLeaderName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.teamLeaderName.Click += new System.EventHandler(this.OnProfileClicked);
            // 
            // profilePictureBox1
            // 
            this.profilePictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.profilePictureBox1.Location = new System.Drawing.Point(0, 0);
            this.profilePictureBox1.Name = "profilePictureBox1";
            this.profilePictureBox1.Size = new System.Drawing.Size(54, 54);
            this.profilePictureBox1.TabIndex = 1;
            this.profilePictureBox1.TabStop = false;
            this.profilePictureBox1.Click += new System.EventHandler(this.OnProfileClicked);
            // 
            // TeamLeaderPicAndName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TeamLeaderPicAndName";
            this.Size = new System.Drawing.Size(327, 67);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label teamLeaderName;
        private ProfilePictureBox profilePictureBox1;
    }
}
