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
            this.panel1 = new System.Windows.Forms.Panel();
            this.TeacherManagementPanel = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.MinuteLabel = new System.Windows.Forms.Label();
            this.HourLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.sendEmail_Button = new System.Windows.Forms.Button();
            this.Button_SetUncheck = new System.Windows.Forms.Button();
            this.Button_SpecialDayEdition = new System.Windows.Forms.Button();
            this.Button_EditEmailFormat = new System.Windows.Forms.Button();
            this.Button_EditEmailAccount = new System.Windows.Forms.Button();
            this.Button_SetTime = new System.Windows.Forms.Button();
            this.Button_SetAbsent = new System.Windows.Forms.Button();
            this.button_CallPasswordEditor = new System.Windows.Forms.Button();
            this.TeacherManagementLabel = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.B_LoadFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Label_Current_File = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.Button_TeacherManagement = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.TimeEditing = new System.Windows.Forms.ToolStripDropDownButton();
            this.editSpecialDaysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editLateTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editTimeLimitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PersonalData = new System.Windows.Forms.ToolStripDropDownButton();
            this.editManagementPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editEmailAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BarCodeInputLabel = new System.Windows.Forms.TableLayoutPanel();
            this.Box_StudentIndex = new System.Windows.Forms.TextBox();
            this.Label_StudentIndex = new System.Windows.Forms.Label();
            this.CheckButton = new System.Windows.Forms.Button();
            this.FileOpener = new System.Windows.Forms.OpenFileDialog();
            this.FileSaver = new System.Windows.Forms.SaveFileDialog();
            this.StudentListPanel = new System.Windows.Forms.Panel();
            this.UncheckPanel = new System.Windows.Forms.Panel();
            this.UncheckToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ListView_Uncheck = new System.Windows.Forms.ListView();
            this.First_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Last_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Index = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CheckedPanel = new System.Windows.Forms.Panel();
            this.CheckToolStrip = new System.Windows.Forms.ToolStrip();
            this.CStudentLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.CheckedListView = new System.Windows.Forms.ListView();
            this.First_Name_Attended = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Last_Name_Attended = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Index_Attended = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AttendedTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Course_Index = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.TeacherManagementPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.BarCodeInputLabel.SuspendLayout();
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
            this.panel1.Controls.Add(this.Course_Index);
            this.panel1.Controls.Add(this.TeacherManagementPanel);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.BarCodeInputLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 140);
            this.panel1.TabIndex = 0;
            // 
            // TeacherManagementPanel
            // 
            this.TeacherManagementPanel.Controls.Add(this.textBox2);
            this.TeacherManagementPanel.Controls.Add(this.textBox1);
            this.TeacherManagementPanel.Controls.Add(this.MinuteLabel);
            this.TeacherManagementPanel.Controls.Add(this.HourLabel);
            this.TeacherManagementPanel.Controls.Add(this.tableLayoutPanel2);
            this.TeacherManagementPanel.Controls.Add(this.TeacherManagementLabel);
            this.TeacherManagementPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.TeacherManagementPanel.Location = new System.Drawing.Point(272, 25);
            this.TeacherManagementPanel.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.TeacherManagementPanel.Name = "TeacherManagementPanel";
            this.TeacherManagementPanel.Size = new System.Drawing.Size(532, 115);
            this.TeacherManagementPanel.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(58, 72);
            this.textBox2.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(58, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(49, 30);
            this.textBox1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(68, 20);
            this.textBox1.TabIndex = 4;
            // 
            // MinuteLabel
            // 
            this.MinuteLabel.AutoSize = true;
            this.MinuteLabel.Location = new System.Drawing.Point(11, 75);
            this.MinuteLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MinuteLabel.Name = "MinuteLabel";
            this.MinuteLabel.Size = new System.Drawing.Size(45, 13);
            this.MinuteLabel.TabIndex = 3;
            this.MinuteLabel.Text = "Minute: ";
            // 
            // HourLabel
            // 
            this.HourLabel.AutoSize = true;
            this.HourLabel.Location = new System.Drawing.Point(11, 32);
            this.HourLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HourLabel.Name = "HourLabel";
            this.HourLabel.Size = new System.Drawing.Size(36, 13);
            this.HourLabel.TabIndex = 2;
            this.HourLabel.Text = "Hour: ";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel2.Controls.Add(this.sendEmail_Button, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.Button_SetUncheck, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.Button_SpecialDayEdition, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.Button_EditEmailFormat, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.Button_EditEmailAccount, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Button_SetTime, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.Button_SetAbsent, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.button_CallPasswordEditor, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(159, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.69767F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.30233F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(373, 115);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // sendEmail_Button
            // 
            this.sendEmail_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sendEmail_Button.Location = new System.Drawing.Point(259, 1);
            this.sendEmail_Button.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.sendEmail_Button.Name = "sendEmail_Button";
            this.sendEmail_Button.Size = new System.Drawing.Size(113, 28);
            this.sendEmail_Button.TabIndex = 3;
            this.sendEmail_Button.Text = "Send Email";
            this.sendEmail_Button.UseVisualStyleBackColor = true;
            this.sendEmail_Button.Click += new System.EventHandler(this.SendMailButtonClick);
            // 
            // Button_SetUncheck
            // 
            this.Button_SetUncheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_SetUncheck.Location = new System.Drawing.Point(259, 31);
            this.Button_SetUncheck.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Button_SetUncheck.Name = "Button_SetUncheck";
            this.Button_SetUncheck.Size = new System.Drawing.Size(113, 43);
            this.Button_SetUncheck.TabIndex = 0;
            this.Button_SetUncheck.Text = "Set All as Unchecked";
            this.Button_SetUncheck.UseVisualStyleBackColor = true;
            this.Button_SetUncheck.Click += new System.EventHandler(this.Button_SetAllCheckedStudentsAsUncheck_Click);
            // 
            // Button_SpecialDayEdition
            // 
            this.Button_SpecialDayEdition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_SpecialDayEdition.Location = new System.Drawing.Point(259, 76);
            this.Button_SpecialDayEdition.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Button_SpecialDayEdition.Name = "Button_SpecialDayEdition";
            this.Button_SpecialDayEdition.Size = new System.Drawing.Size(113, 38);
            this.Button_SpecialDayEdition.TabIndex = 4;
            this.Button_SpecialDayEdition.Text = "Edit Special Days";
            this.Button_SpecialDayEdition.UseVisualStyleBackColor = true;
            // 
            // Button_EditEmailFormat
            // 
            this.Button_EditEmailFormat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_EditEmailFormat.Location = new System.Drawing.Point(140, 1);
            this.Button_EditEmailFormat.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Button_EditEmailFormat.Name = "Button_EditEmailFormat";
            this.Button_EditEmailFormat.Size = new System.Drawing.Size(117, 28);
            this.Button_EditEmailFormat.TabIndex = 5;
            this.Button_EditEmailFormat.Text = "Edit Email Format";
            this.Button_EditEmailFormat.UseVisualStyleBackColor = true;
            this.Button_EditEmailFormat.Click += new System.EventHandler(this.Button_EditEmailFormat_Click);
            // 
            // Button_EditEmailAccount
            // 
            this.Button_EditEmailAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_EditEmailAccount.Location = new System.Drawing.Point(1, 1);
            this.Button_EditEmailAccount.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Button_EditEmailAccount.Name = "Button_EditEmailAccount";
            this.Button_EditEmailAccount.Size = new System.Drawing.Size(137, 28);
            this.Button_EditEmailAccount.TabIndex = 6;
            this.Button_EditEmailAccount.Text = "Edit Email Account";
            this.Button_EditEmailAccount.UseVisualStyleBackColor = true;
            this.Button_EditEmailAccount.Click += new System.EventHandler(this.Button_EditEmailAccount_Click);
            // 
            // Button_SetTime
            // 
            this.Button_SetTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_SetTime.Location = new System.Drawing.Point(1, 31);
            this.Button_SetTime.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Button_SetTime.Name = "Button_SetTime";
            this.Button_SetTime.Size = new System.Drawing.Size(137, 43);
            this.Button_SetTime.TabIndex = 2;
            this.Button_SetTime.Text = "Set this as late time";
            this.Button_SetTime.UseVisualStyleBackColor = true;
            this.Button_SetTime.Click += new System.EventHandler(this.Button_SetTime_Click);
            // 
            // Button_SetAbsent
            // 
            this.Button_SetAbsent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_SetAbsent.Location = new System.Drawing.Point(140, 31);
            this.Button_SetAbsent.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Button_SetAbsent.Name = "Button_SetAbsent";
            this.Button_SetAbsent.Size = new System.Drawing.Size(117, 43);
            this.Button_SetAbsent.TabIndex = 1;
            this.Button_SetAbsent.Text = "Set All unchecked as Absent";
            this.Button_SetAbsent.UseVisualStyleBackColor = true;
            this.Button_SetAbsent.Click += new System.EventHandler(this.Button_SetAllUncheckedStudentAsAbsent_Click);
            // 
            // button_CallPasswordEditor
            // 
            this.button_CallPasswordEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_CallPasswordEditor.Location = new System.Drawing.Point(140, 76);
            this.button_CallPasswordEditor.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.button_CallPasswordEditor.Name = "button_CallPasswordEditor";
            this.button_CallPasswordEditor.Size = new System.Drawing.Size(117, 38);
            this.button_CallPasswordEditor.TabIndex = 7;
            this.button_CallPasswordEditor.Text = "Edit Management Password";
            this.button_CallPasswordEditor.UseVisualStyleBackColor = true;
            this.button_CallPasswordEditor.Click += new System.EventHandler(this.button_CallPasswordEditor_Click);
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
            this.Label_Current_File,
            this.toolStripSeparator5,
            this.Button_TeacherManagement,
            this.toolStripSeparator6,
            this.toolStripSeparator7,
            this.TimeEditing,
            this.PersonalData});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(804, 25);
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
            this.Button_TeacherManagement.Click += new System.EventHandler(this.Button_TeacherManagement_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // TimeEditing
            // 
            this.TimeEditing.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TimeEditing.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editSpecialDaysToolStripMenuItem,
            this.editLateTimeToolStripMenuItem,
            this.editTimeLimitToolStripMenuItem});
            this.TimeEditing.Image = ((System.Drawing.Image)(resources.GetObject("TimeEditing.Image")));
            this.TimeEditing.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TimeEditing.Name = "TimeEditing";
            this.TimeEditing.Size = new System.Drawing.Size(87, 22);
            this.TimeEditing.Text = "Time Editing";
            this.TimeEditing.Visible = false;
            // 
            // editSpecialDaysToolStripMenuItem
            // 
            this.editSpecialDaysToolStripMenuItem.Name = "editSpecialDaysToolStripMenuItem";
            this.editSpecialDaysToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.editSpecialDaysToolStripMenuItem.Text = "Edit Special Days";
            this.editSpecialDaysToolStripMenuItem.ToolTipText = "For some reasons(Like PA days), we do not need any record of late time";
            // 
            // editLateTimeToolStripMenuItem
            // 
            this.editLateTimeToolStripMenuItem.Name = "editLateTimeToolStripMenuItem";
            this.editLateTimeToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.editLateTimeToolStripMenuItem.Text = "Edit Late Time";
            this.editLateTimeToolStripMenuItem.ToolTipText = "Change the amount of time for late of a student";
            // 
            // editTimeLimitToolStripMenuItem
            // 
            this.editTimeLimitToolStripMenuItem.Name = "editTimeLimitToolStripMenuItem";
            this.editTimeLimitToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.editTimeLimitToolStripMenuItem.Text = "Edit Time Limit";
            this.editTimeLimitToolStripMenuItem.ToolTipText = "Change the amount of time for determining a student is absent or not";
            // 
            // PersonalData
            // 
            this.PersonalData.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.PersonalData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editManagementPasswordToolStripMenuItem,
            this.editEmailAccountToolStripMenuItem});
            this.PersonalData.Image = ((System.Drawing.Image)(resources.GetObject("PersonalData.Image")));
            this.PersonalData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PersonalData.Name = "PersonalData";
            this.PersonalData.Size = new System.Drawing.Size(132, 22);
            this.PersonalData.Text = "Personal Data Option";
            this.PersonalData.Visible = false;
            // 
            // editManagementPasswordToolStripMenuItem
            // 
            this.editManagementPasswordToolStripMenuItem.Name = "editManagementPasswordToolStripMenuItem";
            this.editManagementPasswordToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.editManagementPasswordToolStripMenuItem.Text = "Edit Management Password";
            this.editManagementPasswordToolStripMenuItem.ToolTipText = "Change the password for entering Teacher Management Panel";
            // 
            // editEmailAccountToolStripMenuItem
            // 
            this.editEmailAccountToolStripMenuItem.Name = "editEmailAccountToolStripMenuItem";
            this.editEmailAccountToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.editEmailAccountToolStripMenuItem.Text = "Edit Email Account";
            this.editEmailAccountToolStripMenuItem.ToolTipText = "Login to your email account";
            // 
            // BarCodeInputLabel
            // 
            this.BarCodeInputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BarCodeInputLabel.ColumnCount = 1;
            this.BarCodeInputLabel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BarCodeInputLabel.Controls.Add(this.Box_StudentIndex, 0, 1);
            this.BarCodeInputLabel.Controls.Add(this.CheckButton, 0, 2);
            this.BarCodeInputLabel.Controls.Add(this.Label_StudentIndex, 0, 0);
            this.BarCodeInputLabel.Location = new System.Drawing.Point(5, 28);
            this.BarCodeInputLabel.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.BarCodeInputLabel.Name = "BarCodeInputLabel";
            this.BarCodeInputLabel.RowCount = 3;
            this.BarCodeInputLabel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.37681F));
            this.BarCodeInputLabel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.62319F));
            this.BarCodeInputLabel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.BarCodeInputLabel.Size = new System.Drawing.Size(143, 102);
            this.BarCodeInputLabel.TabIndex = 1;
            // 
            // Box_StudentIndex
            // 
            this.Box_StudentIndex.Location = new System.Drawing.Point(1, 28);
            this.Box_StudentIndex.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Box_StudentIndex.Name = "Box_StudentIndex";
            this.Box_StudentIndex.Size = new System.Drawing.Size(139, 20);
            this.Box_StudentIndex.TabIndex = 0;
            this.Box_StudentIndex.TextChanged += new System.EventHandler(this.Box_StudentIndex_TextChanged);
            // 
            // Label_StudentIndex
            // 
            this.Label_StudentIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Label_StudentIndex.Location = new System.Drawing.Point(25, 0);
            this.Label_StudentIndex.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_StudentIndex.Name = "Label_StudentIndex";
            this.Label_StudentIndex.Size = new System.Drawing.Size(93, 27);
            this.Label_StudentIndex.TabIndex = 1;
            this.Label_StudentIndex.Text = "Student Index: ";
            // 
            // CheckButton
            // 
            this.CheckButton.Location = new System.Drawing.Point(1, 59);
            this.CheckButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(139, 35);
            this.CheckButton.TabIndex = 2;
            this.CheckButton.Text = "Check This Index";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.Check_Click);
            // 
            // FileOpener
            // 
            this.FileOpener.Filter = "Comma Split Value File|*.csv";
            this.FileOpener.Title = "Load Student data";
            this.FileOpener.FileOk += new System.ComponentModel.CancelEventHandler(this.FileOpener_FileOk);
            // 
            // FileSaver
            // 
            this.FileSaver.Filter = "Comma Split Value File|*.csv";
            // 
            // StudentListPanel
            // 
            this.StudentListPanel.Controls.Add(this.UncheckPanel);
            this.StudentListPanel.Controls.Add(this.CheckedPanel);
            this.StudentListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StudentListPanel.Location = new System.Drawing.Point(0, 140);
            this.StudentListPanel.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.StudentListPanel.Name = "StudentListPanel";
            this.StudentListPanel.Size = new System.Drawing.Size(804, 461);
            this.StudentListPanel.TabIndex = 1;
            // 
            // UncheckPanel
            // 
            this.UncheckPanel.AutoSize = true;
            this.UncheckPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UncheckPanel.Controls.Add(this.UncheckToolStrip);
            this.UncheckPanel.Controls.Add(this.ListView_Uncheck);
            this.UncheckPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UncheckPanel.Location = new System.Drawing.Point(0, 0);
            this.UncheckPanel.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.UncheckPanel.Name = "UncheckPanel";
            this.UncheckPanel.Size = new System.Drawing.Size(360, 461);
            this.UncheckPanel.TabIndex = 3;
            // 
            // UncheckToolStrip
            // 
            this.UncheckToolStrip.AllowMerge = false;
            this.UncheckToolStrip.AutoSize = false;
            this.UncheckToolStrip.CanOverflow = false;
            this.UncheckToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.UncheckToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.UncheckToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator3});
            this.UncheckToolStrip.Location = new System.Drawing.Point(0, 0);
            this.UncheckToolStrip.Name = "UncheckToolStrip";
            this.UncheckToolStrip.Size = new System.Drawing.Size(360, 29);
            this.UncheckToolStrip.TabIndex = 3;
            this.UncheckToolStrip.Text = "toolStrip2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(115, 26);
            this.toolStripLabel1.Text = "Unchecked Students";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 29);
            // 
            // ListView_Uncheck
            // 
            this.ListView_Uncheck.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.First_Name,
            this.Last_Name,
            this.Index});
            this.ListView_Uncheck.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ListView_Uncheck.FullRowSelect = true;
            this.ListView_Uncheck.GridLines = true;
            this.ListView_Uncheck.Location = new System.Drawing.Point(0, 22);
            this.ListView_Uncheck.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.ListView_Uncheck.MultiSelect = false;
            this.ListView_Uncheck.Name = "ListView_Uncheck";
            this.ListView_Uncheck.Size = new System.Drawing.Size(360, 439);
            this.ListView_Uncheck.TabIndex = 1;
            this.ListView_Uncheck.UseCompatibleStateImageBehavior = false;
            this.ListView_Uncheck.View = System.Windows.Forms.View.Details;
            // 
            // First_Name
            // 
            this.First_Name.Text = "First Name";
            this.First_Name.Width = 102;
            // 
            // Last_Name
            // 
            this.Last_Name.Text = "Last Name";
            this.Last_Name.Width = 101;
            // 
            // Index
            // 
            this.Index.Text = "Student Number";
            this.Index.Width = 141;
            // 
            // CheckedPanel
            // 
            this.CheckedPanel.Controls.Add(this.CheckToolStrip);
            this.CheckedPanel.Controls.Add(this.CheckedListView);
            this.CheckedPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.CheckedPanel.Location = new System.Drawing.Point(360, 0);
            this.CheckedPanel.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.CheckedPanel.Name = "CheckedPanel";
            this.CheckedPanel.Size = new System.Drawing.Size(444, 461);
            this.CheckedPanel.TabIndex = 2;
            // 
            // CheckToolStrip
            // 
            this.CheckToolStrip.AllowMerge = false;
            this.CheckToolStrip.AutoSize = false;
            this.CheckToolStrip.CanOverflow = false;
            this.CheckToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.CheckToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.CheckToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CStudentLabel,
            this.toolStripSeparator4});
            this.CheckToolStrip.Location = new System.Drawing.Point(0, 0);
            this.CheckToolStrip.Name = "CheckToolStrip";
            this.CheckToolStrip.Size = new System.Drawing.Size(444, 29);
            this.CheckToolStrip.TabIndex = 3;
            this.CheckToolStrip.Text = "toolStrip3";
            // 
            // CStudentLabel
            // 
            this.CStudentLabel.Name = "CStudentLabel";
            this.CStudentLabel.Size = new System.Drawing.Size(102, 26);
            this.CStudentLabel.Text = "Checked Students";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 29);
            // 
            // CheckedListView
            // 
            this.CheckedListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.First_Name_Attended,
            this.Last_Name_Attended,
            this.Index_Attended,
            this.AttendedTime});
            this.CheckedListView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CheckedListView.FullRowSelect = true;
            this.CheckedListView.GridLines = true;
            this.CheckedListView.Location = new System.Drawing.Point(0, 22);
            this.CheckedListView.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.CheckedListView.MultiSelect = false;
            this.CheckedListView.Name = "CheckedListView";
            this.CheckedListView.Size = new System.Drawing.Size(444, 439);
            this.CheckedListView.TabIndex = 2;
            this.CheckedListView.UseCompatibleStateImageBehavior = false;
            this.CheckedListView.View = System.Windows.Forms.View.Details;
            // 
            // First_Name_Attended
            // 
            this.First_Name_Attended.Text = "Name";
            this.First_Name_Attended.Width = 101;
            // 
            // Last_Name_Attended
            // 
            this.Last_Name_Attended.Text = "Last Name";
            this.Last_Name_Attended.Width = 105;
            // 
            // Index_Attended
            // 
            this.Index_Attended.Text = "Number";
            this.Index_Attended.Width = 120;
            // 
            // AttendedTime
            // 
            this.AttendedTime.Text = "Time";
            this.AttendedTime.Width = 111;
            // 
            // Course_Index
            // 
            this.Course_Index.AutoSize = true;
            this.Course_Index.Location = new System.Drawing.Point(168, 41);
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
            this.ClientSize = new System.Drawing.Size(804, 601);
            this.Controls.Add(this.StudentListPanel);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "Main";
            this.Text = "Student Attendance Manager";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TeacherManagementPanel.ResumeLayout(false);
            this.TeacherManagementPanel.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.BarCodeInputLabel.ResumeLayout(false);
            this.BarCodeInputLabel.PerformLayout();
            this.StudentListPanel.ResumeLayout(false);
            this.StudentListPanel.PerformLayout();
            this.UncheckPanel.ResumeLayout(false);
            this.UncheckToolStrip.ResumeLayout(false);
            this.UncheckToolStrip.PerformLayout();
            this.CheckedPanel.ResumeLayout(false);
            this.CheckToolStrip.ResumeLayout(false);
            this.CheckToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Label_StudentIndex;
        private System.Windows.Forms.TextBox Box_StudentIndex;
        private System.Windows.Forms.TableLayoutPanel BarCodeInputLabel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton B_LoadFile;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.OpenFileDialog FileOpener;
        private System.Windows.Forms.SaveFileDialog FileSaver;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel Label_Current_File;
        private System.Windows.Forms.Panel StudentListPanel;
        private System.Windows.Forms.Panel UncheckPanel;
        private System.Windows.Forms.Panel CheckedPanel;
        private System.Windows.Forms.ToolStrip CheckToolStrip;
        private System.Windows.Forms.ToolStripLabel CStudentLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton Button_TeacherManagement;
        private System.Windows.Forms.Panel TeacherManagementPanel;
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
        public System.Windows.Forms.ListView CheckedListView;
        private System.Windows.Forms.Label Course_Index;
        private System.Windows.Forms.Button sendEmail_Button;
        private System.Windows.Forms.Button Button_SpecialDayEdition;
        private System.Windows.Forms.Button Button_EditEmailFormat;
        private System.Windows.Forms.Button Button_EditEmailAccount;
        private System.Windows.Forms.ColumnHeader First_Name;
        private System.Windows.Forms.ColumnHeader Last_Name;
        private System.Windows.Forms.ColumnHeader Index;
        private System.Windows.Forms.ColumnHeader First_Name_Attended;
        private System.Windows.Forms.ColumnHeader Last_Name_Attended;
        private System.Windows.Forms.ColumnHeader Index_Attended;
        private System.Windows.Forms.ColumnHeader AttendedTime;
        private System.Windows.Forms.Button button_CallPasswordEditor;
        private System.Windows.Forms.ToolStripDropDownButton TimeEditing;
        private System.Windows.Forms.ToolStripMenuItem editSpecialDaysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editLateTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripDropDownButton PersonalData;
        private System.Windows.Forms.ToolStripMenuItem editManagementPasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editEmailAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editTimeLimitToolStripMenuItem;
    }
}

