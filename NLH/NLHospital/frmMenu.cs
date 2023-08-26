using NLHBaseWindow;
using NLHospitalLibrary;
using System;
using System.Windows.Forms;


namespace NLHospital
{
    /// <summary>
    /// Summary description for frmMenu.
    /// </summary>
    public class frmMenu : NLHBase
    {
        private System.Windows.Forms.Label lblAdministrator;
        private System.Windows.Forms.Button btnDoctors;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Panel pnlAdministrator;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDischarge;
        private System.Windows.Forms.Button btnSurgery;
        private System.Windows.Forms.Label lblNurses;
        private System.Windows.Forms.Button btnForSurgery;
        private System.Windows.Forms.Button btnBilling;
        private System.Windows.Forms.Button btnPatientList;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Panel pnlDoctors;
        private System.Windows.Forms.Panel pnlNurses;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPatientID;
        private System.Windows.Forms.Label label1;
        private Panel panel1;
        public CurrentUser oCurrent = new CurrentUser();

        public frmMenu()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            this.pnlAdministrator = new System.Windows.Forms.Panel();
            this.btnBilling = new System.Windows.Forms.Button();
            this.btnDoctors = new System.Windows.Forms.Button();
            this.lblAdministrator = new System.Windows.Forms.Label();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.pnlDoctors = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSurgery = new System.Windows.Forms.Button();
            this.btnDischarge = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlNurses = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPatientList = new System.Windows.Forms.Button();
            this.btnForSurgery = new System.Windows.Forms.Button();
            this.lblNurses = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlAdministrator.SuspendLayout();
            this.pnlDoctors.SuspendLayout();
            this.pnlNurses.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAdministrator
            // 
            this.pnlAdministrator.Controls.Add(this.btnBilling);
            this.pnlAdministrator.Controls.Add(this.btnDoctors);
            this.pnlAdministrator.Controls.Add(this.lblAdministrator);
            this.pnlAdministrator.Controls.Add(this.lblAdmin);
            this.pnlAdministrator.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAdministrator.Location = new System.Drawing.Point(0, 0);
            this.pnlAdministrator.Name = "pnlAdministrator";
            this.pnlAdministrator.Size = new System.Drawing.Size(503, 180);
            this.pnlAdministrator.TabIndex = 0;
            // 
            // btnBilling
            // 
            this.btnBilling.Location = new System.Drawing.Point(261, 96);
            this.btnBilling.Name = "btnBilling";
            this.btnBilling.Size = new System.Drawing.Size(204, 56);
            this.btnBilling.TabIndex = 1;
            this.btnBilling.Text = "Bill Patient";
            this.btnBilling.Click += new System.EventHandler(this.btnBilling_Click);
            // 
            // btnDoctors
            // 
            this.btnDoctors.Location = new System.Drawing.Point(33, 96);
            this.btnDoctors.Name = "btnDoctors";
            this.btnDoctors.Size = new System.Drawing.Size(204, 56);
            this.btnDoctors.TabIndex = 0;
            this.btnDoctors.Text = "Manage Doctors";
            this.btnDoctors.Click += new System.EventHandler(this.btnDoctors_Click);
            // 
            // lblAdministrator
            // 
            this.lblAdministrator.AutoSize = true;
            this.lblAdministrator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdministrator.Location = new System.Drawing.Point(24, 12);
            this.lblAdministrator.Name = "lblAdministrator";
            this.lblAdministrator.Size = new System.Drawing.Size(149, 25);
            this.lblAdministrator.TabIndex = 2;
            this.lblAdministrator.Text = "Administration";
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Location = new System.Drawing.Point(102, 51);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(296, 24);
            this.lblAdmin.TabIndex = 3;
            this.lblAdmin.Text = "Please select one of the following:";
            // 
            // pnlDoctors
            // 
            this.pnlDoctors.Controls.Add(this.label1);
            this.pnlDoctors.Controls.Add(this.txtPatientID);
            this.pnlDoctors.Controls.Add(this.label3);
            this.pnlDoctors.Controls.Add(this.btnSurgery);
            this.pnlDoctors.Controls.Add(this.btnDischarge);
            this.pnlDoctors.Controls.Add(this.label2);
            this.pnlDoctors.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDoctors.Location = new System.Drawing.Point(0, 180);
            this.pnlDoctors.Name = "pnlDoctors";
            this.pnlDoctors.Size = new System.Drawing.Size(503, 206);
            this.pnlDoctors.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Patient ID:";
            // 
            // txtPatientID
            // 
            this.txtPatientID.Location = new System.Drawing.Point(171, 86);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.Size = new System.Drawing.Size(249, 31);
            this.txtPatientID.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(288, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Please elect one of the following:";
            // 
            // btnSurgery
            // 
            this.btnSurgery.Location = new System.Drawing.Point(261, 135);
            this.btnSurgery.Name = "btnSurgery";
            this.btnSurgery.Size = new System.Drawing.Size(204, 55);
            this.btnSurgery.TabIndex = 2;
            this.btnSurgery.Text = "Surgery Report";
            this.btnSurgery.Click += new System.EventHandler(this.btnSurgery_Click);
            // 
            // btnDischarge
            // 
            this.btnDischarge.Location = new System.Drawing.Point(33, 135);
            this.btnDischarge.Name = "btnDischarge";
            this.btnDischarge.Size = new System.Drawing.Size(204, 55);
            this.btnDischarge.TabIndex = 1;
            this.btnDischarge.Text = "Discharge Patient";
            this.btnDischarge.Click += new System.EventHandler(this.btnDischarge_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Doctors";
            // 
            // pnlNurses
            // 
            this.pnlNurses.Controls.Add(this.label4);
            this.pnlNurses.Controls.Add(this.btnPatientList);
            this.pnlNurses.Controls.Add(this.btnForSurgery);
            this.pnlNurses.Controls.Add(this.lblNurses);
            this.pnlNurses.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNurses.Location = new System.Drawing.Point(0, 386);
            this.pnlNurses.Name = "pnlNurses";
            this.pnlNurses.Size = new System.Drawing.Size(503, 180);
            this.pnlNurses.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Select one of the following:";
            // 
            // btnPatientList
            // 
            this.btnPatientList.Location = new System.Drawing.Point(33, 96);
            this.btnPatientList.Name = "btnPatientList";
            this.btnPatientList.Size = new System.Drawing.Size(204, 56);
            this.btnPatientList.TabIndex = 0;
            this.btnPatientList.Text = "Patient List";
            this.btnPatientList.Click += new System.EventHandler(this.btnPatientList_Click);
            // 
            // btnForSurgery
            // 
            this.btnForSurgery.Location = new System.Drawing.Point(261, 96);
            this.btnForSurgery.Name = "btnForSurgery";
            this.btnForSurgery.Size = new System.Drawing.Size(204, 56);
            this.btnForSurgery.TabIndex = 1;
            this.btnForSurgery.Text = "Surgery Report";
            this.btnForSurgery.Click += new System.EventHandler(this.btnForSurgery_Click);
            // 
            // lblNurses
            // 
            this.lblNurses.AutoSize = true;
            this.lblNurses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNurses.Location = new System.Drawing.Point(24, 12);
            this.lblNurses.Name = "lblNurses";
            this.lblNurses.Size = new System.Drawing.Size(80, 25);
            this.lblNurses.TabIndex = 3;
            this.lblNurses.Text = "Nurses";
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(196, 21);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(113, 57);
            this.btnQuit.TabIndex = 0;
            this.btnQuit.Text = "Quit";
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnQuit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 566);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 90);
            this.panel1.TabIndex = 3;
            // 
            // frmMenu
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(9, 24);
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(503, 672);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlNurses);
            this.Controls.Add(this.pnlDoctors);
            this.Controls.Add(this.pnlAdministrator);
            this.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(525, 0);
            this.Name = "frmMenu";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.pnlAdministrator.ResumeLayout(false);
            this.pnlAdministrator.PerformLayout();
            this.pnlDoctors.ResumeLayout(false);
            this.pnlDoctors.PerformLayout();
            this.pnlNurses.ResumeLayout(false);
            this.pnlNurses.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private void btnDoctors_Click(object sender, System.EventArgs e)
        {
            frmDoctors doctorsForm = new frmDoctors(this);
            doctorsForm.Visible = true;
            doctorsForm.Activate();
            this.Hide();
        }

