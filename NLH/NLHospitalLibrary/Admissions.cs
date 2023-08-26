using NLHospitalLibrary.Properties;
using System;
using System.Data;
using System.Data.SqlClient;

namespace NLHospitalLibrary
{
    /// <summary>
    /// Summary description for Admissions.
    /// </summary>
    public class Admissions
    {
        private DataSet m_oDS;
        private SqlConnection m_oCn;
        private SqlDataAdapter m_oDA;
        private string m_sClassName = "AdmissionRecords";
        private string sSQL;
        public string AdmissionID;
        public string admPatientID;
        public string admBedNo;
        public bool admSurgerySchedule;
        public DateTime admSurgeryDate;
        public DateTime admissionDate;
        public DateTime admpatientDischargedDate;
        public string admDoctorID;
        public bool admtv;
        public bool admPhone;
        public bool admsDischarged;

        public Admissions()
        {
            //
            // TODO: Add constructor logic here
            //
            SqlCommand oSelCmd;

            InitializeConnection();

            sSQL = "SELECT AdmissionID, PatientID, BedNumber, " +
                " SurgeryScheduled, SurgeryDate, AdmitDate, DischargeDate" +
                " FROM	AdmissionRecords " +
                " ORDER BY AdmissionID ";
            oSelCmd = new SqlCommand(sSQL, m_oCn)
            {
                CommandType = CommandType.Text
            };

            m_oDA = new SqlDataAdapter
            {
                SelectCommand = oSelCmd
            };

            m_oCn = null;

        }

        public DataSet FindData(string ID)
        {
            InitializeConnection();
            m_oCn.Open();
            DataSet thisDataSet = new DataSet();
            DataSet foundDataSet = new DataSet();
            try
            {
                m_oDA.Fill(thisDataSet, m_sClassName);
                for (int n = 0; n < thisDataSet.Tables["AdmissionRecords"].Rows.Count; n++)
                {
                    if (thisDataSet.Tables["AdmissionRecords"].Rows[n]["AdmissionID"].ToString() == ID)
                    {
                        m_oDA.Fill(foundDataSet, n, 1, "AdmissionRecords");
                    }
                }
            }
            catch
            {
            }
            finally
            {
                m_oCn.Close();
                m_oCn = null;
            }
            return foundDataSet;
        }

        public DataSet GetData()
        {
            m_oDS = new DataSet();
            m_oDA.Fill(m_oDS, m_sClassName);
            return m_oDS;
        }
        private void InitializeConnection()
        {
            m_oCn = new SqlConnection(
                @"Data Source=DESKTOP-E0AOPGN\MSSQLSERVER01;Integrated Security=SSPI;"
                + "Initial Catalog=NLH");
        }

        public bool IsPatientDischarged(string pId)
        {
            SqlConnection newcon = new SqlConnection(Settings.Default.ConnectionString);
            newcon.Open();
            bool admissionExist = false;
            DataSet thisdataset = new DataSet();
            try
            {
                m_oDA.Fill(thisdataset, m_sClassName);

                for (int i = 0; i < thisdataset.Tables["AdmissionRecords"].Rows.Count; i++)
                {
                    if (thisdataset.Tables["AdmissionRecords"].Rows[i]["PatientID"].ToString() == pId && Convert.ToBoolean(thisdataset.Tables["AdmissionRecords"].Rows[i]["Discharged"]) == false)
                    {
                        admissionExist = true;
                    }
                }
                return admissionExist;
            }
            catch (Exception)
            {
                return admissionExist;
            }

        }
        public string InsertNewAdmission()
        {
            bool existadmission = IsPatientDischarged(admPatientID);
            string procedureOk = "";
            admsDischarged = false;
            if (existadmission == true)
            {
                procedureOk = "There is a Admission Open for this Patient, Please Close before progress a New Admission";
            }
            else
            {
                try
                {
                    InitializeConnection();
                    m_oCn.Open();
                    SqlCommand sqlcmd = new SqlCommand();
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.CommandText = "usp_AddAdmissionRecord";
                    sqlcmd.Connection = m_oCn;
                    sqlcmd.Parameters.Add(new SqlParameter("@PatientID", admPatientID.ToString()));
                    sqlcmd.Parameters.Add(new SqlParameter("@BedNumber", admBedNo.ToString()));
                    sqlcmd.Parameters.Add(new SqlParameter("@SurgeryScheduled", Convert.ToBoolean(admSurgerySchedule)));
                    sqlcmd.Parameters.Add(new SqlParameter("@AdmitDate", Convert.ToDateTime(admissionDate)));
                    sqlcmd.Parameters.Add(new SqlParameter("@SurgeryDate", Convert.ToDateTime(admSurgeryDate)));
                    sqlcmd.Parameters.Add(new SqlParameter("@DischargeDate", Convert.ToDateTime(admpatientDischargedDate)));
                    sqlcmd.Parameters.Add(new SqlParameter("@DoctorID", admDoctorID.ToString()));
                    sqlcmd.Parameters.Add(new SqlParameter("@TV", Convert.ToBoolean(admtv)));
                    sqlcmd.Parameters.Add(new SqlParameter("@Phone", admPhone.ToString()));
                    sqlcmd.Parameters.Add(new SqlParameter("@Discharged", Convert.ToBoolean(admsDischarged)));

                    procedureOk = sqlcmd.ExecuteScalar().ToString();
                }
                catch (Exception E)
                {
                    procedureOk = "Invalid" + E.ToString();
                }
                finally
                {
                    m_oCn.Close();
                    m_oCn = null;
                }
            }
            return procedureOk;
        }
        public void SetPatientDischarge(string ID)
        {
            InitializeConnection();
            m_oCn.Open();

            DataSet thisDataSet = new DataSet();

            try
            {
                m_oDA.Fill(thisDataSet, m_sClassName);
                for (int n = 0; n < thisDataSet.Tables["AdmissionRecords"].Rows.Count; n++)
                {
                    if (thisDataSet.Tables["AdmissionRecords"].Rows[n]["PatientID"].ToString() == ID)
                    {
                        thisDataSet.Tables["AdmissionRecords"].Rows[n]["DischargeDate"] = DateTime.Today.Date;
                    }
                }
            }
            catch
            {
            }
            finally
            {
                m_oCn.Close();
                m_oCn = null;
            }
        }

        public int GetDays(string ID)
        {
            int days;
            DateTime dis = new DateTime();
            DateTime ad = new DateTime();

            DataSet thisDataSet = new DataSet();
            thisDataSet = this.FindData(ID);

            ad = Convert.ToDateTime(thisDataSet.Tables["Admissions"].Rows[0]["AdmitDate"]);
            dis = Convert.ToDateTime(thisDataSet.Tables["Admissions"].Rows[0]["DischargeDate"]);

            days = dis.Day - ad.Day;

            return days;

        }
    }
}

