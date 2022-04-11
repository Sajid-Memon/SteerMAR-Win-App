
namespace SteerMAR.Views.popupForms
{
    partial class frmAddPatientMedication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddPatientMedication));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtMedStrength = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.drpMedForm = new System.Windows.Forms.ComboBox();
            this.pnlRoutine = new System.Windows.Forms.Panel();
            this.dgvTimeList = new System.Windows.Forms.DataGridView();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Details = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Week = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnAddNewTime = new SteerMAR.CustomControlls.RoundedButton();
            this.CBWeekDays = new System.Windows.Forms.CheckedListBox();
            this.drpDetails = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.drpQuantity = new System.Windows.Forms.ComboBox();
            this.dtTime = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnSave = new SteerMAR.CustomControlls.RoundedButton();
            this.pnlPNR = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMaxTab = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMinTab = new System.Windows.Forms.TextBox();
            this.chkPNR = new System.Windows.Forms.CheckBox();
            this.chkHomeHealthDrug = new System.Windows.Forms.CheckBox();
            this.chkControlledDrug = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtInstruction = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.drpRoute = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpExpirydate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpwrittendate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.drpPrescriber = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtrxno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdiagnosis = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtndcno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEquilentto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnCloseThis = new System.Windows.Forms.Button();
            this.label50 = new System.Windows.Forms.Label();
            this.pbPatientProfile = new System.Windows.Forms.PictureBox();
            this.btnChooseImage = new SteerMAR.CustomControlls.RoundedButton();
            this.fpImage = new System.Windows.Forms.OpenFileDialog();
            this.btnCancel = new SteerMAR.CustomControlls.RoundedButton();
            this.panel1.SuspendLayout();
            this.pnlRoutine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimeList)).BeginInit();
            this.pnlPNR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPatientProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.txtMedStrength);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.drpMedForm);
            this.panel1.Controls.Add(this.pnlRoutine);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.pnlPNR);
            this.panel1.Controls.Add(this.chkPNR);
            this.panel1.Controls.Add(this.chkHomeHealthDrug);
            this.panel1.Controls.Add(this.chkControlledDrug);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtInstruction);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.drpRoute);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.dtpExpirydate);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dtpwrittendate);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.drpPrescriber);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtrxno);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtdiagnosis);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtndcno);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtEquilentto);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.btnCloseThis);
            this.panel1.Controls.Add(this.label50);
            this.panel1.Controls.Add(this.pbPatientProfile);
            this.panel1.Controls.Add(this.btnChooseImage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 610);
            this.panel1.TabIndex = 43;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Hero", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label18.Location = new System.Drawing.Point(8, 42);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 18);
            this.label18.TabIndex = 104;
            this.label18.Text = "Image";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Hero", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label17.Location = new System.Drawing.Point(568, 42);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(81, 18);
            this.label17.TabIndex = 103;
            this.label17.Text = "Strength";
            // 
            // txtMedStrength
            // 
            this.txtMedStrength.Font = new System.Drawing.Font("Hero", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedStrength.Location = new System.Drawing.Point(571, 62);
            this.txtMedStrength.Name = "txtMedStrength";
            this.txtMedStrength.Size = new System.Drawing.Size(109, 27);
            this.txtMedStrength.TabIndex = 102;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Hero", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label16.Location = new System.Drawing.Point(125, 91);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 18);
            this.label16.TabIndex = 101;
            this.label16.Text = "Form";
            // 
            // drpMedForm
            // 
            this.drpMedForm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.drpMedForm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.drpMedForm.Font = new System.Drawing.Font("Hero", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpMedForm.FormattingEnabled = true;
            this.drpMedForm.Items.AddRange(new object[] {
            "Solid",
            "Liquid",
            "Powder"});
            this.drpMedForm.Location = new System.Drawing.Point(128, 112);
            this.drpMedForm.Name = "drpMedForm";
            this.drpMedForm.Size = new System.Drawing.Size(122, 27);
            this.drpMedForm.TabIndex = 100;
            // 
            // pnlRoutine
            // 
            this.pnlRoutine.Controls.Add(this.dgvTimeList);
            this.pnlRoutine.Controls.Add(this.btnAddNewTime);
            this.pnlRoutine.Controls.Add(this.CBWeekDays);
            this.pnlRoutine.Controls.Add(this.drpDetails);
            this.pnlRoutine.Controls.Add(this.label15);
            this.pnlRoutine.Controls.Add(this.drpQuantity);
            this.pnlRoutine.Controls.Add(this.dtTime);
            this.pnlRoutine.Controls.Add(this.label13);
            this.pnlRoutine.Controls.Add(this.label14);
            this.pnlRoutine.Location = new System.Drawing.Point(11, 367);
            this.pnlRoutine.Name = "pnlRoutine";
            this.pnlRoutine.Size = new System.Drawing.Size(669, 187);
            this.pnlRoutine.TabIndex = 99;
            // 
            // dgvTimeList
            // 
            this.dgvTimeList.AllowUserToAddRows = false;
            this.dgvTimeList.AllowUserToDeleteRows = false;
            this.dgvTimeList.AllowUserToResizeColumns = false;
            this.dgvTimeList.AllowUserToResizeRows = false;
            this.dgvTimeList.BackgroundColor = System.Drawing.Color.White;
            this.dgvTimeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.Qty,
            this.Details,
            this.Week,
            this.Delete});
            this.dgvTimeList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTimeList.Location = new System.Drawing.Point(0, 68);
            this.dgvTimeList.Name = "dgvTimeList";
            this.dgvTimeList.RowHeadersVisible = false;
            this.dgvTimeList.Size = new System.Drawing.Size(669, 119);
            this.dgvTimeList.TabIndex = 106;
            this.dgvTimeList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTimeList_CellClick);
            // 
            // Time
            // 
            this.Time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.Width = 65;
            // 
            // Qty
            // 
            this.Qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            this.Qty.Width = 54;
            // 
            // Details
            // 
            this.Details.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Details.HeaderText = "Details";
            this.Details.Name = "Details";
            this.Details.Width = 75;
            // 
            // Week
            // 
            this.Week.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Week.HeaderText = "Week Days";
            this.Week.Name = "Week";
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Delete.HeaderText = "Delete";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.Name = "Delete";
            this.Delete.Width = 54;
            // 
            // btnAddNewTime
            // 
            this.btnAddNewTime.BackColor = System.Drawing.Color.White;
            this.btnAddNewTime.BorderRadius = 3;
            this.btnAddNewTime.FlatAppearance.BorderSize = 0;
            this.btnAddNewTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewTime.Font = new System.Drawing.Font("Hero Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddNewTime.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewTime.Image")));
            this.btnAddNewTime.Location = new System.Drawing.Point(626, 14);
            this.btnAddNewTime.Name = "btnAddNewTime";
            this.btnAddNewTime.Size = new System.Drawing.Size(40, 40);
            this.btnAddNewTime.TabIndex = 105;
            this.btnAddNewTime.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddNewTime.UseVisualStyleBackColor = false;
            this.btnAddNewTime.Click += new System.EventHandler(this.btnAddNewTime_Click);
            // 
            // CBWeekDays
            // 
            this.CBWeekDays.CheckOnClick = true;
            this.CBWeekDays.ColumnWidth = 80;
            this.CBWeekDays.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBWeekDays.FormattingEnabled = true;
            this.CBWeekDays.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"});
            this.CBWeekDays.Location = new System.Drawing.Point(323, 5);
            this.CBWeekDays.MultiColumn = true;
            this.CBWeekDays.Name = "CBWeekDays";
            this.CBWeekDays.Size = new System.Drawing.Size(297, 58);
            this.CBWeekDays.TabIndex = 94;
            this.CBWeekDays.ThreeDCheckBoxes = true;
            this.CBWeekDays.UseCompatibleTextRendering = true;
            // 
            // drpDetails
            // 
            this.drpDetails.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.drpDetails.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.drpDetails.Font = new System.Drawing.Font("Hero", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpDetails.FormattingEnabled = true;
            this.drpDetails.Items.AddRange(new object[] {
            "Daily",
            "Days of Week",
            "Every N Day",
            "Days of Month",
            "One Time",
            "Advanced"});
            this.drpDetails.Location = new System.Drawing.Point(202, 27);
            this.drpDetails.Name = "drpDetails";
            this.drpDetails.Size = new System.Drawing.Size(115, 23);
            this.drpDetails.TabIndex = 93;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Hero", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label15.Location = new System.Drawing.Point(197, 6);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 18);
            this.label15.TabIndex = 92;
            this.label15.Text = "Details";
            // 
            // drpQuantity
            // 
            this.drpQuantity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.drpQuantity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.drpQuantity.Font = new System.Drawing.Font("Hero", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpQuantity.FormattingEnabled = true;
            this.drpQuantity.Items.AddRange(new object[] {
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
            "12"});
            this.drpQuantity.Location = new System.Drawing.Point(118, 27);
            this.drpQuantity.Name = "drpQuantity";
            this.drpQuantity.Size = new System.Drawing.Size(78, 23);
            this.drpQuantity.TabIndex = 91;
            // 
            // dtTime
            // 
            this.dtTime.CalendarFont = new System.Drawing.Font("Hero", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTime.CustomFormat = "27/01/2022";
            this.dtTime.Font = new System.Drawing.Font("Hero", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtTime.Location = new System.Drawing.Point(4, 27);
            this.dtTime.Name = "dtTime";
            this.dtTime.ShowUpDown = true;
            this.dtTime.Size = new System.Drawing.Size(108, 23);
            this.dtTime.TabIndex = 89;
            this.dtTime.Value = new System.DateTime(2022, 3, 15, 18, 14, 0, 0);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Hero", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label13.Location = new System.Drawing.Point(117, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 18);
            this.label13.TabIndex = 87;
            this.label13.Text = "Quantity";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Hero", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label14.Location = new System.Drawing.Point(1, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 18);
            this.label14.TabIndex = 85;
            this.label14.Text = "Time";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(141)))), ((int)(((byte)(238)))));
            this.btnSave.BorderRadius = 3;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Hero Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(523, 560);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(157, 39);
            this.btnSave.TabIndex = 98;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlPNR
            // 
            this.pnlPNR.Controls.Add(this.label12);
            this.pnlPNR.Controls.Add(this.txtMaxTab);
            this.pnlPNR.Controls.Add(this.label11);
            this.pnlPNR.Controls.Add(this.txtMinTab);
            this.pnlPNR.Location = new System.Drawing.Point(11, 367);
            this.pnlPNR.Name = "pnlPNR";
            this.pnlPNR.Size = new System.Drawing.Size(251, 88);
            this.pnlPNR.TabIndex = 97;
            this.pnlPNR.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Hero", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label12.Location = new System.Drawing.Point(125, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 18);
            this.label12.TabIndex = 87;
            this.label12.Text = "Max Tab";
            // 
            // txtMaxTab
            // 
            this.txtMaxTab.Font = new System.Drawing.Font("Hero", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxTab.Location = new System.Drawing.Point(128, 35);
            this.txtMaxTab.Name = "txtMaxTab";
            this.txtMaxTab.Size = new System.Drawing.Size(110, 27);
            this.txtMaxTab.TabIndex = 86;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Hero", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label11.Location = new System.Drawing.Point(9, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 18);
            this.label11.TabIndex = 85;
            this.label11.Text = "Min Tab";
            // 
            // txtMinTab
            // 
            this.txtMinTab.Font = new System.Drawing.Font("Hero", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinTab.Location = new System.Drawing.Point(12, 35);
            this.txtMinTab.Name = "txtMinTab";
            this.txtMinTab.Size = new System.Drawing.Size(110, 27);
            this.txtMinTab.TabIndex = 84;
            // 
            // chkPNR
            // 
            this.chkPNR.AutoSize = true;
            this.chkPNR.Font = new System.Drawing.Font("Hero", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPNR.Location = new System.Drawing.Point(622, 336);
            this.chkPNR.Name = "chkPNR";
            this.chkPNR.Size = new System.Drawing.Size(55, 19);
            this.chkPNR.TabIndex = 96;
            this.chkPNR.Text = "PNR";
            this.chkPNR.UseVisualStyleBackColor = true;
            this.chkPNR.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // chkHomeHealthDrug
            // 
            this.chkHomeHealthDrug.Font = new System.Drawing.Font("Hero", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHomeHealthDrug.Location = new System.Drawing.Point(489, 328);
            this.chkHomeHealthDrug.Name = "chkHomeHealthDrug";
            this.chkHomeHealthDrug.Size = new System.Drawing.Size(121, 35);
            this.chkHomeHealthDrug.TabIndex = 95;
            this.chkHomeHealthDrug.Text = "Home Health Drug";
            this.chkHomeHealthDrug.UseVisualStyleBackColor = true;
            // 
            // chkControlledDrug
            // 
            this.chkControlledDrug.Font = new System.Drawing.Font("Hero", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkControlledDrug.Location = new System.Drawing.Point(383, 322);
            this.chkControlledDrug.Name = "chkControlledDrug";
            this.chkControlledDrug.Size = new System.Drawing.Size(117, 46);
            this.chkControlledDrug.TabIndex = 94;
            this.chkControlledDrug.Text = "Controlled Drug";
            this.chkControlledDrug.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Hero", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label10.Location = new System.Drawing.Point(336, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 18);
            this.label10.TabIndex = 93;
            this.label10.Text = "Instructions";
            // 
            // txtInstruction
            // 
            this.txtInstruction.Font = new System.Drawing.Font("Hero", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInstruction.Location = new System.Drawing.Point(339, 223);
            this.txtInstruction.Multiline = true;
            this.txtInstruction.Name = "txtInstruction";
            this.txtInstruction.Size = new System.Drawing.Size(341, 78);
            this.txtInstruction.TabIndex = 92;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Hero", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label9.Location = new System.Drawing.Point(233, 310);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 18);
            this.label9.TabIndex = 91;
            this.label9.Text = "Route Type";
            // 
            // drpRoute
            // 
            this.drpRoute.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.drpRoute.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.drpRoute.Font = new System.Drawing.Font("Hero", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpRoute.FormattingEnabled = true;
            this.drpRoute.Items.AddRange(new object[] {
            "ORAL",
            "G-Tube",
            "J-Tube",
            "FEEDING TUBE",
            "RECTAL",
            "INTRAMUSCULAR",
            "IRRIGATION",
            "NASAL",
            "OPHTHALMIC",
            "AURICULAR",
            "RESPIRATORY",
            "SUBCUTANEOS",
            "SUBLINGUAL",
            "TOPICAL",
            "TRANSDERMAL",
            "VAGINAL",
            "OTHER",
            "ANY OTHER"});
            this.drpRoute.Location = new System.Drawing.Point(236, 331);
            this.drpRoute.Name = "drpRoute";
            this.drpRoute.Size = new System.Drawing.Size(141, 23);
            this.drpRoute.TabIndex = 90;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Hero", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label8.Location = new System.Drawing.Point(120, 308);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 18);
            this.label8.TabIndex = 89;
            this.label8.Text = "Expiry Date";
            // 
            // dtpExpirydate
            // 
            this.dtpExpirydate.CalendarFont = new System.Drawing.Font("Hero", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpExpirydate.CustomFormat = "27/01/2022";
            this.dtpExpirydate.Font = new System.Drawing.Font("Hero", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpExpirydate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpirydate.Location = new System.Drawing.Point(121, 331);
            this.dtpExpirydate.Name = "dtpExpirydate";
            this.dtpExpirydate.Size = new System.Drawing.Size(109, 23);
            this.dtpExpirydate.TabIndex = 88;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Hero", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label7.Location = new System.Drawing.Point(8, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 18);
            this.label7.TabIndex = 87;
            this.label7.Text = "Written Date";
            // 
            // dtpwrittendate
            // 
            this.dtpwrittendate.CalendarFont = new System.Drawing.Font("Hero", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpwrittendate.CustomFormat = "27/01/2022";
            this.dtpwrittendate.Font = new System.Drawing.Font("Hero", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpwrittendate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpwrittendate.Location = new System.Drawing.Point(11, 331);
            this.dtpwrittendate.Name = "dtpwrittendate";
            this.dtpwrittendate.Size = new System.Drawing.Size(104, 23);
            this.dtpwrittendate.TabIndex = 86;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Hero", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label6.Location = new System.Drawing.Point(410, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 18);
            this.label6.TabIndex = 85;
            this.label6.Text = "Prescribed By";
            // 
            // drpPrescriber
            // 
            this.drpPrescriber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.drpPrescriber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.drpPrescriber.Font = new System.Drawing.Font("Hero", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpPrescriber.FormattingEnabled = true;
            this.drpPrescriber.Items.AddRange(new object[] {
            "Father",
            "Mother",
            "Brother",
            "Sister",
            "Wife",
            "Husband",
            "Son",
            "Daughter",
            ""});
            this.drpPrescriber.Location = new System.Drawing.Point(413, 162);
            this.drpPrescriber.Name = "drpPrescriber";
            this.drpPrescriber.Size = new System.Drawing.Size(267, 27);
            this.drpPrescriber.TabIndex = 84;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Hero", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label5.Location = new System.Drawing.Point(270, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 18);
            this.label5.TabIndex = 83;
            this.label5.Text = "RX No";
            // 
            // txtrxno
            // 
            this.txtrxno.Font = new System.Drawing.Font("Hero", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrxno.Location = new System.Drawing.Point(273, 162);
            this.txtrxno.Name = "txtrxno";
            this.txtrxno.Size = new System.Drawing.Size(134, 27);
            this.txtrxno.TabIndex = 82;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Hero", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label4.Location = new System.Drawing.Point(8, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 18);
            this.label4.TabIndex = 81;
            this.label4.Text = "Diagnosis";
            // 
            // txtdiagnosis
            // 
            this.txtdiagnosis.Font = new System.Drawing.Font("Hero", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiagnosis.Location = new System.Drawing.Point(11, 223);
            this.txtdiagnosis.Multiline = true;
            this.txtdiagnosis.Name = "txtdiagnosis";
            this.txtdiagnosis.Size = new System.Drawing.Size(322, 78);
            this.txtdiagnosis.TabIndex = 80;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Hero", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label3.Location = new System.Drawing.Point(125, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 18);
            this.label3.TabIndex = 79;
            this.label3.Text = "NDC No";
            // 
            // txtndcno
            // 
            this.txtndcno.Font = new System.Drawing.Font("Hero", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtndcno.Location = new System.Drawing.Point(128, 162);
            this.txtndcno.Name = "txtndcno";
            this.txtndcno.Size = new System.Drawing.Size(139, 27);
            this.txtndcno.TabIndex = 78;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Hero", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label2.Location = new System.Drawing.Point(253, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 18);
            this.label2.TabIndex = 77;
            this.label2.Text = "Equivalent To";
            // 
            // txtEquilentto
            // 
            this.txtEquilentto.Font = new System.Drawing.Font("Hero", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEquilentto.Location = new System.Drawing.Point(256, 112);
            this.txtEquilentto.Name = "txtEquilentto";
            this.txtEquilentto.Size = new System.Drawing.Size(424, 27);
            this.txtEquilentto.TabIndex = 76;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Hero", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label1.Location = new System.Drawing.Point(125, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 75;
            this.label1.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Hero", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(128, 62);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(437, 27);
            this.txtName.TabIndex = 74;
            // 
            // btnCloseThis
            // 
            this.btnCloseThis.FlatAppearance.BorderSize = 0;
            this.btnCloseThis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseThis.Font = new System.Drawing.Font("Hero", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseThis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnCloseThis.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseThis.Image")));
            this.btnCloseThis.Location = new System.Drawing.Point(658, 3);
            this.btnCloseThis.Name = "btnCloseThis";
            this.btnCloseThis.Size = new System.Drawing.Size(22, 26);
            this.btnCloseThis.TabIndex = 70;
            this.btnCloseThis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCloseThis.UseVisualStyleBackColor = true;
            this.btnCloseThis.Click += new System.EventHandler(this.btnCloseThis_Click);
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Hero", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label50.Location = new System.Drawing.Point(8, 8);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(190, 18);
            this.label50.TabIndex = 71;
            this.label50.Text = "Add or Edit Medication";
            // 
            // pbPatientProfile
            // 
            this.pbPatientProfile.Image = ((System.Drawing.Image)(resources.GetObject("pbPatientProfile.Image")));
            this.pbPatientProfile.Location = new System.Drawing.Point(11, 62);
            this.pbPatientProfile.Name = "pbPatientProfile";
            this.pbPatientProfile.Size = new System.Drawing.Size(108, 97);
            this.pbPatientProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPatientProfile.TabIndex = 41;
            this.pbPatientProfile.TabStop = false;
            // 
            // btnChooseImage
            // 
            this.btnChooseImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(141)))), ((int)(((byte)(238)))));
            this.btnChooseImage.BorderRadius = 0;
            this.btnChooseImage.FlatAppearance.BorderSize = 0;
            this.btnChooseImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseImage.Font = new System.Drawing.Font("Hero", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseImage.ForeColor = System.Drawing.Color.White;
            this.btnChooseImage.Location = new System.Drawing.Point(11, 165);
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.Size = new System.Drawing.Size(108, 24);
            this.btnChooseImage.TabIndex = 42;
            this.btnChooseImage.Text = "choose";
            this.btnChooseImage.UseVisualStyleBackColor = false;
            this.btnChooseImage.Click += new System.EventHandler(this.btnChooseImage_Click);
            // 
            // fpImage
            // 
            this.fpImage.FileName = "openFileDialog1";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancel.BorderRadius = 3;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Hero Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(360, 560);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(157, 39);
            this.btnCancel.TabIndex = 105;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // frmAddPatientMedication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(690, 610);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Hero", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmAddPatientMedication";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAddPatientMedication";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlRoutine.ResumeLayout(false);
            this.pnlRoutine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimeList)).EndInit();
            this.pnlPNR.ResumeLayout(false);
            this.pnlPNR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPatientProfile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbPatientProfile;
        private CustomControlls.RoundedButton btnChooseImage;
        private System.Windows.Forms.Button btnCloseThis;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtrxno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdiagnosis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtndcno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEquilentto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox drpPrescriber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpwrittendate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtInstruction;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox drpRoute;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpExpirydate;
        private System.Windows.Forms.CheckBox chkControlledDrug;
        private System.Windows.Forms.CheckBox chkHomeHealthDrug;
        private System.Windows.Forms.CheckBox chkPNR;
        private System.Windows.Forms.Panel pnlPNR;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMaxTab;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMinTab;
        private CustomControlls.RoundedButton btnSave;
        private System.Windows.Forms.Panel pnlRoutine;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtTime;
        private System.Windows.Forms.ComboBox drpQuantity;
        private System.Windows.Forms.ComboBox drpDetails;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckedListBox CBWeekDays;
        private System.Windows.Forms.OpenFileDialog fpImage;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtMedStrength;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox drpMedForm;
        private System.Windows.Forms.Label label18;
        private CustomControlls.RoundedButton btnAddNewTime;
        private System.Windows.Forms.DataGridView dgvTimeList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Details;
        private System.Windows.Forms.DataGridViewTextBoxColumn Week;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private CustomControlls.RoundedButton btnCancel;
    }
}