        private void btnQuit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void frmMenu_Load(object sender, System.EventArgs e)
        {
        }

        public void SelectUser()
        {
            switch (oCurrent.Position)
            {
                case "Admin":
                    pnlAdministrator.Visible = true;
                    pnlDoctors.Visible = false;
                    pnlNurses.Visible = false;
                    break;
                case "Doctor":
                    pnlDoctors.Visible = true;
                    pnlAdministrator.Visible = false;
                    pnlNurses.Visible = false;
                    break;
                case "Nurse":
                    pnlNurses.Visible = true;
                    pnlAdministrator.Visible = false;
                    pnlDoctors.Visible = false;
                    break;
            }

        }

        private void btnDischarge_Click(object sender, System.EventArgs e)
        {
            string patientID = txtPatientID.Text;
            string sMsg = "";
            Admissions oadms = new Admissions();
            oadms.SetPatientDischarge(patientID);
            MessageBox.Show(sMsg, "Discharging Patient", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            txtPatientID.Clear();
            txtPatientID.Focus();

        }

        private void btnBilling_Click(object sender, System.EventArgs e)
        {
            frmBillPatient billForm = new frmBillPatient(this);
            billForm.Visible = true;
            billForm.Activate();
            this.Hide();
        }

        private void btnPatientList_Click(object sender, EventArgs e)
        {

        }

        private void btnForSurgery_Click(object sender, EventArgs e)
        {

        }

        private void btnSurgery_Click(object sender, EventArgs e)
        {

        }
    }
}
