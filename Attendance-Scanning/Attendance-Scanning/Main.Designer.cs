namespace Attendance_Scanning
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("First Name", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Last Name", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Index", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("First Name", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("Last Name", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("Index", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup7 = new System.Windows.Forms.ListViewGroup("Attend Time", System.Windows.Forms.HorizontalAlignment.Left);
            this.panel1 = new System.Windows.Forms.Panel();
            this.TeacherManageMent = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.MinuteLabel = new System.Windows.Forms.Label();
            this.HourLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Button_SetUncheck = new System.Windows.Forms.Button();
            this.Button_SetAbsent = new System.Windows.Forms.Button();
            this.Button_SetTime = new System.Windows.Forms.Button();
            this.Button_SpecialDayEdition = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Button_EditEmailFormat = new System.Windows.Forms.Button();
            this.TeacherManagementLabel = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.B_LoadFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.B_DataSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Label_Current_File = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.Button_TeacherManagement = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Box_StudentIndex = new System.Windows.Forms.TextBox();
            this.Label_StudentIndex = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.FileOpener = new System.Windows.Forms.OpenFileDialog();
            this.FileSaver = new System.Windows.Forms.SaveFileDialog();
            this.StudentListPanel = new System.Windows.Forms.Panel();
            this.UncheckPanel = new System.Windows.Forms.Panel();
            this.UncheckToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ListView_Uncheck = new System.Windows.Forms.ListView();
            this.CheckedPanel = new System.Windows.Forms.Panel();
            this.CheckToolStrip = new System.Windows.Forms.ToolStrip();
            this.CStudentLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Course_Index = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.TeacherManageMent.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.StudentListPanel.SuspendLayout();
            this.UncheckPanel.SuspendLayout();
            this.UncheckToolStrip.SuspendLayout();
            this.CheckedPanel.SuspendLayout();
            this.CheckToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TeacherManageMent);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 124);
            this.panel1.TabIndex = 0;
            // 
            // TeacherManageMent
            // 
            this.TeacherManageMent.Controls.Add(this.textBox2);
            this.TeacherManageMent.Controls.Add(this.textBox1);
            this.TeacherManageMent.Controls.Add(this.MinuteLabel);
            this.TeacherManageMent.Controls.Add(this.HourLabel);
            this.TeacherManageMent.Controls.Add(this.tableLayoutPanel2);
            this.TeacherManageMent.Controls.Add(this.TeacherManagementLabel);
            this.TeacherManageMent.Dock = System.Windows.Forms.DockStyle.Right;
            this.TeacherManageMent.Location = new System.Drawing.Point(183, 25);
            this.TeacherManageMent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TeacherManageMent.Name = "TeacherManageMent";
            this.TeacherManageMent.Size = new System.Drawing.Size(532, 99);
            this.TeacherManageMent.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(166, 69);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(68, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(47, 69);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(68, 20);
            this.textBox1.TabIndex = 4;
            // 
            // MinuteLabel
            // 
            this.MinuteLabel.AutoSize = true;
            this.MinuteLabel.Location = new System.Drawing.Point(117, 74);
            this.MinuteLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MinuteLabel.Name = "MinuteLabel";
            this.MinuteLabel.Size = new System.Drawing.Size(45, 13);
            this.MinuteLabel.TabIndex = 3;
            this.MinuteLabel.Text = "Minute: ";
            // 
            // HourLabel
            // 
            this.HourLabel.AutoSize = true;
            this.HourLabel.Location = new System.Drawing.Point(11, 74);
            this.HourLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HourLabel.Name = "HourLabel";
            this.HourLabel.Size = new System.Drawing.Size(36, 13);
            this.HourLabel.TabIndex = 2;
            this.HourLabel.Text = "Hour: ";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 155F));
            this.tableLayoutPanel2.Controls.Add(this.Button_SetUncheck, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Button_SetAbsent, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.Button_SetTime, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.Button_SpecialDayEdition, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.Button_EditEmailFormat, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(237, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.93548F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.06452F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(295, 99);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // Button_SetUncheck
            // 
            this.Button_SetUncheck.Location = new System.Drawing.Point(2, 2);
            this.Button_SetUncheck.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Button_SetUncheck.Name = "Button_SetUncheck";
            this.Button_SetUncheck.Size = new System.Drawing.Size(136, 21);
            this.Button_SetUncheck.TabIndex = 0;
            this.Button_SetUncheck.Text = "Set All as Unchecked";
            this.Button_SetUncheck.UseVisualStyleBackColor = true;
            this.Button_SetUncheck.Click += new System.EventHandler(this.Button_SetAllCheckedStudentsAsUncheck_Click);
            // 
            // Button_SetAbsent
            // 
            this.Button_SetAbsent.Location = new System.Drawing.Point(2, 27);
            this.Button_SetAbsent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Button_SetAbsent.Name = "Button_SetAbsent";
            this.Button_SetAbsent.Size = new System.Drawing.Size(136, 30);
            this.Button_SetAbsent.TabIndex = 1;
            this.Button_SetAbsent.Text = "Set All unchecked as Absent";
            this.Button_SetAbsent.UseVisualStyleBackColor = true;
            this.Button_SetAbsent.Click += new System.EventHandler(this.Button_SetAllUncheckedStudentAsAbsent_Click);
            // 
            // Button_SetTime
            // 
            this.Button_SetTime.Location = new System.Drawing.Point(2, 61);
            this.Button_SetTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Button_SetTime.Name = "Button_SetTime";
            this.Button_SetTime.Size = new System.Drawing.Size(136, 35);
            this.Button_SetTime.TabIndex = 2;
            this.Button_SetTime.Text = "Set this as late time";
            this.Button_SetTime.UseVisualStyleBackColor = true;
            // 
            // Button_SpecialDayEdition
            // 
            this.Button_SpecialDayEdition.Location = new System.Drawing.Point(142, 27);
            this.Button_SpecialDayEdition.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Button_SpecialDayEdition.Name = "Button_SpecialDayEdition";
            this.Button_SpecialDayEdition.Size = new System.Drawing.Size(151, 30);
            this.Button_SpecialDayEdition.TabIndex = 4;
            this.Button_SpecialDayEdition.Text = "Edit Special Days";
            this.Button_SpecialDayEdition.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(142, 2);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 21);
            this.button2.TabIndex = 3;
            this.button2.Text = "Send Email";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Button_EditEmailFormat
            // 
            this.Button_EditEmailFormat.Location = new System.Drawing.Point(142, 61);
            this.Button_EditEmailFormat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Button_EditEmailFormat.Name = "Button_EditEmailFormat";
            this.Button_EditEmailFormat.Size = new System.Drawing.Size(151, 35);
            this.Button_EditEmailFormat.TabIndex = 5;
            this.Button_EditEmailFormat.Text = "Edit Email Format";
            this.Button_EditEmailFormat.UseVisualStyleBackColor = true;
            this.Button_EditEmailFormat.Click += new System.EventHandler(this.Button_EditEmailFormat_Click);
            // 
            // TeacherManagementLabel
            // 
            this.TeacherManagementLabel.AutoSize = true;
            this.TeacherManagementLabel.Location = new System.Drawing.Point(3, 3);
            this.TeacherManagementLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TeacherManagementLabel.Name = "TeacherManagementLabel";
            this.TeacherManagementLabel.Size = new System.Drawing.Size(112, 13);
            this.TeacherManagementLabel.TabIndex = 0;
            this.TeacherManagementLabel.Text = "Teacher Management";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.B_LoadFile,
            this.toolStripSeparator1,
            this.B_DataSave,
            this.toolStripSeparator2,
            this.Label_Current_File,
            this.toolStripSeparator5,
            this.Button_TeacherManagement});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(715, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // B_LoadFile
            // 
            this.B_LoadFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.B_LoadFile.Image = ((System.Drawing.Image)(resources.GetObject("B_LoadFile.Image")));
            this.B_LoadFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.B_LoadFile.Name = "B_LoadFile";
            this.B_LoadFile.Size = new System.Drawing.Size(108, 22);
            this.B_LoadFile.Text = "Load Student Data";
            this.B_LoadFile.Click += new System.EventHandler(this.LoadFileButtonClicked);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // B_DataSave
            // 
            this.B_DataSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.B_DataSave.Image = ((System.Drawing.Image)(resources.GetObject("B_DataSave.Image")));
            this.B_DataSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.B_DataSave.Name = "B_DataSave";
            this.B_DataSave.Size = new System.Drawing.Size(62, 22);
            this.B_DataSave.Text = "Save Data";
            this.B_DataSave.Click += new System.EventHandler(this.FileSaverButtonClicked);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // Label_Current_File
            // 
            this.Label_Current_File.Name = "Label_Current_File";
            this.Label_Current_File.Size = new System.Drawing.Size(74, 22);
            this.Label_Current_File.Text = "Current File: ";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // Button_TeacherManagement
            // 
            this.Button_TeacherManagement.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Button_TeacherManagement.Image = ((System.Drawing.Image)(resources.GetObject("Button_TeacherManagement.Image")));
            this.Button_TeacherManagement.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Button_TeacherManagement.Name = "Button_TeacherManagement";
            this.Button_TeacherManagement.Size = new System.Drawing.Size(126, 22);
            this.Button_TeacherManagement.Text = "Teacher Management";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Box_StudentIndex, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Label_StudentIndex, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 28);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.37681F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.62319F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(143, 94);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // Box_StudentIndex
            // 
            this.Box_StudentIndex.Location = new System.Drawing.Point(2, 25);
            this.Box_StudentIndex.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Box_StudentIndex.Name = "Box_StudentIndex";
            this.Box_StudentIndex.Size = new System.Drawing.Size(139, 20);
            this.Box_StudentIndex.TabIndex = 0;
            // 
            // Label_StudentIndex
            // 
            this.Label_StudentIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Label_StudentIndex.AutoSize = true;
            this.Label_StudentIndex.Location = new System.Drawing.Point(32, 0);
            this.Label_StudentIndex.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_StudentIndex.Name = "Label_StudentIndex";
            this.Label_StudentIndex.Size = new System.Drawing.Size(79, 23);
            this.Label_StudentIndex.TabIndex = 1;
            this.Label_StudentIndex.Text = "Student Index: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2, 52);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Check This Index";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FileOpener
            // 
            this.FileOpener.Filter = "Comma Split Value File|*.csv";
            this.FileOpener.Title = "Load Student data";
            // 
            // FileSaver
            // 
            this.FileSaver.Filter = "Comma Split Value File|*.csv";
            // 
            // StudentListPanel
            // 
            this.StudentListPanel.Controls.Add(this.UncheckPanel);
            this.StudentListPanel.Controls.Add(this.CheckedPanel);
            this.StudentListPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.StudentListPanel.Location = new System.Drawing.Point(183, 124);
            this.StudentListPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StudentListPanel.Name = "StudentListPanel";
            this.StudentListPanel.Size = new System.Drawing.Size(532, 411);
            this.StudentListPanel.TabIndex = 1;
            // 
            // UncheckPanel
            // 
            this.UncheckPanel.Controls.Add(this.UncheckToolStrip);
            this.UncheckPanel.Controls.Add(this.ListView_Uncheck);
            this.UncheckPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UncheckPanel.Location = new System.Drawing.Point(0, 0);
            this.UncheckPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UncheckPanel.Name = "UncheckPanel";
            this.UncheckPanel.Size = new System.Drawing.Size(260, 411);
            this.UncheckPanel.TabIndex = 3;
            // 
            // UncheckToolStrip
            // 
            this.UncheckToolStrip.AutoSize = false;
            this.UncheckToolStrip.CanOverflow = false;
            this.UncheckToolStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UncheckToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.UncheckToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.UncheckToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator3});
            this.UncheckToolStrip.Location = new System.Drawing.Point(0, 0);
            this.UncheckToolStrip.Name = "UncheckToolStrip";
            this.UncheckToolStrip.Size = new System.Drawing.Size(260, 1);
            this.UncheckToolStrip.TabIndex = 3;
            this.UncheckToolStrip.Text = "toolStrip2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(115, 0);
            this.toolStripLabel1.Text = "Unchecked Students";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 1);
            // 
            // ListView_Uncheck
            // 
            this.ListView_Uncheck.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ListView_Uncheck.FullRowSelect = true;
            this.ListView_Uncheck.GridLines = true;
            listViewGroup1.Header = "First Name";
            listViewGroup1.Name = "First_Name";
            listViewGroup2.Header = "Last Name";
            listViewGroup2.Name = "Last_Name";
            listViewGroup3.Header = "Index";
            listViewGroup3.Name = "Index";
            this.ListView_Uncheck.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3});
            this.ListView_Uncheck.Location = new System.Drawing.Point(0, 1);
            this.ListView_Uncheck.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ListView_Uncheck.MultiSelect = false;
            this.ListView_Uncheck.Name = "ListView_Uncheck";
            this.ListView_Uncheck.Size = new System.Drawing.Size(260, 410);
            this.ListView_Uncheck.TabIndex = 1;
            this.ListView_Uncheck.UseCompatibleStateImageBehavior = false;
            this.ListView_Uncheck.View = System.Windows.Forms.View.Details;
            // 
            // CheckedPanel
            // 
            this.CheckedPanel.Controls.Add(this.CheckToolStrip);
            this.CheckedPanel.Controls.Add(this.listView1);
            this.CheckedPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.CheckedPanel.Location = new System.Drawing.Point(260, 0);
            this.CheckedPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CheckedPanel.Name = "CheckedPanel";
            this.CheckedPanel.Size = new System.Drawing.Size(272, 411);
            this.CheckedPanel.TabIndex = 2;
            // 
            // CheckToolStrip
            // 
            this.CheckToolStrip.AutoSize = false;
            this.CheckToolStrip.CanOverflow = false;
            this.CheckToolStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.CheckToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.CheckToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CStudentLabel,
            this.toolStripSeparator4});
            this.CheckToolStrip.Location = new System.Drawing.Point(0, 0);
            this.CheckToolStrip.Name = "CheckToolStrip";
            this.CheckToolStrip.Size = new System.Drawing.Size(272, 1);
            this.CheckToolStrip.TabIndex = 3;
            this.CheckToolStrip.Text = "toolStrip3";
            // 
            // CStudentLabel
            // 
            this.CStudentLabel.Name = "CStudentLabel";
            this.CStudentLabel.Size = new System.Drawing.Size(102, 0);
            this.CStudentLabel.Text = "Checked Students";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 1);
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            listViewGroup4.Header = "First Name";
            listViewGroup4.Name = "First_Name";
            listViewGroup5.Header = "Last Name";
            listViewGroup5.Name = "Last_Name";
            listViewGroup6.Header = "Index";
            listViewGroup6.Name = "Index";
            listViewGroup7.Header = "Attend Time";
            listViewGroup7.Name = "Attend_Time";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup4,
            listViewGroup5,
            listViewGroup6,
            listViewGroup7});
            this.listView1.Location = new System.Drawing.Point(0, 1);
            this.listView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(272, 410);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Course_Index
            // 
            this.Course_Index.AutoSize = true;
            this.Course_Index.Location = new System.Drawing.Point(12, 142);
            this.Course_Index.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Course_Index.Name = "Course_Index";
            this.Course_Index.Size = new System.Drawing.Size(75, 13);
            this.Course_Index.TabIndex = 2;
            this.Course_Index.Text = "Course Index: ";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(715, 535);
            this.Controls.Add(this.Course_Index);
            this.Controls.Add(this.StudentListPanel);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Main";
            this.Text = "Student Attendance Manager";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TeacherManageMent.ResumeLayout(false);
            this.TeacherManageMent.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.StudentListPanel.ResumeLayout(false);
            this.UncheckPanel.ResumeLayout(false);
            this.UncheckToolStrip.ResumeLayout(false);
            this.UncheckToolStrip.PerformLayout();
            this.CheckedPanel.ResumeLayout(false);
            this.CheckToolStrip.ResumeLayout(false);
            this.CheckToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Label_StudentIndex;
        private System.Windows.Forms.TextBox Box_StudentIndex;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton B_LoadFile;
        private System.Windows.Forms.ToolStripButton B_DataSave;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.OpenFileDialog FileOpener;
        private System.Windows.Forms.SaveFileDialog FileSaver;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel Label_Current_File;
        private System.Windows.Forms.Panel StudentListPanel;
        private System.Windows.Forms.Panel UncheckPanel;
        private System.Windows.Forms.Panel CheckedPanel;
        private System.Windows.Forms.ToolStrip CheckToolStrip;
        private System.Windows.Forms.ToolStripLabel CStudentLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton Button_TeacherManagement;
        private System.Windows.Forms.Panel TeacherManageMent;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button Button_SetUncheck;
        private System.Windows.Forms.Button Button_SetAbsent;
        private System.Windows.Forms.Button Button_SetTime;
        private System.Windows.Forms.Label TeacherManagementLabel;
        private System.Windows.Forms.ToolStrip UncheckToolStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label MinuteLabel;
        private System.Windows.Forms.Label HourLabel;
        public System.Windows.Forms.ListView ListView_Uncheck;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label Course_Index;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Button_SpecialDayEdition;
        private System.Windows.Forms.Button Button_EditEmailFormat;
    }
}

