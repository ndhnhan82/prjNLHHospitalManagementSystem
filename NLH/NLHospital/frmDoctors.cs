using NLHBaseWindow;
using NLHospitalLibrary;
using System;
using System.Data;
using System.Windows.Forms;

namespace NLHospital
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class frmDoctors : NLHBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        DataSet m_oDS = new DataSet();
        private Panel panel2;
        private Button btnSave;
        private Button btnQuit;
        private Panel panel1;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnFind;
        private Button btnAdd;
        private ComboBox cboSpeciality;
        private Label lblSpecialty;
        private Label lblFName;
        private Label lblLName;
        private Label lblDoctorID;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtDoctorID;
        private DataGridView dgDoctors;
        DataSet m_oSP = new DataSet();
        frmMenu myMenu;
        public frmDoctors(frmMenu menu)
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
            myMenu = menu;

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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cboSpeciality = new System.Windows.Forms.ComboBox();
            this.lblSpecialty = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblDoctorID = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtDoctorID = new System.Windows.Forms.TextBox();
            this.dgDoctors = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDoctors)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.btnQuit);
            this.panel2.Controls.Add(this.btnFind);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 313);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(796, 285);
            this.panel2.TabIndex = 22;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(647, 108);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 53);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(647, 192);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(120, 52);
            this.btnQuit.TabIndex = 23;
            this.btnQuit.Text = "Quit";
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cboSpeciality);
            this.panel1.Controls.Add(this.lblSpecialty);
            this.panel1.Controls.Add(this.lblFName);
            this.panel1.Controls.Add(this.lblLName);
            this.panel1.Controls.Add(this.lblDoctorID);
            this.panel1.Controls.Add(this.txtFirstName);
            this.panel1.Controls.Add(this.txtLastName);
            this.panel1.Controls.Add(this.txtDoctorID);
            this.panel1.Location = new System.Drawing.Point(12, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 235);
            this.panel1.TabIndex = 22;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(497, 191);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 53);
            this.btnDelete.TabIndex = 31;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(497, 107);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 53);
            this.btnUpdate.TabIndex = 30;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(647, 24);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(120, 53);
            this.btnFind.TabIndex = 29;
            this.btnFind.Text = "Find";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(497, 24);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 52);
            this.btnAdd.TabIndex = 28;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cboSpeciality
            // 
            this.cboSpeciality.Items.AddRange(new object[] {
            "Anatomical Pathology",
            "Anesthesiology",
            "Cardiology",
            "Cardiovascular/Thoracic Surgery",
            "Clinical Immunology/Allergy",
            "Critical Care Medicine",
            "Dermatology",
            "Diagnostic Radiology",
            "Emergency Medicine",
            "Endocrinology and Metabolism",
            "Family Medicine",
            "Gastroenterology",
            "General Internal Medicine",
            "General Surgery",
            "General/Clinical Pathology",
            "Geriatric Medicine",
            "Hematology",
            "Medical Biochemistry",
            "Medical Genetics",
            "Medical Oncology",
            "Nephrology",
            "Neurology",
            "Neurosurgery",
            "Nuclear Medicine",
            "Obstetrics/Gynecology",
            "Occupational Medicine",
            "Ophthalmology",
            "Orthopedic Surgery",
            "Otolaryngology",
            "Pediatrics",
            "Plastic Surgery",
            "Psychiatry\t",
            "Radiation Oncology\t",
            "Respirology",
            "Rheumatology",
            "Urology"});
            this.cboSpeciality.Location = new System.Drawing.Point(141, 180);
            this.cboSpeciality.Name = "cboSpeciality";
            this.cboSpeciality.Size = new System.Drawing.Size(269, 32);
            this.cboSpeciality.TabIndex = 27;
            // 
            // lblSpecialty
            // 
            this.lblSpecialty.AutoSize = true;
            this.lblSpecialty.Location = new System.Drawing.Point(13, 183);
            this.lblSpecialty.Name = "lblSpecialty";
            this.lblSpecialty.Size = new System.Drawing.Size(85, 24);
            this.lblSpecialty.TabIndex = 26;
            this.lblSpecialty.Text = "Specialty";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(13, 127);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(104, 24);
            this.lblFName.TabIndex = 25;
            this.lblFName.Text = "First Name:";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(13, 71);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(103, 24);
            this.lblLName.TabIndex = 24;
            this.lblLName.Text = "Last Name:";
            // 
            // lblDoctorID
            // 
            this.lblDoctorID.AutoSize = true;
            this.lblDoctorID.Location = new System.Drawing.Point(13, 15);
            this.lblDoctorID.Name = "lblDoctorID";
            this.lblDoctorID.Size = new System.Drawing.Size(96, 24);
            this.lblDoctorID.TabIndex = 23;
            this.lblDoctorID.Text = "Doctor ID:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(141, 125);
            this.txtFirstName.MaxLength = 20;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(269, 32);
            this.txtFirstName.TabIndex = 22;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(141, 70);
            this.txtLastName.MaxLength = 20;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(269, 32);
            this.txtLastName.TabIndex = 21;
            // 
            // txtDoctorID
            // 
            this.txtDoctorID.Location = new System.Drawing.Point(141, 15);
            this.txtDoctorID.MaxLength = 4;
            this.txtDoctorID.Name = "txtDoctorID";
            this.txtDoctorID.Size = new System.Drawing.Size(160, 32);
            this.txtDoctorID.TabIndex = 20;
            // 
            // dgDoctors
            // 
            this.dgDoctors.AllowUserToAddRows = false;
            this.dgDoctors.AllowUserToDeleteRows = false;
            this.dgDoctors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDoctors.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgDoctors.Location = new System.Drawing.Point(0, 0);
            this.dgDoctors.MultiSelect = false;
            this.dgDoctors.Name = "dgDoctors";
            this.dgDoctors.ReadOnly = true;
            this.dgDoctors.RowHeadersWidth = 62;
            this.dgDoctors.RowTemplate.Height = 28;
            this.dgDoctors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDoctors.Size = new System.Drawing.Size(796, 309);
            this.dgDoctors.TabIndex = 23;
            this.dgDoctors.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgDoctors_CellMouseClick);
            // 
            // frmDoctors
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(9, 25);
            this.ClientSize = new System.Drawing.Size(796, 598);
            this.ControlBox = false;
            this.Controls.Add(this.dgDoctors);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmDoctors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doctors";
            this.Load += new System.EventHandler(this.frmDoctors_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDoctors)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion


        private void frmDoctors_Load(object sender, System.EventArgs e)
        {
            LoadDoctorData();
            LoadSpecialtyData();
        }
        private void LoadSpecialtyData()
        {

            // cboSpeciality.Items.AddRange(dgDoctors.Columns[1].);


        }
        private void LoadDoctorData()
        {
            Doctors oDoctor = new Doctors();
            dgDoctors.DataBindings.Clear();
            m_oDS = oDoctor.GetData();
            dgDoctors.DataSource = m_oDS.Tables["Doctors"];


        }


        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            string docID = txtDoctorID.Text.Trim();
            string LName = txtLastName.Text.Trim();
            string FName = txtFirstName.Text.Trim();
            string sPec = cboSpeciality.Text.Trim();

            string sMsg = "";

            DataSet o_Add = new DataSet();
            Doctors oDoctors = new Doctors();
            try
            {
                if (docID.Length != 4)
                {
                    sMsg = "DoctorID must have 4 characters. Please enter another DoctorID to save!";
                }
                else if (sPec == "" || LName == "" || FName == "")
                {
                    sMsg = "Please enter lastname, firstname and choose a speciality for doctor!";
                }
                else
                {
                    sMsg = oDoctors.AddData(docID, LName, FName, sPec);
                }
            }
            catch
            {
                sMsg = "Error saving data." + "\n\n" + e.ToString();
            }
            finally
            {
                LoadDoctorData();
                MessageBox.Show(sMsg, "Add Record", MessageBoxButtons.OK);
            }
        }

        private void btnFind_Click(object sender, System.EventArgs e)
        {
            string docID = txtDoctorID.Text.Trim();
            string sMsg = "";

            DataSet o_Find = new DataSet();
            Doctors oDoctors = new Doctors();

            try
            {
                o_Find = oDoctors.FindData(docID);

                if (o_Find.Tables["Doctors"] != null)
                {
                    txtLastName.Text = o_Find.Tables["Doctors"].Rows[0]["LastName"].ToString();
                    txtFirstName.Text = o_Find.Tables["Doctors"].Rows[0]["FirstName"].ToString();
                    cboSpeciality.Text = o_Find.Tables["Doctors"].Rows[0]["Specialty"].ToString();
                    cboSpeciality.SelectedIndex = this.BindingContext[o_Find, "Doctors"].Position;
                    sMsg = "Doctor record found.";
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                sMsg = "Doctor not in database. Please enter another Doctor ID to find!";
                txtDoctorID.Text = "";
            }
            finally
            {
                MessageBox.Show(sMsg, "Find Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            string docID = txtDoctorID.Text;
            string sMsg = "";

            DataSet o_Delete = new DataSet();
            Doctors oDoctors = new Doctors();
            if (docID.Trim() != "")
            {
                try
                {
                    sMsg = oDoctors.DeleteData(docID);
                    LoadDoctorData();
                    txtDoctorID.Text = "";
                    txtLastName.Text = "";
                    txtFirstName.Text = "";
                    sMsg = "Doctor record deleted.";
                }
                catch
                {
                    sMsg = "Error deleting data." + "\n\n" + e.ToString();
                }
                finally
                {
                    MessageBox.Show(sMsg, "Delete Record", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("DoctorID is empty!", "Information", MessageBoxButtons.OK);

            }


        }

        private void btnUpdate_Click(object sender, System.EventArgs e)
        {
            string docID = txtDoctorID.Text;
            string LName = txtLastName.Text;
            string FName = txtFirstName.Text;
            string sPec = cboSpeciality.Text;
            string sMsg = "";
            DataSet o_Find = new DataSet();
            Doctors oDoctors = new Doctors();


            try
            {
                if (txtDoctorID.Text.Trim().Length == 0)
                {
                    sMsg = "Error updating data.\n\nDoctor with ID is empty!";
                }
                else
                {
                    o_Find = oDoctors.FindData(docID);

                    if (o_Find.Tables["Doctors"] != null)
                    {
                        sMsg = oDoctors.UpdateData(docID, LName, FName, sPec);
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
            }
            catch (Exception)
            {
                sMsg = "Error saving data." + "\n\n" + "Doctor with ID '" + docID + "' does not exist or something wrong with database!";
            }
            finally
            {
                LoadDoctorData();
                MessageBox.Show(sMsg, "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnQuit_Click(object sender, System.EventArgs e)
        {
            this.Close();
            myMenu.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sMsg = "";

            Doctors oDoctors = new Doctors();
            DataSet o_Save = oDoctors.GetData();
            if (txtDoctorID.Text.Trim() != "")
            {
                try
                {
                    sMsg = oDoctors.SaveData(o_Save);
                    LoadDoctorData();
                    txtDoctorID.Text = "";
                    txtLastName.Text = "";
                    txtFirstName.Text = "";
                    sMsg = "Doctor record saved.";
                }
                catch
                {
                    sMsg = "Error saving data." + "\n\n" + e.ToString();
                }
                finally
                {
                    MessageBox.Show(sMsg, "Save Record", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Doctor ID is empty!", "Error Save Record", MessageBoxButtons.OK);

            }


        }

        private void dgDoctors_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txtDoctorID.Text = dgDoctors.Rows[numrow].Cells[0].Value.ToString().Trim();
            txtLastName.Text = dgDoctors.Rows[numrow].Cells[1].Value.ToString();
            txtFirstName.Text = dgDoctors.Rows[numrow].Cells[2].Value.ToString();
            cboSpeciality.Text = dgDoctors.Rows[numrow].Cells[3].Value.ToString();

        }
    }
}
