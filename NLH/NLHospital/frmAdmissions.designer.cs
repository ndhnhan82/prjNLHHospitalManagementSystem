namespace NLHospital
{
    partial class frmAdmissions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmissions));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbAdmissionID = new System.Windows.Forms.TextBox();
            this.MtxbPatientID = new System.Windows.Forms.MaskedTextBox();
            this.groupbxAdmissiondata = new System.Windows.Forms.GroupBox();
            this.dtpDischargedDate = new System.Windows.Forms.DateTimePicker();
            this.dtpAdmissionDate = new System.Windows.Forms.DateTimePicker();
            this.dtpSurgeryDate = new System.Windows.Forms.DateTimePicker();
            this.rdbt_Not = new System.Windows.Forms.RadioButton();
            this.rdrbt_yes = new System.Windows.Forms.RadioButton();
            this.txbPatientNextOfKin = new System.Windows.Forms.TextBox();
            this.txbPatientName = new System.Windows.Forms.TextBox();
            this.txbStayLength = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btNewAdmission = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.groupbxAccomodation = new System.Windows.Forms.GroupBox();
            this.btfindbed = new System.Windows.Forms.Button();
            this.txbBedNumbers = new System.Windows.Forms.TextBox();
            this.cbbxBedType = new System.Windows.Forms.ComboBox();
            this.txbDocSpecialTy = new System.Windows.Forms.TextBox();
            this.txbDoctorID = new System.Windows.Forms.TextBox();
            this.txbDoctorName = new System.Windows.Forms.TextBox();
            this.cbbxWardName = new System.Windows.Forms.ComboBox();
            this.cbxPhone = new System.Windows.Forms.CheckBox();
            this.cbxTV = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.btLoadAdmission = new System.Windows.Forms.Button();
            this.groupbxAdmissiondata.SuspendLayout();
            this.groupbxAccomodation.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Admission ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Patient ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(323, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "Surgery Schedule:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(323, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 24);
            this.label5.TabIndex = 18;
            this.label5.Text = "Discharged Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(323, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "Admission Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(323, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "Surgery Date:";
            // 
            // txbAdmissionID
            // 
            this.txbAdmissionID.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txbAdmissionID.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAdmissionID.Location = new System.Drawing.Point(147, 36);
            this.txbAdmissionID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbAdmissionID.Name = "txbAdmissionID";
            this.txbAdmissionID.ReadOnly = true;
            this.txbAdmissionID.Size = new System.Drawing.Size(160, 32);
            this.txbAdmissionID.TabIndex = 11;
            this.txbAdmissionID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbAdmissionID.Leave += new System.EventHandler(this.txbAdmissionID_Leave);
            // 
            // MtxbPatientID
            // 
            this.MtxbPatientID.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtxbPatientID.Location = new System.Drawing.Point(147, 87);
            this.MtxbPatientID.Margin = new System.Windows.Forms.Padding(2);
            this.MtxbPatientID.Mask = "0000-0000-0000";
            this.MtxbPatientID.Name = "MtxbPatientID";
            this.MtxbPatientID.Size = new System.Drawing.Size(160, 32);
            this.MtxbPatientID.TabIndex = 0;
            this.MtxbPatientID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MtxbPatientID.Click += new System.EventHandler(this.MtxbPatientID_Click);
            // 
            // groupbxAdmissiondata
            // 
            this.groupbxAdmissiondata.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupbxAdmissiondata.Controls.Add(this.dtpDischargedDate);
            this.groupbxAdmissiondata.Controls.Add(this.dtpAdmissionDate);
            this.groupbxAdmissiondata.Controls.Add(this.dtpSurgeryDate);
            this.groupbxAdmissiondata.Controls.Add(this.rdbt_Not);
            this.groupbxAdmissiondata.Controls.Add(this.rdrbt_yes);
            this.groupbxAdmissiondata.Controls.Add(this.txbPatientNextOfKin);
            this.groupbxAdmissiondata.Controls.Add(this.txbPatientName);
            this.groupbxAdmissiondata.Controls.Add(this.txbStayLength);
            this.groupbxAdmissiondata.Controls.Add(this.MtxbPatientID);
            this.groupbxAdmissiondata.Controls.Add(this.txbAdmissionID);
            this.groupbxAdmissiondata.Controls.Add(this.label11);
            this.groupbxAdmissiondata.Controls.Add(this.label10);
            this.groupbxAdmissiondata.Controls.Add(this.label2);
            this.groupbxAdmissiondata.Controls.Add(this.label5);
            this.groupbxAdmissiondata.Controls.Add(this.label8);
            this.groupbxAdmissiondata.Controls.Add(this.label6);
            this.groupbxAdmissiondata.Controls.Add(this.label4);
            this.groupbxAdmissiondata.Controls.Add(this.label7);
            this.groupbxAdmissiondata.Controls.Add(this.label1);
            this.groupbxAdmissiondata.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupbxAdmissiondata.Location = new System.Drawing.Point(10, 50);
            this.groupbxAdmissiondata.Margin = new System.Windows.Forms.Padding(2);
            this.groupbxAdmissiondata.Name = "groupbxAdmissiondata";
            this.groupbxAdmissiondata.Padding = new System.Windows.Forms.Padding(2);
            this.groupbxAdmissiondata.Size = new System.Drawing.Size(666, 245);
            this.groupbxAdmissiondata.TabIndex = 0;
            this.groupbxAdmissiondata.TabStop = false;
            this.groupbxAdmissiondata.Text = "Admission";
            // 
            // dtpDischargedDate
            // 
            this.dtpDischargedDate.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDischargedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDischargedDate.Location = new System.Drawing.Point(503, 188);
            this.dtpDischargedDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDischargedDate.Name = "dtpDischargedDate";
            this.dtpDischargedDate.Size = new System.Drawing.Size(138, 32);
            this.dtpDischargedDate.TabIndex = 6;
            this.dtpDischargedDate.ValueChanged += new System.EventHandler(this.dtpDischargedDate_ValueChanged);
            // 
            // dtpAdmissionDate
            // 
            this.dtpAdmissionDate.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.dtpAdmissionDate.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAdmissionDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAdmissionDate.Location = new System.Drawing.Point(503, 36);
            this.dtpAdmissionDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpAdmissionDate.Name = "dtpAdmissionDate";
            this.dtpAdmissionDate.Size = new System.Drawing.Size(138, 32);
            this.dtpAdmissionDate.TabIndex = 1;
            // 
            // dtpSurgeryDate
            // 
            this.dtpSurgeryDate.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption;
            this.dtpSurgeryDate.Checked = false;
            this.dtpSurgeryDate.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSurgeryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSurgeryDate.Location = new System.Drawing.Point(504, 110);
            this.dtpSurgeryDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpSurgeryDate.Name = "dtpSurgeryDate";
            this.dtpSurgeryDate.Size = new System.Drawing.Size(138, 32);
            this.dtpSurgeryDate.TabIndex = 4;
            this.dtpSurgeryDate.ValueChanged += new System.EventHandler(this.dtpSurgeryDate_ValueChanged);
            // 
            // rdbt_Not
            // 
            this.rdbt_Not.AutoSize = true;
            this.rdbt_Not.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbt_Not.Location = new System.Drawing.Point(578, 75);
            this.rdbt_Not.Margin = new System.Windows.Forms.Padding(2);
            this.rdbt_Not.Name = "rdbt_Not";
            this.rdbt_Not.Size = new System.Drawing.Size(48, 28);
            this.rdbt_Not.TabIndex = 3;
            this.rdbt_Not.TabStop = true;
            this.rdbt_Not.Text = "N";
            this.rdbt_Not.UseVisualStyleBackColor = true;
            // 
            // rdrbt_yes
            // 
            this.rdrbt_yes.AutoSize = true;
            this.rdrbt_yes.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdrbt_yes.Location = new System.Drawing.Point(519, 75);
            this.rdrbt_yes.Margin = new System.Windows.Forms.Padding(2);
            this.rdrbt_yes.Name = "rdrbt_yes";
            this.rdrbt_yes.Size = new System.Drawing.Size(46, 28);
            this.rdrbt_yes.TabIndex = 2;
            this.rdrbt_yes.TabStop = true;
            this.rdrbt_yes.Text = "Y";
            this.rdrbt_yes.UseVisualStyleBackColor = true;
            // 
            // txbPatientNextOfKin
            // 
            this.txbPatientNextOfKin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txbPatientNextOfKin.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPatientNextOfKin.Location = new System.Drawing.Point(147, 189);
            this.txbPatientNextOfKin.Margin = new System.Windows.Forms.Padding(2);
            this.txbPatientNextOfKin.Name = "txbPatientNextOfKin";
            this.txbPatientNextOfKin.Size = new System.Drawing.Size(160, 32);
            this.txbPatientNextOfKin.TabIndex = 13;
            this.txbPatientNextOfKin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbPatientName
            // 
            this.txbPatientName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txbPatientName.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPatientName.Location = new System.Drawing.Point(147, 138);
            this.txbPatientName.Margin = new System.Windows.Forms.Padding(2);
            this.txbPatientName.Name = "txbPatientName";
            this.txbPatientName.Size = new System.Drawing.Size(160, 32);
            this.txbPatientName.TabIndex = 12;
            this.txbPatientName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbStayLength
            // 
            this.txbStayLength.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txbStayLength.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbStayLength.Location = new System.Drawing.Point(504, 149);
            this.txbStayLength.Margin = new System.Windows.Forms.Padding(2);
            this.txbStayLength.Name = "txbStayLength";
            this.txbStayLength.ReadOnly = true;
            this.txbStayLength.Size = new System.Drawing.Size(138, 32);
            this.txbStayLength.TabIndex = 5;
            this.txbStayLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 193);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 24);
            this.label11.TabIndex = 10;
            this.label11.Text = "NextOfKin:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 24);
            this.label10.TabIndex = 9;
            this.label10.Text = "Patient Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(323, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 24);
            this.label8.TabIndex = 17;
            this.label8.Text = "Stay Length:";
            // 
            // btNewAdmission
            // 
            this.btNewAdmission.BackColor = System.Drawing.Color.White;
            this.btNewAdmission.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNewAdmission.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btNewAdmission.Location = new System.Drawing.Point(51, 559);
            this.btNewAdmission.Margin = new System.Windows.Forms.Padding(2);
            this.btNewAdmission.Name = "btNewAdmission";
            this.btNewAdmission.Size = new System.Drawing.Size(180, 46);
            this.btNewAdmission.TabIndex = 4;
            this.btNewAdmission.Text = "New Admission";
            this.btNewAdmission.UseVisualStyleBackColor = false;
            this.btNewAdmission.Click += new System.EventHandler(this.btNewAdmission_Click);
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.White;
            this.btExit.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btExit.Location = new System.Drawing.Point(536, 559);
            this.btExit.Margin = new System.Windows.Forms.Padding(2);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(72, 46);
            this.btExit.TabIndex = 3;
            this.btExit.Text = "Quit";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // groupbxAccomodation
            // 
            this.groupbxAccomodation.Controls.Add(this.btfindbed);
            this.groupbxAccomodation.Controls.Add(this.txbBedNumbers);
            this.groupbxAccomodation.Controls.Add(this.cbbxBedType);
            this.groupbxAccomodation.Controls.Add(this.txbDocSpecialTy);
            this.groupbxAccomodation.Controls.Add(this.txbDoctorID);
            this.groupbxAccomodation.Controls.Add(this.txbDoctorName);
            this.groupbxAccomodation.Controls.Add(this.cbbxWardName);
            this.groupbxAccomodation.Controls.Add(this.cbxPhone);
            this.groupbxAccomodation.Controls.Add(this.cbxTV);
            this.groupbxAccomodation.Controls.Add(this.label12);
            this.groupbxAccomodation.Controls.Add(this.label3);
            this.groupbxAccomodation.Controls.Add(this.label9);
            this.groupbxAccomodation.Controls.Add(this.label13);
            this.groupbxAccomodation.Controls.Add(this.label14);
            this.groupbxAccomodation.Controls.Add(this.label16);
            this.groupbxAccomodation.Controls.Add(this.label15);
            this.groupbxAccomodation.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupbxAccomodation.Location = new System.Drawing.Point(11, 314);
            this.groupbxAccomodation.Margin = new System.Windows.Forms.Padding(2);
            this.groupbxAccomodation.Name = "groupbxAccomodation";
            this.groupbxAccomodation.Padding = new System.Windows.Forms.Padding(2);
            this.groupbxAccomodation.Size = new System.Drawing.Size(665, 224);
            this.groupbxAccomodation.TabIndex = 1;
            this.groupbxAccomodation.TabStop = false;
            this.groupbxAccomodation.Text = "Accomodation";
            // 
            // btfindbed
            // 
            this.btfindbed.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btfindbed.Location = new System.Drawing.Point(247, 163);
            this.btfindbed.Margin = new System.Windows.Forms.Padding(2);
            this.btfindbed.Name = "btfindbed";
            this.btfindbed.Size = new System.Drawing.Size(59, 39);
            this.btfindbed.TabIndex = 18;
            this.btfindbed.UseVisualStyleBackColor = true;
            this.btfindbed.Click += new System.EventHandler(this.btfindbed_Click);
            // 
            // txbBedNumbers
            // 
            this.txbBedNumbers.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBedNumbers.Location = new System.Drawing.Point(127, 167);
            this.txbBedNumbers.Margin = new System.Windows.Forms.Padding(2);
            this.txbBedNumbers.Name = "txbBedNumbers";
            this.txbBedNumbers.Size = new System.Drawing.Size(109, 32);
            this.txbBedNumbers.TabIndex = 17;
            // 
            // cbbxBedType
            // 
            this.cbbxBedType.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbxBedType.FormattingEnabled = true;
            this.cbbxBedType.Location = new System.Drawing.Point(127, 49);
            this.cbbxBedType.Margin = new System.Windows.Forms.Padding(2);
            this.cbbxBedType.Name = "cbbxBedType";
            this.cbbxBedType.Size = new System.Drawing.Size(109, 32);
            this.cbbxBedType.TabIndex = 16;
            this.cbbxBedType.SelectedIndexChanged += new System.EventHandler(this.cbbxBedType_SelectedIndexChanged);
            // 
            // txbDocSpecialTy
            // 
            this.txbDocSpecialTy.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txbDocSpecialTy.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDocSpecialTy.Location = new System.Drawing.Point(445, 167);
            this.txbDocSpecialTy.Margin = new System.Windows.Forms.Padding(2);
            this.txbDocSpecialTy.Name = "txbDocSpecialTy";
            this.txbDocSpecialTy.ReadOnly = true;
            this.txbDocSpecialTy.Size = new System.Drawing.Size(198, 32);
            this.txbDocSpecialTy.TabIndex = 8;
            this.txbDocSpecialTy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbDoctorID
            // 
            this.txbDoctorID.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txbDoctorID.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDoctorID.Location = new System.Drawing.Point(445, 49);
            this.txbDoctorID.Margin = new System.Windows.Forms.Padding(2);
            this.txbDoctorID.Name = "txbDoctorID";
            this.txbDoctorID.ReadOnly = true;
            this.txbDoctorID.Size = new System.Drawing.Size(198, 32);
            this.txbDoctorID.TabIndex = 6;
            this.txbDoctorID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbDoctorName
            // 
            this.txbDoctorName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txbDoctorName.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDoctorName.Location = new System.Drawing.Point(445, 108);
            this.txbDoctorName.Margin = new System.Windows.Forms.Padding(2);
            this.txbDoctorName.Name = "txbDoctorName";
            this.txbDoctorName.ReadOnly = true;
            this.txbDoctorName.Size = new System.Drawing.Size(198, 32);
            this.txbDoctorName.TabIndex = 7;
            this.txbDoctorName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbbxWardName
            // 
            this.cbbxWardName.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbxWardName.FormattingEnabled = true;
            this.cbbxWardName.Location = new System.Drawing.Point(127, 108);
            this.cbbxWardName.Margin = new System.Windows.Forms.Padding(2);
            this.cbbxWardName.Name = "cbbxWardName";
            this.cbbxWardName.Size = new System.Drawing.Size(109, 32);
            this.cbbxWardName.TabIndex = 2;
            this.cbbxWardName.SelectedIndexChanged += new System.EventHandler(this.cbbxWardName_SelectedIndexChanged);
            // 
            // cbxPhone
            // 
            this.cbxPhone.AutoSize = true;
            this.cbxPhone.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPhone.Location = new System.Drawing.Point(247, 51);
            this.cbxPhone.Margin = new System.Windows.Forms.Padding(2);
            this.cbxPhone.Name = "cbxPhone";
            this.cbxPhone.Size = new System.Drawing.Size(94, 28);
            this.cbxPhone.TabIndex = 4;
            this.cbxPhone.Text = "Phone ";
            this.cbxPhone.UseVisualStyleBackColor = true;
            // 
            // cbxTV
            // 
            this.cbxTV.AutoSize = true;
            this.cbxTV.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTV.Location = new System.Drawing.Point(247, 107);
            this.cbxTV.Margin = new System.Windows.Forms.Padding(2);
            this.cbxTV.Name = "cbxTV";
            this.cbxTV.Size = new System.Drawing.Size(61, 28);
            this.cbxTV.TabIndex = 5;
            this.cbxTV.Text = "TV ";
            this.cbxTV.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(15, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 24);
            this.label12.TabIndex = 14;
            this.label12.Text = "Bed Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Bed Number:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 24);
            this.label9.TabIndex = 15;
            this.label9.Text = "Ward:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(432, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(155, 24);
            this.label13.TabIndex = 9;
            this.label13.Text = "Doctor In Charge";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(352, 112);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 24);
            this.label14.TabIndex = 11;
            this.label14.Text = "Name:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(352, 171);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 24);
            this.label16.TabIndex = 12;
            this.label16.Text = "Specialty:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(352, 53);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 24);
            this.label15.TabIndex = 10;
            this.label15.Text = "ID:";
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.Color.White;
            this.btSave.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btSave.Location = new System.Drawing.Point(440, 559);
            this.btSave.Margin = new System.Windows.Forms.Padding(2);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(73, 46);
            this.btSave.TabIndex = 2;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Chocolate;
            this.label17.Location = new System.Drawing.Point(130, 4);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(390, 44);
            this.label17.TabIndex = 6;
            this.label17.Text = "NHL Hospital Admission";
            // 
            // btLoadAdmission
            // 
            this.btLoadAdmission.BackColor = System.Drawing.Color.White;
            this.btLoadAdmission.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLoadAdmission.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btLoadAdmission.Location = new System.Drawing.Point(254, 559);
            this.btLoadAdmission.Margin = new System.Windows.Forms.Padding(2);
            this.btLoadAdmission.Name = "btLoadAdmission";
            this.btLoadAdmission.Size = new System.Drawing.Size(163, 46);
            this.btLoadAdmission.TabIndex = 5;
            this.btLoadAdmission.Text = "Load Admission";
            this.btLoadAdmission.UseVisualStyleBackColor = false;
            this.btLoadAdmission.Click += new System.EventHandler(this.btLoadAdmission_Click);
            // 
            // frmAdmissions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 624);
            this.ControlBox = false;
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.groupbxAccomodation);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btLoadAdmission);
            this.Controls.Add(this.btNewAdmission);
            this.Controls.Add(this.groupbxAdmissiondata);
            this.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAdmissions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admission Record";
            this.Load += new System.EventHandler(this.frmAdmissions_Load);
            this.groupbxAdmissiondata.ResumeLayout(false);
            this.groupbxAdmissiondata.PerformLayout();
            this.groupbxAccomodation.ResumeLayout(false);
            this.groupbxAccomodation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbAdmissionID;
        private System.Windows.Forms.MaskedTextBox MtxbPatientID;
        private System.Windows.Forms.GroupBox groupbxAdmissiondata;
        private System.Windows.Forms.Button btNewAdmission;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.TextBox txbStayLength;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupbxAccomodation;
        private System.Windows.Forms.ComboBox cbbxWardName;
        private System.Windows.Forms.CheckBox cbxPhone;
        private System.Windows.Forms.CheckBox cbxTV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txbPatientNextOfKin;
        private System.Windows.Forms.TextBox txbPatientName;
        private System.Windows.Forms.TextBox txbDoctorID;
        private System.Windows.Forms.TextBox txbDoctorName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txbDocSpecialTy;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RadioButton rdbt_Not;
        private System.Windows.Forms.RadioButton rdrbt_yes;
        private System.Windows.Forms.DateTimePicker dtpSurgeryDate;
        private System.Windows.Forms.DateTimePicker dtpAdmissionDate;
        private System.Windows.Forms.DateTimePicker dtpDischargedDate;
        private System.Windows.Forms.ComboBox cbbxBedType;
        private System.Windows.Forms.TextBox txbBedNumbers;
        private System.Windows.Forms.Button btfindbed;
        private System.Windows.Forms.Button btLoadAdmission;
    }
}