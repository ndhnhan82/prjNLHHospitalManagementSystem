using NLHBaseWindow;
using NLHospitalLibrary;
using System;
using System.Data;
using System.Windows.Forms;

namespace NLHospital
{
    /// <summary>
    /// Summary description for frmNLHospital.
    /// </summary>
    /// 
    public class frmNLHospital : NLHBase
    {
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        static int cnt = 0;

        public frmNLHospital()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNLHospital));
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(94, 316);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(120, 52);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(304, 316);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 52);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(239, 190);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(202, 32);
            this.txtUserID.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(239, 244);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(202, 32);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Candara", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(530, 51);
            this.label1.TabIndex = 4;
            this.label1.Text = "Northern Lights Hospital";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUserID
            // 
            this.lblUserID.Location = new System.Drawing.Point(79, 188);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(212, 34);
            this.lblUserID.TabIndex = 7;
            this.lblUserID.Text = "User ID Name:";
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(79, 244);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(212, 32);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Password:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(79, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Please log in:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(164, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "Patient Admissions";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmNLHospital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(560, 425);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserID);
            this.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNLHospital";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcom to Northern Lights Hospital";
            this.Load += new System.EventHandler(this.frmNLHospital_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            frmMenu menu = new frmMenu();
            Application.Run(new frmNLHospital());
        }


        private void frmNLHospital_Load(object sender, System.EventArgs e)
        {

        }


        private void btnExit_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Exit Northern Lights Hospital application?", "Warning!!!",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            string strUser;
            string strPass;
            string sMsg = "";

            strUser = txtUserID.Text;
            strPass = txtPassword.Text;

            DataSet o_Find = new DataSet();
            Users oUsers = new Users();

            try
            {
                o_Find = oUsers.FindData(strUser, strPass);
                if (o_Find.Tables.Count != 0)
                {
                    sMsg = "Welcome " + o_Find.Tables["Login"].Rows[0]["UserName"];
                    string position = o_Find.Tables["Login"].Rows[0]["Position"].ToString();
                    frmMenu menuForm = new frmMenu();
                    menuForm.oCurrent.UserName = strUser;
                    switch (position)
                    {
                        case "Admissions":
                            menuForm.oCurrent.Position = "Admissions";
                            frmAdmissions admitForm = new frmAdmissions(menuForm);
                            admitForm.Visible = true;
                            admitForm.Activate();
                            break;
                        case "Admin":
                            menuForm.oCurrent.Position = "Admin";
                            this.Hide();
                            menuForm.SelectUser();
                            menuForm.Visible = true;
                            menuForm.Activate();
                            break;
                        case "Nurse":
                            menuForm.oCurrent.Position = "Nurse";
                            this.Hide();
                            menuForm.SelectUser();
                            menuForm.Visible = true;
                            menuForm.Activate();
                            break;
                        case "Doctor":
                            menuForm.oCurrent.Position = "Doctor";
                            this.Hide();
                            menuForm.SelectUser();
                            menuForm.Visible = true;
                            menuForm.Activate();
                            break;
                    }

                }
                else
                {
                    cnt += 1;
                    Exception myex = new Exception();
                    throw myex;
                }
            }

            catch (Exception)
            {
                if (cnt == 0)
                    sMsg = "User not in database. Please try again.";
                if (cnt == 1)
                    sMsg = "User not in database. One try left.";
                if (cnt == 2)
                    sMsg = "Application is closing. Please contact your supervisor.";
                txtUserID.Text = "";
                txtPassword.Text = "";
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show(sMsg, "Welcom to Northern Lights Hospital!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUserID.Text = "";
                txtPassword.Text = "";
            }

            if (cnt == 2)
            {
                Application.Exit();
            }
        }
    }
}
