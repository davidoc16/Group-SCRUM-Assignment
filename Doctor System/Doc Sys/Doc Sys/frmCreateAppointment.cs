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
    public partial class frmCreateAppointment : Form
    {

        public frmCreateAppointment()
        {
            InitializeComponent();
            
        }
        
        private void lstDoctors_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpSurname.Visible = true;
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            getAvailableTimes();
            lstAvailable.Visible = true;
        }

        private void lstPatients_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpApp.Visible = true;
        }

        private void lstAvailable_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
            
            
            /*DialogResult answer = MessageBox.Show("Would you like to create this Appointment", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (answer.Equals(DialogResult.OK)) //If appointment created the clear out the dialog boxes
            {
                MessageBox.Show("Appointment Created", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lstDoctors.ClearSelected();
                txtSurname.Text = "";
                grpApp.Visible = false;
                grpPatients.Visible = false;
                grpSurname.Visible = false;
                lstAvailable.Visible = false;
            }
            else
            {
                MessageBox.Show("Appointment not created", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }   */
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreateAppointmnet_Click(object sender, EventArgs e)
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
            String strSQL = "INSERT INTO APPOINTMENTS VALUES (101," + lstPatients.Text.Substring(0,4) +
                "," + lstDoctors.Text.Substring(0,4) + ",'" + lstAvailable.Text + "','" + String.Format("{0:dd-MMM-yy}",dateTimePicker1.Value) + 
                "')";

            cmd.CommandText = strSQL;

            cmd.ExecuteNonQuery();

            //Close Database
            conn.Close();
            MessageBox.Show("Success");
        }

        private void getListDoctors()
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
            String strSQL = "SELECT * FROM DOCTORS";

            cmd.CommandText = strSQL;

            OracleDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                lstDoctors.Items.Add(dr.GetValue(0).ToString().PadLeft(4, '0') + " " + dr.GetValue(2).ToString() + " " + dr.GetValue(3).ToString());
            }

            //Close Database
            conn.Close();
        }

        private void getListPatients()
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
            String strSQL = "SELECT PATIENT_ID, FORENAME, SURNAME, DOB FROM PATIENTS WHERE SURNAME LIKE '" + txtSurname.Text + "%'";

            cmd.CommandText = strSQL;

            OracleDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                lstPatients.Items.Add(dr.GetValue(0).ToString().PadLeft(4, '0') + " " + dr.GetValue(1).ToString() + " " + dr.GetValue(2).ToString());
            }

            //Close Database
            conn.Close();
        }

        private void getAvailableTimes()
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
            String strSQL = "SELECT APP_TIME FROM POSS_TIMES WHERE APP_TIME NOT IN (SELECT APP_TIME FROM APPOINTMENTS WHERE APP_DATE = '" + 
                                String.Format("{0:dd-MMM-yy}",dateTimePicker1.Value) + "' AND DOCTOR_ID = " + lstDoctors.Text.Substring(0, 4) + ")";

            cmd.CommandText = strSQL;

            OracleDataReader dr = cmd.ExecuteReader();

            lstAvailable.Items.Clear();
            while (dr.Read())
            {
                lstAvailable.Items.Add(dr.GetValue(0).ToString());
            }

            //Close Database
            conn.Close();
        }


        private void frmCreateAppointment_Load(object sender, EventArgs e)
        {
            getListDoctors();
        }

        private void btnSurnameGo_Click(object sender, EventArgs e)
        {
            grpPatients.Visible = true;
            getListPatients();
        }
        
    }
}
