using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doc_Sys
{
    public partial class frmRegPat : Form
    {
        public frmRegPat()
        {
            InitializeComponent();
            txtPatId.Text = Convert.ToString(getNextPatientID());
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnReg_Click(object sender, EventArgs e)
        {

            String dob;

            //Convert text box data to int for validation
            int dateInt = 0;
            Int32.TryParse(dateTb.Text, out dateInt);
            int monthInt = 0;
            Int32.TryParse(monthTb.Text, out monthInt);
            //Create the Doctor using the Doctor class
            Patient newPatient = new Patient();
            newPatient.setPatientID(getNextPatientID());
            newPatient.setGender(cboPatSex.Text);
            newPatient.setForename(txtForename.Text);
            newPatient.setSurname(txtSurname.Text);
            newPatient.setStreet(txtStreet.Text);
            newPatient.setTown(txtTown.Text);
            newPatient.setCounty(cboCounty.Text);

            dob = dateInt + "-" + monthName(monthInt) + "-" + yearCbo.Text;
            newPatient.setDateofBirth(dob);

            // Validate the data entered
            if (txtForename.Text=="")
            {
                MessageBox.Show("Forename must be entered");
                txtForename.Focus();
            }
            
            else if (txtSurname.Text == "")
            {
                MessageBox.Show("Surname must be entered");
                txtSurname.Focus();
            }

            else if (cboPatSex.Text == "")
            {
                MessageBox.Show("Gender must be entered");
                cboPatSex.Focus();
            }
            else if (dateInt <= 0 || dateInt >= 31)
            {
                MessageBox.Show("Date out of bounds!");
                dateTb.Focus();
            }
            else if (monthInt <= 0 || monthInt >= 13)
            {
                MessageBox.Show("Month out of bounds!");
                monthTb.Focus();
            }

            // Save the Data in the Patient File
            else
            {

                //Oracle Connect
                //Define database connection string
                String oradb = "Data Source=Oracle;User Id =Leccw;Password =123456;";

                //Connect to Database
                OracleConnection conn = new OracleConnection(oradb);
                conn.Open();
                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;

                //Define SQL Query (UPDATE)
                String strSQL = "INSERT INTO PATIENTS VALUES (" + getNextPatientID() + ",'" + newPatient.getGender() + "','" + newPatient.getForename() +
                    "','" + newPatient.getSurname() + "','" + newPatient.getStreet() + "','" + newPatient.getTown() + "','" + newPatient.getCounty() + "','" + newPatient.getDateOfBirth() + "')";

                cmd.CommandText = strSQL;
                try
                {
                    //Execute SQL Query
                    cmd.ExecuteNonQuery();
                }
                catch (OracleException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                //Close Database
                conn.Close();
                MessageBox.Show("Patient Registered");


                //Clear the form
                //Clear the form
                cboPatSex.Text = null;
                txtForename.Text = "";
                txtSurname.Text = "";
                txtTown.Text = "";
                cboCounty.Text = null;
                txtStreet.Text = "";
                txtPatId.Text = Convert.ToString(getNextPatientID());

                btnReg.Enabled = false;
                grpDoB.Visible = false;
                grpAddress.Visible = false;


                // Display confirmation Message
            }
        }

        private int getNextPatientID()
        {
            //Oracle Connect
            //Define database connection string
            String oradb1 = "Data Source=Oracle;User Id =Leccw;Password =123456;";

            //Connect to Database
            OracleConnection conn = new OracleConnection(oradb1);
            conn.Open();
            OracleCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;

            //Define SQL Query (UPDATE)
            String strSQL = "SELECT NVL(MAX(Patient_ID),0) FROM PATIENTS";

            cmd.CommandText = strSQL;

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();            

            if (dr.GetValue(0).ToString().Equals("0"))
            {
                return 1001;
            }
            else
                return  (Convert.ToInt16(dr.GetValue(0)) + 1);

            try
            {
                //Execute SQL Query
                cmd.ExecuteNonQuery();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }


            //Close Database
            conn.Close();
        }

        public String monthName(int month)
        {
            String m_name = "";
            switch (month)
            {
                case 1:
                    m_name = "JAN";
                    break;
                case 2:
                    m_name = "FEB";
                    break;
                case 3:
                    m_name = "MAR";
                    break;
                case 4:
                    m_name = "APR";
                    break;
                case 5:
                    m_name = "MAY";
                    break;
                case 6:
                    m_name = "JUN";
                    break;
                case 7:
                    m_name = "JUL";
                    break;
                case 8:
                    m_name = "AUG";
                    break;
                case 9:
                    m_name = "SEP";
                    break;
                case 10:
                    m_name = "OCT";
                    break;
                case 11:
                    m_name = "NOV";
                    break;
                case 12:
                    m_name = "DEC";
                    break;
            }

            return m_name;
        }

        private void frmRegPat_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); ;
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtStreet_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void cboCounty_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnReg.Enabled = true;
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            grpDoB.Visible = true;
        }


        private void txtForename_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDocId_TextChanged(object sender, EventArgs e)
        {

        }

        private void yearCbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpAddress.Visible = true;
        }

        private void dateTb_Enter(object sender, EventArgs e)
        {
            dateTb.Text = "";
        }

        private void monthTb_Enter(object sender, EventArgs e)
        {
            monthTb.Text = "";
        }
       

    }
}
