namespace WindowsFormsApp1
{
    partial class UCBarChart
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
            this.LabelDone = new System.Windows.Forms.Label();
            this.LabelInProgress = new System.Windows.Forms.Label();
            this.LabelStruck = new System.Windows.Forms.Label();
            this.LabelNotStarted = new System.Windows.Forms.Label();
            this.BtnDone = new System.Windows.Forms.Button();
            this.BtnInProgress = new System.Windows.Forms.Button();
            this.BtnStruck = new System.Windows.Forms.Button();
            this.BtnNotStarted = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Label0thValue = new System.Windows.Forms.Label();
            this.Label1thValue = new System.Windows.Forms.Label();
            this.Label2ndValue = new System.Windows.Forms.Label();
            this.Label3rdValue = new System.Windows.Forms.Label();
            this.Label4thValue = new System.Windows.Forms.Label();
            this.Label5thValue = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 10;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.LabelDone, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.LabelInProgress, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.LabelStruck, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.LabelNotStarted, 8, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnDone, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnInProgress, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnStruck, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnNotStarted, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(753, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            // 
            // LabelDone
            // 
            this.LabelDone.BackColor = System.Drawing.Color.Transparent;
            this.LabelDone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelDone.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.LabelDone.Location = new System.Drawing.Point(153, 360);
            this.LabelDone.Name = "LabelDone";
            this.LabelDone.Size = new System.Drawing.Size(69, 90);
            this.LabelDone.TabIndex = 0;
            this.LabelDone.Text = "Done";
            this.LabelDone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelInProgress
            // 
            this.LabelInProgress.BackColor = System.Drawing.Color.Transparent;
            this.LabelInProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelInProgress.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.LabelInProgress.Location = new System.Drawing.Point(303, 360);
            this.LabelInProgress.Name = "LabelInProgress";
            this.LabelInProgress.Size = new System.Drawing.Size(69, 90);
            this.LabelInProgress.TabIndex = 1;
            this.LabelInProgress.Text = "In Progres";
            this.LabelInProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelStruck
            // 
            this.LabelStruck.BackColor = System.Drawing.Color.Transparent;
            this.LabelStruck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelStruck.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStruck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.LabelStruck.Location = new System.Drawing.Point(453, 360);
            this.LabelStruck.Name = "LabelStruck";
            this.LabelStruck.Size = new System.Drawing.Size(69, 90);
            this.LabelStruck.TabIndex = 1;
            this.LabelStruck.Text = "Struck";
            this.LabelStruck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelNotStarted
            // 
            this.LabelNotStarted.BackColor = System.Drawing.Color.Transparent;
            this.LabelNotStarted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelNotStarted.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNotStarted.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.LabelNotStarted.Location = new System.Drawing.Point(603, 360);
            this.LabelNotStarted.Name = "LabelNotStarted";
            this.LabelNotStarted.Size = new System.Drawing.Size(69, 90);
            this.LabelNotStarted.TabIndex = 1;
            this.LabelNotStarted.Text = "Not Started";
            this.LabelNotStarted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnDone
            // 
            this.BtnDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(109)))), ((int)(((byte)(130)))));
            this.BtnDone.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnDone.FlatAppearance.BorderSize = 0;
            this.BtnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDone.Location = new System.Drawing.Point(150, 337);
            this.BtnDone.Margin = new System.Windows.Forms.Padding(0);
            this.BtnDone.Name = "BtnDone";
            this.BtnDone.Size = new System.Drawing.Size(75, 23);
            this.BtnDone.TabIndex = 2;
            this.BtnDone.UseVisualStyleBackColor = false;
            // 
            // BtnInProgress
            // 
            this.BtnInProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(109)))), ((int)(((byte)(130)))));
            this.BtnInProgress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnInProgress.FlatAppearance.BorderSize = 0;
            this.BtnInProgress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInProgress.Location = new System.Drawing.Point(300, 337);
            this.BtnInProgress.Margin = new System.Windows.Forms.Padding(0);
            this.BtnInProgress.Name = "BtnInProgress";
            this.BtnInProgress.Size = new System.Drawing.Size(75, 23);
            this.BtnInProgress.TabIndex = 2;
            this.BtnInProgress.UseVisualStyleBackColor = false;
            // 
            // BtnStruck
            // 
            this.BtnStruck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(109)))), ((int)(((byte)(130)))));
            this.BtnStruck.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnStruck.FlatAppearance.BorderSize = 0;
            this.BtnStruck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStruck.Location = new System.Drawing.Point(450, 337);
            this.BtnStruck.Margin = new System.Windows.Forms.Padding(0);
            this.BtnStruck.Name = "BtnStruck";
            this.BtnStruck.Size = new System.Drawing.Size(75, 23);
            this.BtnStruck.TabIndex = 2;
            this.BtnStruck.UseVisualStyleBackColor = false;
            // 
            // BtnNotStarted
            // 
            this.BtnNotStarted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(109)))), ((int)(((byte)(130)))));
            this.BtnNotStarted.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnNotStarted.FlatAppearance.BorderSize = 0;
            this.BtnNotStarted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNotStarted.Location = new System.Drawing.Point(600, 337);
            this.BtnNotStarted.Margin = new System.Windows.Forms.Padding(0);
            this.BtnNotStarted.Name = "BtnNotStarted";
            this.BtnNotStarted.Size = new System.Drawing.Size(75, 23);
            this.BtnNotStarted.TabIndex = 2;
            this.BtnNotStarted.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.Label0thValue, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.Label1thValue, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.Label2ndValue, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.Label3rdValue, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.Label4thValue, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.Label5thValue, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(75, 360);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // Label0thValue
            // 
            this.Label0thValue.BackColor = System.Drawing.Color.Transparent;
            this.Label0thValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label0thValue.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label0thValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.Label0thValue.Location = new System.Drawing.Point(0, 295);
            this.Label0thValue.Margin = new System.Windows.Forms.Padding(0);
            this.Label0thValue.Name = "Label0thValue";
            this.Label0thValue.Size = new System.Drawing.Size(75, 65);
            this.Label0thValue.TabIndex = 6;
            this.Label0thValue.Text = "0";
            this.Label0thValue.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // Label1thValue
            // 
            this.Label1thValue.BackColor = System.Drawing.Color.Transparent;
            this.Label1thValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label1thValue.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1thValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.Label1thValue.Location = new System.Drawing.Point(0, 236);
            this.Label1thValue.Margin = new System.Windows.Forms.Padding(0);
            this.Label1thValue.Name = "Label1thValue";
            this.Label1thValue.Size = new System.Drawing.Size(75, 59);
            this.Label1thValue.TabIndex = 5;
            this.Label1thValue.Text = "10";
            this.Label1thValue.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // Label2ndValue
            // 
            this.Label2ndValue.BackColor = System.Drawing.Color.Transparent;
            this.Label2ndValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label2ndValue.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2ndValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.Label2ndValue.Location = new System.Drawing.Point(0, 177);
            this.Label2ndValue.Margin = new System.Windows.Forms.Padding(0);
            this.Label2ndValue.Name = "Label2ndValue";
            this.Label2ndValue.Size = new System.Drawing.Size(75, 59);
            this.Label2ndValue.TabIndex = 4;
            this.Label2ndValue.Text = "20";
            this.Label2ndValue.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // Label3rdValue
            // 
            this.Label3rdValue.BackColor = System.Drawing.Color.Transparent;
            this.Label3rdValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label3rdValue.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3rdValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.Label3rdValue.Location = new System.Drawing.Point(0, 118);
            this.Label3rdValue.Margin = new System.Windows.Forms.Padding(0);
            this.Label3rdValue.Name = "Label3rdValue";
            this.Label3rdValue.Size = new System.Drawing.Size(75, 59);
            this.Label3rdValue.TabIndex = 3;
            this.Label3rdValue.Text = "30";
            this.Label3rdValue.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // Label4thValue
            // 
            this.Label4thValue.BackColor = System.Drawing.Color.Transparent;
            this.Label4thValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label4thValue.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4thValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.Label4thValue.Location = new System.Drawing.Point(0, 59);
            this.Label4thValue.Margin = new System.Windows.Forms.Padding(0);
            this.Label4thValue.Name = "Label4thValue";
            this.Label4thValue.Size = new System.Drawing.Size(75, 59);
            this.Label4thValue.TabIndex = 2;
            this.Label4thValue.Text = "40";
            this.Label4thValue.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // Label5thValue
            // 
            this.Label5thValue.BackColor = System.Drawing.Color.Transparent;
            this.Label5thValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label5thValue.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5thValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.Label5thValue.Location = new System.Drawing.Point(0, 0);
            this.Label5thValue.Margin = new System.Windows.Forms.Padding(0);
            this.Label5thValue.Name = "Label5thValue";
            this.Label5thValue.Size = new System.Drawing.Size(75, 59);
            this.Label5thValue.TabIndex = 1;
            this.Label5thValue.Text = "50";
            this.Label5thValue.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // UCBarChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UCBarChart";
            this.Size = new System.Drawing.Size(753, 450);
            this.Load += new System.EventHandler(this.OnLoadUc);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LabelDone;
        private System.Windows.Forms.Label LabelInProgress;
        private System.Windows.Forms.Label LabelStruck;
        private System.Windows.Forms.Label LabelNotStarted;
        private System.Windows.Forms.Button BtnDone;
        private System.Windows.Forms.Button BtnInProgress;
        private System.Windows.Forms.Button BtnStruck;
        private System.Windows.Forms.Button BtnNotStarted;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label Label0thValue;
        private System.Windows.Forms.Label Label1thValue;
        private System.Windows.Forms.Label Label2ndValue;
        private System.Windows.Forms.Label Label3rdValue;
        private System.Windows.Forms.Label Label4thValue;
        private System.Windows.Forms.Label Label5thValue;
    }
}
