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
            this.ucBarChart1 = new WindowsFormsApp1.BarChart.UCBarChart();
            this.SuspendLayout();
            // 
            // ucBarChart1
            // 
            this.ucBarChart1.BarColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ucBarChart1.EmpDetails = null;
            this.ucBarChart1.Location = new System.Drawing.Point(138, 34);
            this.ucBarChart1.Name = "ucBarChart1";
            this.ucBarChart1.Size = new System.Drawing.Size(753, 450);
            this.ucBarChart1.StatusValues = new int[] {
        0,
        32,
        44,
        22};
            this.ucBarChart1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 618);
            this.Controls.Add(this.ucBarChart1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private BarChart.UCBarChart ucBarChart1;
    }
}

