using NLHBaseWindow;
using NLHospital.Properties;
using NLHospitalLibrary;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace NLHospital
{
    public partial class frmAdmissions : NLHBase
    {
        frmMenu mymenu;

        Beds oBed = new Beds();
        Admissions oAdmission = new Admissions();

        string NewAdmissionID = "";
        SqlConnection sqlcon;
        SqlDataAdapter sqlAdpt;
        SqlCommand sqlCmd;

        double StayLength;

        bool SavedAdmissionRecord = false;

        string obedWar;
        string obedType;

        public frmAdmissions(frmMenu MYMENU)
        {
            InitializeComponent();
            mymenu = MYMENU;
        }
        private void frmAdmissions_Load(object sender, EventArgs e)
        {
            groupbxAdmissiondata.Enabled = false;
            groupbxAccomodation.Enabled = false;
            btSave.Enabled = false;
            rdbt_Not.Checked = true;
            dtpAdmissionDate.Value = DateTime.Today.Date;
            dtpSurgeryDate.Value = DateTime.Today.Date;
            dtpDischargedDate.Value = DateTime.Today.AddDays(+1);

            TimeSpan StayDays = Convert.ToDateTime(dtpDischargedDate.Text) - Convert.ToDateTime(dtpAdmissionDate.Text);
            StayLength = StayDays.Days;
            txbStayLength.Text = StayLength.ToString();

            loadcombos();
            cbbxBedType.SelectedIndex = 0;
            cbbxWardName.SelectedIndex = 0;
            obedType = "STANDARD";
            obedWar = "OBS";
            btfindbed.Enabled = false;
            btfindbed.Visible = false;
            txbBedNumbers.Enabled = false;
        }
        private void loadcombos()
        {
            cbbxBedType.Items.Add("STANDARD");
            cbbxBedType.Items.Add("SE PRIVATE");
            cbbxBedType.Items.Add("PRIVATE");

            cbbxWardName.Items.Add("OBSERVATION");
            cbbxWardName.Items.Add("CARDIOLOGY");
            cbbxWardName.Items.Add("PEDIATRICS");
            cbbxWardName.Items.Add("EMERGENCY");
        }
        private void btNewAdmission_Click(object sender, EventArgs e)
        {
            groupbxAdmissiondata.Enabled = true;
            groupbxAccomodation.Enabled = true;
            btSave.Enabled = true;
            btNewAdmission.Visible = false;
            btLoadAdmission.Visible = false;
            txbBedNumbers.Enabled = true;

            ConnectAdmission();
            FeelNewAdmission();
        }
        public void FeelNewAdmission()
        {
            txbAdmissionID.Text = NewAdmissionID;
        }
        public void ConnectAdmission()
        {
            sqlcon = new SqlConnection(Settings.Default.ConnectionString);
            sqlcon.Open();
            sqlCmd = sqlcon.CreateCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd = new SqlCommand("select * from AdmissionRecords", sqlcon);
            sqlAdpt = new SqlDataAdapter(sqlCmd);
            sqlAdpt.SelectCommand = sqlCmd;
            DataSet admiss = new DataSet();
            try
            {
                sqlAdpt.Fill(admiss, "AdmissionRecords");
                if (admiss.Tables["AdmissionRecords"].Rows.Count == 0)
                {
                    NewAdmissionID = "1";
                }
                else
                {
                    int tablesize = admiss.Tables["AdmissionRecords"].Rows.Count;
                    NewAdmissionID = (tablesize + 1).ToString();

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void btExit_Click(object sender, EventArgs e)
        {
            if (SavedAdmissionRecord == true)
            {
                this.Close();
                mymenu.Show();
            }
            else
            {
                DialogResult Result = MessageBox.Show("If you quit now all data in the form will be missed", "Leave without save admission", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (Result == DialogResult.OK)
                {
                    this.Close();
                    mymenu.Show();
                }
            }
        }
        private void MtxbPatientID_Click(object sender, EventArgs e)
        {
            MtxbPatientID.SelectionStart = MtxbPatientID.Text.Length + 1;
        }
        private void cbbxBedType_SelectedIndexChanged(object sender, EventArgs e)
        {
            obedType = "";
            obedType = cbbxBedType.SelectedItem.ToString().Trim();
        }
        private void cbbxWardName_SelectedIndexChanged(object sender, EventArgs e)
        {
            obedWar = "";
            switch (cbbxWardName.SelectedItem.ToString().Trim())
            {
                case "OBSERVATION":
                    obedWar = "OBS";
                    break;
                case "CARDIOLOGY":
                    obedWar = "CARD";
                    break;
                case "PEDIATRICS":
                    obedWar = "PED";
                    break;
                case "EMERGENCY":
                    obedWar = "EMER";
                    break;
            }
        }
        private void btfindbed_Click(object sender, EventArgs e)
        {
            loadbeds();
        }
        private void loadbeds()
        {
            bool valid = oBed.getAvailabelBed(obedType, obedWar);
            if (valid == false)
            {
                MessageBox.Show("Sorry, there is not " + obedType + " accomodation available in the " + cbbxWardName.SelectedItem.ToString() + " ward.", "Unavailable bed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                oBed.getAvailabelBed(obedType, obedWar);
                txbBedNumbers.Text = oBed.bNumber.ToString();
            }
        }
        private void btSave_Click(object sender, EventArgs e)
        {
            bool saveok = saveRecords();

            if (saveok == false)
            {
                this.Close();
                mymenu.Show();
            }
            else
            {
                oBed.setbedBusy();
                groupbxAdmissiondata.Enabled = false;
                groupbxAccomodation.Enabled = false;
                OpenBill();
            }
        }
        private void OpenBill()
        {
            //oBill.bAdmissionID = oAdmission.AdmissionID;
            //oBill.bStayLength = Convert.ToInt32(txbStayLength.Text);
            //oBill.accommodationType = cbbxBedType.Text;
            //oBill.RecordBill(oAdmission);
        }
        private bool saveRecords()
        {
            bool saveallowed = true;
            string msge;

            oAdmission.admPatientID = MtxbPatientID.Text;
            oAdmission.admBedNo = txbBedNumbers.Text;
            if (rdrbt_yes.Checked == true)
            {
                oAdmission.admSurgerySchedule = true;
            }
            if (rdbt_Not.Checked == true)
            {
                oAdmission.admSurgerySchedule = false;
            }
            oAdmission.admissionDate = Convert.ToDateTime(dtpAdmissionDate.Text);
            oAdmission.admSurgeryDate = Convert.ToDateTime(dtpSurgeryDate.Text);
            oAdmission.admpatientDischargedDate = Convert.ToDateTime(dtpDischargedDate.Text);
            oAdmission.admDoctorID = txbDoctorID.Text;
            if (cbxTV.Checked == true)
            {
                oAdmission.admtv = true;
            }
            if (cbxPhone.Checked == true)
            {
                oAdmission.admPhone = true;
            }

            msge = oAdmission.InsertNewAdmission();

            if (msge == "There is a Admission Open for this Patient, Please Close before progress a New Admission")
            {
                MessageBox.Show("Sorry" + msge, "Admission Transaction Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                saveallowed = false;
            }

            if (msge == "Invalid")
            {
                MessageBox.Show("Sorry" + msge, "Admission Transaction Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                saveallowed = false;
            }
            if (msge != "Invalid" && msge != "There is a Admission Open for this Patient, Please Close before progress a New Admission")
            {
                MessageBox.Show(" Transaction Sucessfully Progressed New Admission Number: " + msge, "Admission Transaction", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbAdmissionID.Text = msge;
                oAdmission.AdmissionID = msge;
                SavedAdmissionRecord = true;
                btSave.Hide();
            }
            return saveallowed;
        }
        private void btLoadAdmission_Click(object sender, EventArgs e)
        {
            txbAdmissionID.Enabled = true;
        }
        private void txbAdmissionID_Leave(object sender, EventArgs e)
        {
            groupbxAdmissiondata.Enabled = true;
            groupbxAccomodation.Enabled = true;
        }

        private void dtpDischargedDate_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan StayDays = Convert.ToDateTime(dtpDischargedDate.Text) - Convert.ToDateTime(dtpAdmissionDate.Text);
            StayLength = StayDays.Days;
            txbStayLength.Text = StayLength.ToString();

        }

        private void dtpSurgeryDate_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan StayDays = Convert.ToDateTime(dtpDischargedDate.Text) - Convert.ToDateTime(dtpAdmissionDate.Text);
            StayLength = StayDays.Days;
            txbStayLength.Text = StayLength.ToString();

        }
    }
}
