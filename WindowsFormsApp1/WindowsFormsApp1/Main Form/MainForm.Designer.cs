namespace WindowsFormsApp1
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.issuePictureBox = new System.Windows.Forms.PictureBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.homePictureBox = new System.Windows.Forms.PictureBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.projectPictureBox = new System.Windows.Forms.PictureBox();
            this.subPagePanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.subPage1 = new System.Windows.Forms.Label();
            this.subPage2 = new System.Windows.Forms.Label();
            this.subPage3 = new System.Windows.Forms.Label();
            this.subPage4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.closePictureBox = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.addProject1 = new WindowsFormsApp1.Project_Page.AddProject();
            this.profilePicAndName1 = new WindowsFormsApp1.ProfilePicAndName();
            this.issueTriPanel = new WindowsFormsApp1.TriangleHighlightPanel();
            this.homeTriPanel = new WindowsFormsApp1.TriangleHighlightPanel();
            this.projectTriPanel = new WindowsFormsApp1.TriangleHighlightPanel();
            this.profilePictureBox1 = new WindowsFormsApp1.ProfilePictureBox();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.issuePictureBox)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homePictureBox)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectPictureBox)).BeginInit();
            this.subPagePanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(83, 484);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel10, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel8, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel9, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.profilePictureBox1, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(83, 484);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.issuePictureBox);
            this.panel10.Controls.Add(this.issueTriPanel);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(0, 195);
            this.panel10.Margin = new System.Windows.Forms.Padding(0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(83, 65);
            this.panel10.TabIndex = 2;
            // 
            // issuePictureBox
            // 
            this.issuePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.issuePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.issuePictureBox.Image = global::WindowsFormsApp1.Properties.Resources.Ticket_Normal;
            this.issuePictureBox.Location = new System.Drawing.Point(0, 0);
            this.issuePictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.issuePictureBox.Name = "issuePictureBox";
            this.issuePictureBox.Size = new System.Drawing.Size(68, 65);
            this.issuePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.issuePictureBox.TabIndex = 2;
            this.issuePictureBox.TabStop = false;
            this.issuePictureBox.Click += new System.EventHandler(this.OnDashboardButtonClick);
            this.issuePictureBox.MouseEnter += new System.EventHandler(this.OnMainSectionPictureBoxMouseEnter);
            this.issuePictureBox.MouseLeave += new System.EventHandler(this.OnMainSectionPictureBoxMouseLeave);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.homePictureBox);
            this.panel8.Controls.Add(this.homeTriPanel);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 65);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(83, 65);
            this.panel8.TabIndex = 0;
            // 
            // homePictureBox
            // 
            this.homePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homePictureBox.Image = global::WindowsFormsApp1.Properties.Resources.Home_Normal;
            this.homePictureBox.Location = new System.Drawing.Point(0, 0);
            this.homePictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.homePictureBox.Name = "homePictureBox";
            this.homePictureBox.Size = new System.Drawing.Size(68, 65);
            this.homePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.homePictureBox.TabIndex = 0;
            this.homePictureBox.TabStop = false;
            this.homePictureBox.Click += new System.EventHandler(this.OnDashboardButtonClick);
            this.homePictureBox.MouseEnter += new System.EventHandler(this.OnMainSectionPictureBoxMouseEnter);
            this.homePictureBox.MouseLeave += new System.EventHandler(this.OnMainSectionPictureBoxMouseLeave);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.projectPictureBox);
            this.panel9.Controls.Add(this.projectTriPanel);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(0, 130);
            this.panel9.Margin = new System.Windows.Forms.Padding(0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(83, 65);
            this.panel9.TabIndex = 1;
            // 
            // projectPictureBox
            // 
            this.projectPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.projectPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("projectPictureBox.Image")));
            this.projectPictureBox.Location = new System.Drawing.Point(0, 0);
            this.projectPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.projectPictureBox.Name = "projectPictureBox";
            this.projectPictureBox.Size = new System.Drawing.Size(68, 65);
            this.projectPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.projectPictureBox.TabIndex = 1;
            this.projectPictureBox.TabStop = false;
            this.projectPictureBox.Click += new System.EventHandler(this.OnDashboardButtonClick);
            this.projectPictureBox.MouseEnter += new System.EventHandler(this.OnMainSectionPictureBoxMouseEnter);
            this.projectPictureBox.MouseLeave += new System.EventHandler(this.OnMainSectionPictureBoxMouseLeave);
            // 
            // subPagePanel
            // 
            this.subPagePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.subPagePanel.Controls.Add(this.tableLayoutPanel2);
            this.subPagePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.subPagePanel.Location = new System.Drawing.Point(83, 0);
            this.subPagePanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.subPagePanel.Name = "subPagePanel";
            this.subPagePanel.Size = new System.Drawing.Size(164, 484);
            this.subPagePanel.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.subPage1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.subPage2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.subPage3, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.subPage4, 0, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(164, 484);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // subPage1
            // 
            this.subPage1.AutoSize = true;
            this.subPage1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.subPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subPage1.Font = new System.Drawing.Font("Ebrima", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subPage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.subPage1.Location = new System.Drawing.Point(2, 65);
            this.subPage1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.subPage1.Name = "subPage1";
            this.subPage1.Size = new System.Drawing.Size(160, 65);
            this.subPage1.TabIndex = 0;
            this.subPage1.Text = "Sub-Heading";
            this.subPage1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.subPage1.Click += new System.EventHandler(this.OnSubHeadingsClicked);
            // 
            // subPage2
            // 
            this.subPage2.AutoSize = true;
            this.subPage2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.subPage2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subPage2.Font = new System.Drawing.Font("Ebrima", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subPage2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.subPage2.Location = new System.Drawing.Point(2, 130);
            this.subPage2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.subPage2.Name = "subPage2";
            this.subPage2.Size = new System.Drawing.Size(160, 65);
            this.subPage2.TabIndex = 1;
            this.subPage2.Text = "Sub-Heading";
            this.subPage2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.subPage2.Click += new System.EventHandler(this.OnSubHeadingsClicked);
            // 
            // subPage3
            // 
            this.subPage3.AutoSize = true;
            this.subPage3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.subPage3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subPage3.Font = new System.Drawing.Font("Ebrima", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subPage3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.subPage3.Location = new System.Drawing.Point(2, 195);
            this.subPage3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.subPage3.Name = "subPage3";
            this.subPage3.Size = new System.Drawing.Size(160, 65);
            this.subPage3.TabIndex = 2;
            this.subPage3.Text = "Sub-Heading";
            this.subPage3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.subPage3.Click += new System.EventHandler(this.OnSubHeadingsClicked);
            // 
            // subPage4
            // 
            this.subPage4.AutoSize = true;
            this.subPage4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.subPage4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subPage4.Font = new System.Drawing.Font("Ebrima", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subPage4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.subPage4.Location = new System.Drawing.Point(2, 260);
            this.subPage4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.subPage4.Name = "subPage4";
            this.subPage4.Size = new System.Drawing.Size(160, 65);
            this.subPage4.TabIndex = 3;
            this.subPage4.Text = "Sub-Heading";
            this.subPage4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.subPage4.Click += new System.EventHandler(this.OnSubHeadingsClicked);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(247, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(801, 42);
            this.panel3.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.pictureBox2);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(536, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(50, 42);
            this.panel7.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.Notify_Off;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.profilePicAndName1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(586, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(165, 42);
            this.panel6.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.closePictureBox);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(751, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(50, 42);
            this.panel5.TabIndex = 0;
            // 
            // closePictureBox
            // 
            this.closePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.closePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("closePictureBox.Image")));
            this.closePictureBox.Location = new System.Drawing.Point(0, 0);
            this.closePictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.closePictureBox.Name = "closePictureBox";
            this.closePictureBox.Size = new System.Drawing.Size(50, 42);
            this.closePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.closePictureBox.TabIndex = 0;
            this.closePictureBox.TabStop = false;
            this.closePictureBox.Click += new System.EventHandler(this.OnClosePictureBox);
            this.closePictureBox.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.closePictureBox.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl1.Location = new System.Drawing.Point(247, 42);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(801, 442);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Location = new System.Drawing.Point(4, 5);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(793, 433);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.panel4.Controls.Add(this.addProject1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(2, 2);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(789, 429);
            this.panel4.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 5);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(793, 433);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // addProject1
            // 
            this.addProject1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addProject1.Location = new System.Drawing.Point(0, 0);
            this.addProject1.Name = "addProject1";
            this.addProject1.Size = new System.Drawing.Size(789, 429);
            this.addProject1.TabIndex = 0;
            // 
            // profilePicAndName1
            // 
            this.profilePicAndName1.BackColor = System.Drawing.Color.Transparent;
            this.profilePicAndName1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profilePicAndName1.EmployeeProfile = null;
            this.profilePicAndName1.Location = new System.Drawing.Point(0, 0);
            this.profilePicAndName1.Margin = new System.Windows.Forms.Padding(1);
            this.profilePicAndName1.Name = "profilePicAndName1";
            this.profilePicAndName1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.profilePicAndName1.Size = new System.Drawing.Size(165, 42);
            this.profilePicAndName1.TabIndex = 0;
            // 
            // issueTriPanel
            // 
            this.issueTriPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.issueTriPanel.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.issueTriPanel.Location = new System.Drawing.Point(68, 0);
            this.issueTriPanel.Margin = new System.Windows.Forms.Padding(2);
            this.issueTriPanel.Name = "issueTriPanel";
            this.issueTriPanel.Size = new System.Drawing.Size(15, 65);
            this.issueTriPanel.TabIndex = 3;
            // 
            // homeTriPanel
            // 
            this.homeTriPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.homeTriPanel.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.homeTriPanel.Location = new System.Drawing.Point(68, 0);
            this.homeTriPanel.Margin = new System.Windows.Forms.Padding(2);
            this.homeTriPanel.Name = "homeTriPanel";
            this.homeTriPanel.Size = new System.Drawing.Size(15, 65);
            this.homeTriPanel.TabIndex = 0;
            // 
            // projectTriPanel
            // 
            this.projectTriPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.projectTriPanel.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.projectTriPanel.Location = new System.Drawing.Point(68, 0);
            this.projectTriPanel.Margin = new System.Windows.Forms.Padding(2);
            this.projectTriPanel.Name = "projectTriPanel";
            this.projectTriPanel.Size = new System.Drawing.Size(15, 65);
            this.projectTriPanel.TabIndex = 2;
            // 
            // profilePictureBox1
            // 
            this.profilePictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profilePictureBox1.Location = new System.Drawing.Point(3, 422);
            this.profilePictureBox1.Name = "profilePictureBox1";
            this.profilePictureBox1.Size = new System.Drawing.Size(59, 59);
            this.profilePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePictureBox1.TabIndex = 3;
            this.profilePictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(1048, 484);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.subPagePanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.issuePictureBox)).EndInit();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.homePictureBox)).EndInit();
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.projectPictureBox)).EndInit();
            this.subPagePanel.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel subPagePanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox closePictureBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.PictureBox issuePictureBox;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.PictureBox homePictureBox;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.PictureBox projectPictureBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label subPage1;
        private System.Windows.Forms.Label subPage2;
        private System.Windows.Forms.Label subPage3;
        private System.Windows.Forms.Label subPage4;
        private TriangleHighlightPanel issueTriPanel;
        private TriangleHighlightPanel homeTriPanel;
        private TriangleHighlightPanel projectTriPanel;
        private ProfilePicAndName profilePicAndName1;
        private ProfilePictureBox profilePictureBox1;
        private Project_Page.AddProject addProject1;
    }
}