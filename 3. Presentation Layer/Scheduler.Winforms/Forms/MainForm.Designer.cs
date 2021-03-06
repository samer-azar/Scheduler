﻿namespace Scheduler
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
            this.tcScheduler = new System.Windows.Forms.TabControl();
            this.tpAddScheduler = new System.Windows.Forms.TabPage();
            this.btnAddScheduler = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ddlRecurrence = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTriggerDescription = new System.Windows.Forms.TextBox();
            this.ddlPartnerType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTriggerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dpExecutionTime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.labelOneTimeOnlyTag = new System.Windows.Forms.Label();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.tabControlMode = new System.Windows.Forms.TabControl();
            this.tabPageOneTimeOnly = new System.Windows.Forms.TabPage();
            this.labelOneTimeOnlyDay = new System.Windows.Forms.Label();
            this.dateTimePickerOneTimeOnlyDay = new System.Windows.Forms.DateTimePicker();
            this.tabPageDaily = new System.Windows.Forms.TabPage();
            this.btRemove = new System.Windows.Forms.Button();
            this.lbHours = new System.Windows.Forms.ListBox();
            this.btnAddHour = new System.Windows.Forms.Button();
            this.numericUpDownDaily = new System.Windows.Forms.NumericUpDown();
            this.labelDailyEvery = new System.Windows.Forms.Label();
            this.labelDailyDay = new System.Windows.Forms.Label();
            this.tabPageWeekly = new System.Windows.Forms.TabPage();
            this.labelWeeklyDays = new System.Windows.Forms.Label();
            this.checkedListBoxWeeklyDays = new System.Windows.Forms.CheckedListBox();
            this.tabPageMonthly = new System.Windows.Forms.TabPage();
            this.tabControlMonthlyMode = new System.Windows.Forms.TabControl();
            this.tabPageMonthlyDayOfMonth = new System.Windows.Forms.TabPage();
            this.checkedListBoxMonthlyDays = new System.Windows.Forms.CheckedListBox();
            this.tabPageMonthlyWeekDay = new System.Windows.Forms.TabPage();
            this.checkedListBoxMonthlyWeekNumber = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxMonthlyWeekDay = new System.Windows.Forms.CheckedListBox();
            this.labelMonthlyMonth = new System.Windows.Forms.Label();
            this.checkedListBoxMonthlyMonths = new System.Windows.Forms.CheckedListBox();
            this.tpViewScheduler = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tcScheduler.SuspendLayout();
            this.tpAddScheduler.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControlMode.SuspendLayout();
            this.tabPageOneTimeOnly.SuspendLayout();
            this.tabPageDaily.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDaily)).BeginInit();
            this.tabPageWeekly.SuspendLayout();
            this.tabPageMonthly.SuspendLayout();
            this.tabControlMonthlyMode.SuspendLayout();
            this.tabPageMonthlyDayOfMonth.SuspendLayout();
            this.tabPageMonthlyWeekDay.SuspendLayout();
            this.tpViewScheduler.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcScheduler
            // 
            this.tcScheduler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcScheduler.Controls.Add(this.tpAddScheduler);
            this.tcScheduler.Controls.Add(this.tpViewScheduler);
            this.tcScheduler.Location = new System.Drawing.Point(12, 12);
            this.tcScheduler.Name = "tcScheduler";
            this.tcScheduler.SelectedIndex = 0;
            this.tcScheduler.Size = new System.Drawing.Size(486, 655);
            this.tcScheduler.TabIndex = 65;
            this.tcScheduler.Tag = "";
            // 
            // tpAddScheduler
            // 
            this.tpAddScheduler.Controls.Add(this.btnAddScheduler);
            this.tpAddScheduler.Controls.Add(this.groupBox1);
            this.tpAddScheduler.Controls.Add(this.tabControlMode);
            this.tpAddScheduler.Location = new System.Drawing.Point(4, 22);
            this.tpAddScheduler.Name = "tpAddScheduler";
            this.tpAddScheduler.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddScheduler.Size = new System.Drawing.Size(478, 629);
            this.tpAddScheduler.TabIndex = 0;
            this.tpAddScheduler.Text = "Add";
            this.tpAddScheduler.UseVisualStyleBackColor = true;
            // 
            // btnAddScheduler
            // 
            this.btnAddScheduler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddScheduler.Location = new System.Drawing.Point(6, 600);
            this.btnAddScheduler.Name = "btnAddScheduler";
            this.btnAddScheduler.Size = new System.Drawing.Size(97, 23);
            this.btnAddScheduler.TabIndex = 66;
            this.btnAddScheduler.Text = "Add";
            this.btnAddScheduler.UseVisualStyleBackColor = true;
            this.btnAddScheduler.Click += new System.EventHandler(this.btnAddScheduler_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ddlRecurrence);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTriggerDescription);
            this.groupBox1.Controls.Add(this.ddlPartnerType);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTriggerName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dpExecutionTime);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtEndDate);
            this.groupBox1.Controls.Add(this.labelOneTimeOnlyTag);
            this.groupBox1.Controls.Add(this.dtStartDate);
            this.groupBox1.Controls.Add(this.labelStartDate);
            this.groupBox1.Controls.Add(this.labelEndDate);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 311);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Definition";
            // 
            // ddlRecurrence
            // 
            this.ddlRecurrence.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlRecurrence.FormattingEnabled = true;
            this.ddlRecurrence.Location = new System.Drawing.Point(127, 158);
            this.ddlRecurrence.Name = "ddlRecurrence";
            this.ddlRecurrence.Size = new System.Drawing.Size(276, 21);
            this.ddlRecurrence.TabIndex = 68;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 67;
            this.label4.Text = "Recurrence";
            // 
            // txtTriggerDescription
            // 
            this.txtTriggerDescription.Location = new System.Drawing.Point(127, 52);
            this.txtTriggerDescription.Multiline = true;
            this.txtTriggerDescription.Name = "txtTriggerDescription";
            this.txtTriggerDescription.Size = new System.Drawing.Size(276, 64);
            this.txtTriggerDescription.TabIndex = 66;
            // 
            // ddlPartnerType
            // 
            this.ddlPartnerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlPartnerType.FormattingEnabled = true;
            this.ddlPartnerType.Location = new System.Drawing.Point(127, 125);
            this.ddlPartnerType.Name = "ddlPartnerType";
            this.ddlPartnerType.Size = new System.Drawing.Size(276, 21);
            this.ddlPartnerType.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 64;
            this.label3.Text = "Partner Type";
            // 
            // txtTriggerName
            // 
            this.txtTriggerName.Location = new System.Drawing.Point(127, 24);
            this.txtTriggerName.Name = "txtTriggerName";
            this.txtTriggerName.Size = new System.Drawing.Size(276, 20);
            this.txtTriggerName.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "Description";
            // 
            // dpExecutionTime
            // 
            this.dpExecutionTime.CustomFormat = "";
            this.dpExecutionTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dpExecutionTime.Location = new System.Drawing.Point(127, 247);
            this.dpExecutionTime.Name = "dpExecutionTime";
            this.dpExecutionTime.ShowUpDown = true;
            this.dpExecutionTime.Size = new System.Drawing.Size(101, 20);
            this.dpExecutionTime.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "Time";
            // 
            // dtEndDate
            // 
            this.dtEndDate.Location = new System.Drawing.Point(127, 219);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(276, 20);
            this.dtEndDate.TabIndex = 55;
            this.dtEndDate.Value = new System.DateTime(2010, 7, 12, 17, 25, 0, 0);
            // 
            // labelOneTimeOnlyTag
            // 
            this.labelOneTimeOnlyTag.Location = new System.Drawing.Point(6, 27);
            this.labelOneTimeOnlyTag.Name = "labelOneTimeOnlyTag";
            this.labelOneTimeOnlyTag.Size = new System.Drawing.Size(86, 13);
            this.labelOneTimeOnlyTag.TabIndex = 62;
            this.labelOneTimeOnlyTag.Text = "Name";
            // 
            // dtStartDate
            // 
            this.dtStartDate.Location = new System.Drawing.Point(127, 191);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(276, 20);
            this.dtStartDate.TabIndex = 54;
            // 
            // labelStartDate
            // 
            this.labelStartDate.Location = new System.Drawing.Point(7, 197);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(89, 13);
            this.labelStartDate.TabIndex = 59;
            this.labelStartDate.Text = "Start date";
            // 
            // labelEndDate
            // 
            this.labelEndDate.Location = new System.Drawing.Point(7, 226);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(86, 13);
            this.labelEndDate.TabIndex = 60;
            this.labelEndDate.Text = "End date";
            // 
            // tabControlMode
            // 
            this.tabControlMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControlMode.Controls.Add(this.tabPageOneTimeOnly);
            this.tabControlMode.Controls.Add(this.tabPageDaily);
            this.tabControlMode.Controls.Add(this.tabPageWeekly);
            this.tabControlMode.Controls.Add(this.tabPageMonthly);
            this.tabControlMode.Location = new System.Drawing.Point(6, 323);
            this.tabControlMode.Name = "tabControlMode";
            this.tabControlMode.SelectedIndex = 0;
            this.tabControlMode.Size = new System.Drawing.Size(466, 261);
            this.tabControlMode.TabIndex = 64;
            // 
            // tabPageOneTimeOnly
            // 
            this.tabPageOneTimeOnly.Controls.Add(this.labelOneTimeOnlyDay);
            this.tabPageOneTimeOnly.Controls.Add(this.dateTimePickerOneTimeOnlyDay);
            this.tabPageOneTimeOnly.Location = new System.Drawing.Point(4, 22);
            this.tabPageOneTimeOnly.Name = "tabPageOneTimeOnly";
            this.tabPageOneTimeOnly.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOneTimeOnly.Size = new System.Drawing.Size(458, 235);
            this.tabPageOneTimeOnly.TabIndex = 0;
            this.tabPageOneTimeOnly.Tag = "1";
            this.tabPageOneTimeOnly.Text = "One time only";
            this.tabPageOneTimeOnly.UseVisualStyleBackColor = true;
            // 
            // labelOneTimeOnlyDay
            // 
            this.labelOneTimeOnlyDay.AutoSize = true;
            this.labelOneTimeOnlyDay.Location = new System.Drawing.Point(18, 53);
            this.labelOneTimeOnlyDay.Name = "labelOneTimeOnlyDay";
            this.labelOneTimeOnlyDay.Size = new System.Drawing.Size(29, 13);
            this.labelOneTimeOnlyDay.TabIndex = 2;
            this.labelOneTimeOnlyDay.Text = "Day:";
            // 
            // dateTimePickerOneTimeOnlyDay
            // 
            this.dateTimePickerOneTimeOnlyDay.Location = new System.Drawing.Point(68, 47);
            this.dateTimePickerOneTimeOnlyDay.Name = "dateTimePickerOneTimeOnlyDay";
            this.dateTimePickerOneTimeOnlyDay.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerOneTimeOnlyDay.TabIndex = 1;
            // 
            // tabPageDaily
            // 
            this.tabPageDaily.Controls.Add(this.btRemove);
            this.tabPageDaily.Controls.Add(this.lbHours);
            this.tabPageDaily.Controls.Add(this.btnAddHour);
            this.tabPageDaily.Controls.Add(this.numericUpDownDaily);
            this.tabPageDaily.Controls.Add(this.labelDailyEvery);
            this.tabPageDaily.Controls.Add(this.labelDailyDay);
            this.tabPageDaily.Location = new System.Drawing.Point(4, 22);
            this.tabPageDaily.Name = "tabPageDaily";
            this.tabPageDaily.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDaily.Size = new System.Drawing.Size(458, 235);
            this.tabPageDaily.TabIndex = 1;
            this.tabPageDaily.Tag = "2";
            this.tabPageDaily.Text = "Daily";
            this.tabPageDaily.UseVisualStyleBackColor = true;
            // 
            // btRemove
            // 
            this.btRemove.Location = new System.Drawing.Point(115, 72);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(86, 23);
            this.btRemove.TabIndex = 63;
            this.btRemove.Text = "Remove hour";
            this.btRemove.UseVisualStyleBackColor = true;
            // 
            // lbHours
            // 
            this.lbHours.FormattingEnabled = true;
            this.lbHours.Location = new System.Drawing.Point(24, 101);
            this.lbHours.Name = "lbHours";
            this.lbHours.Size = new System.Drawing.Size(401, 121);
            this.lbHours.TabIndex = 62;
            // 
            // btnAddHour
            // 
            this.btnAddHour.Location = new System.Drawing.Point(23, 73);
            this.btnAddHour.Name = "btnAddHour";
            this.btnAddHour.Size = new System.Drawing.Size(86, 23);
            this.btnAddHour.TabIndex = 61;
            this.btnAddHour.Text = "Add hour";
            this.btnAddHour.UseVisualStyleBackColor = true;
            // 
            // numericUpDownDaily
            // 
            this.numericUpDownDaily.Location = new System.Drawing.Point(60, 18);
            this.numericUpDownDaily.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownDaily.Name = "numericUpDownDaily";
            this.numericUpDownDaily.Size = new System.Drawing.Size(49, 20);
            this.numericUpDownDaily.TabIndex = 0;
            this.numericUpDownDaily.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelDailyEvery
            // 
            this.labelDailyEvery.AutoSize = true;
            this.labelDailyEvery.Location = new System.Drawing.Point(20, 20);
            this.labelDailyEvery.Name = "labelDailyEvery";
            this.labelDailyEvery.Size = new System.Drawing.Size(34, 13);
            this.labelDailyEvery.TabIndex = 4;
            this.labelDailyEvery.Text = "Every";
            // 
            // labelDailyDay
            // 
            this.labelDailyDay.AutoSize = true;
            this.labelDailyDay.Location = new System.Drawing.Point(115, 20);
            this.labelDailyDay.Name = "labelDailyDay";
            this.labelDailyDay.Size = new System.Drawing.Size(35, 13);
            this.labelDailyDay.TabIndex = 5;
            this.labelDailyDay.Text = "day(s)";
            // 
            // tabPageWeekly
            // 
            this.tabPageWeekly.Controls.Add(this.labelWeeklyDays);
            this.tabPageWeekly.Controls.Add(this.checkedListBoxWeeklyDays);
            this.tabPageWeekly.Location = new System.Drawing.Point(4, 22);
            this.tabPageWeekly.Name = "tabPageWeekly";
            this.tabPageWeekly.Size = new System.Drawing.Size(458, 235);
            this.tabPageWeekly.TabIndex = 3;
            this.tabPageWeekly.Tag = "3";
            this.tabPageWeekly.Text = "Weekly";
            this.tabPageWeekly.UseVisualStyleBackColor = true;
            // 
            // labelWeeklyDays
            // 
            this.labelWeeklyDays.AutoSize = true;
            this.labelWeeklyDays.Location = new System.Drawing.Point(20, 20);
            this.labelWeeklyDays.Name = "labelWeeklyDays";
            this.labelWeeklyDays.Size = new System.Drawing.Size(34, 13);
            this.labelWeeklyDays.TabIndex = 28;
            this.labelWeeklyDays.Text = "Days:";
            // 
            // checkedListBoxWeeklyDays
            // 
            this.checkedListBoxWeeklyDays.FormattingEnabled = true;
            this.checkedListBoxWeeklyDays.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"});
            this.checkedListBoxWeeklyDays.Location = new System.Drawing.Point(60, 20);
            this.checkedListBoxWeeklyDays.Name = "checkedListBoxWeeklyDays";
            this.checkedListBoxWeeklyDays.Size = new System.Drawing.Size(104, 109);
            this.checkedListBoxWeeklyDays.TabIndex = 0;
            // 
            // tabPageMonthly
            // 
            this.tabPageMonthly.Controls.Add(this.tabControlMonthlyMode);
            this.tabPageMonthly.Controls.Add(this.labelMonthlyMonth);
            this.tabPageMonthly.Controls.Add(this.checkedListBoxMonthlyMonths);
            this.tabPageMonthly.Location = new System.Drawing.Point(4, 22);
            this.tabPageMonthly.Name = "tabPageMonthly";
            this.tabPageMonthly.Size = new System.Drawing.Size(458, 235);
            this.tabPageMonthly.TabIndex = 2;
            this.tabPageMonthly.Text = "Monthly";
            this.tabPageMonthly.UseVisualStyleBackColor = true;
            // 
            // tabControlMonthlyMode
            // 
            this.tabControlMonthlyMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControlMonthlyMode.Controls.Add(this.tabPageMonthlyDayOfMonth);
            this.tabControlMonthlyMode.Controls.Add(this.tabPageMonthlyWeekDay);
            this.tabControlMonthlyMode.Location = new System.Drawing.Point(186, 20);
            this.tabControlMonthlyMode.Name = "tabControlMonthlyMode";
            this.tabControlMonthlyMode.SelectedIndex = 0;
            this.tabControlMonthlyMode.Size = new System.Drawing.Size(251, 195);
            this.tabControlMonthlyMode.TabIndex = 1;
            // 
            // tabPageMonthlyDayOfMonth
            // 
            this.tabPageMonthlyDayOfMonth.Controls.Add(this.checkedListBoxMonthlyDays);
            this.tabPageMonthlyDayOfMonth.Location = new System.Drawing.Point(4, 22);
            this.tabPageMonthlyDayOfMonth.Name = "tabPageMonthlyDayOfMonth";
            this.tabPageMonthlyDayOfMonth.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMonthlyDayOfMonth.Size = new System.Drawing.Size(243, 169);
            this.tabPageMonthlyDayOfMonth.TabIndex = 0;
            this.tabPageMonthlyDayOfMonth.Text = "Day of Month";
            this.tabPageMonthlyDayOfMonth.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxMonthlyDays
            // 
            this.checkedListBoxMonthlyDays.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.checkedListBoxMonthlyDays.FormattingEnabled = true;
            this.checkedListBoxMonthlyDays.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "Last Day"});
            this.checkedListBoxMonthlyDays.Location = new System.Drawing.Point(8, 8);
            this.checkedListBoxMonthlyDays.Name = "checkedListBoxMonthlyDays";
            this.checkedListBoxMonthlyDays.Size = new System.Drawing.Size(229, 154);
            this.checkedListBoxMonthlyDays.TabIndex = 29;
            // 
            // tabPageMonthlyWeekDay
            // 
            this.tabPageMonthlyWeekDay.Controls.Add(this.checkedListBoxMonthlyWeekNumber);
            this.tabPageMonthlyWeekDay.Controls.Add(this.checkedListBoxMonthlyWeekDay);
            this.tabPageMonthlyWeekDay.Location = new System.Drawing.Point(4, 22);
            this.tabPageMonthlyWeekDay.Name = "tabPageMonthlyWeekDay";
            this.tabPageMonthlyWeekDay.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMonthlyWeekDay.Size = new System.Drawing.Size(243, 169);
            this.tabPageMonthlyWeekDay.TabIndex = 1;
            this.tabPageMonthlyWeekDay.Text = "Weekday";
            this.tabPageMonthlyWeekDay.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxMonthlyWeekNumber
            // 
            this.checkedListBoxMonthlyWeekNumber.FormattingEnabled = true;
            this.checkedListBoxMonthlyWeekNumber.Items.AddRange(new object[] {
            "First",
            "Second",
            "Third",
            "Fourth",
            "Last"});
            this.checkedListBoxMonthlyWeekNumber.Location = new System.Drawing.Point(8, 8);
            this.checkedListBoxMonthlyWeekNumber.Name = "checkedListBoxMonthlyWeekNumber";
            this.checkedListBoxMonthlyWeekNumber.Size = new System.Drawing.Size(120, 79);
            this.checkedListBoxMonthlyWeekNumber.TabIndex = 33;
            // 
            // checkedListBoxMonthlyWeekDay
            // 
            this.checkedListBoxMonthlyWeekDay.FormattingEnabled = true;
            this.checkedListBoxMonthlyWeekDay.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"});
            this.checkedListBoxMonthlyWeekDay.Location = new System.Drawing.Point(132, 8);
            this.checkedListBoxMonthlyWeekDay.Name = "checkedListBoxMonthlyWeekDay";
            this.checkedListBoxMonthlyWeekDay.Size = new System.Drawing.Size(104, 109);
            this.checkedListBoxMonthlyWeekDay.TabIndex = 34;
            // 
            // labelMonthlyMonth
            // 
            this.labelMonthlyMonth.AutoSize = true;
            this.labelMonthlyMonth.Location = new System.Drawing.Point(20, 20);
            this.labelMonthlyMonth.Name = "labelMonthlyMonth";
            this.labelMonthlyMonth.Size = new System.Drawing.Size(40, 13);
            this.labelMonthlyMonth.TabIndex = 29;
            this.labelMonthlyMonth.Text = "Month:";
            // 
            // checkedListBoxMonthlyMonths
            // 
            this.checkedListBoxMonthlyMonths.FormattingEnabled = true;
            this.checkedListBoxMonthlyMonths.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.checkedListBoxMonthlyMonths.Location = new System.Drawing.Point(60, 20);
            this.checkedListBoxMonthlyMonths.Name = "checkedListBoxMonthlyMonths";
            this.checkedListBoxMonthlyMonths.Size = new System.Drawing.Size(120, 184);
            this.checkedListBoxMonthlyMonths.TabIndex = 0;
            // 
            // tpViewScheduler
            // 
            this.tpViewScheduler.Controls.Add(this.button2);
            this.tpViewScheduler.Controls.Add(this.button1);
            this.tpViewScheduler.Location = new System.Drawing.Point(4, 22);
            this.tpViewScheduler.Name = "tpViewScheduler";
            this.tpViewScheduler.Padding = new System.Windows.Forms.Padding(3);
            this.tpViewScheduler.Size = new System.Drawing.Size(478, 629);
            this.tpViewScheduler.TabIndex = 1;
            this.tpViewScheduler.Text = "View";
            this.tpViewScheduler.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(144, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(202, 303);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 672);
            this.Controls.Add(this.tcScheduler);
            this.Name = "MainForm";
            this.Text = "Scheduler";
            this.tcScheduler.ResumeLayout(false);
            this.tpAddScheduler.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControlMode.ResumeLayout(false);
            this.tabPageOneTimeOnly.ResumeLayout(false);
            this.tabPageOneTimeOnly.PerformLayout();
            this.tabPageDaily.ResumeLayout(false);
            this.tabPageDaily.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDaily)).EndInit();
            this.tabPageWeekly.ResumeLayout(false);
            this.tabPageWeekly.PerformLayout();
            this.tabPageMonthly.ResumeLayout(false);
            this.tabPageMonthly.PerformLayout();
            this.tabControlMonthlyMode.ResumeLayout(false);
            this.tabPageMonthlyDayOfMonth.ResumeLayout(false);
            this.tabPageMonthlyWeekDay.ResumeLayout(false);
            this.tpViewScheduler.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tcScheduler;
        private System.Windows.Forms.TabPage tpAddScheduler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ddlRecurrence;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTriggerDescription;
        private System.Windows.Forms.ComboBox ddlPartnerType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTriggerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dpExecutionTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtEndDate;
        private System.Windows.Forms.Label labelOneTimeOnlyTag;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.TabPage tpViewScheduler;
        private System.Windows.Forms.TabControl tabControlMode;
        private System.Windows.Forms.TabPage tabPageOneTimeOnly;
        private System.Windows.Forms.Label labelOneTimeOnlyDay;
        private System.Windows.Forms.DateTimePicker dateTimePickerOneTimeOnlyDay;
        private System.Windows.Forms.TabPage tabPageDaily;
        private System.Windows.Forms.NumericUpDown numericUpDownDaily;
        private System.Windows.Forms.Label labelDailyEvery;
        private System.Windows.Forms.Label labelDailyDay;
        private System.Windows.Forms.TabPage tabPageWeekly;
        private System.Windows.Forms.Label labelWeeklyDays;
        private System.Windows.Forms.CheckedListBox checkedListBoxWeeklyDays;
        private System.Windows.Forms.TabPage tabPageMonthly;
        private System.Windows.Forms.TabControl tabControlMonthlyMode;
        private System.Windows.Forms.TabPage tabPageMonthlyDayOfMonth;
        private System.Windows.Forms.CheckedListBox checkedListBoxMonthlyDays;
        private System.Windows.Forms.TabPage tabPageMonthlyWeekDay;
        private System.Windows.Forms.CheckedListBox checkedListBoxMonthlyWeekNumber;
        private System.Windows.Forms.CheckedListBox checkedListBoxMonthlyWeekDay;
        private System.Windows.Forms.Label labelMonthlyMonth;
        private System.Windows.Forms.CheckedListBox checkedListBoxMonthlyMonths;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.ListBox lbHours;
        private System.Windows.Forms.Button btnAddHour;
        private System.Windows.Forms.Button btnAddScheduler;
        private System.Windows.Forms.Button button2;
    }
}

