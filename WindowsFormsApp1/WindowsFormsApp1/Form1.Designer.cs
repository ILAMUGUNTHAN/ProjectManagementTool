namespace WindowsFormsApp1
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.versionUpgrade1 = new WindowsFormsApp1.Project_Page.VersionUpgrade();
            this.SuspendLayout();
            // 
            // versionUpgrade1
            // 
            this.versionUpgrade1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.versionUpgrade1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.versionUpgrade1.Location = new System.Drawing.Point(0, 0);
            this.versionUpgrade1.Name = "versionUpgrade1";
            this.versionUpgrade1.Size = new System.Drawing.Size(1337, 784);
            this.versionUpgrade1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 784);
            this.Controls.Add(this.versionUpgrade1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private Project_Page.VersionUpgrade versionUpgrade1;
    }
}

