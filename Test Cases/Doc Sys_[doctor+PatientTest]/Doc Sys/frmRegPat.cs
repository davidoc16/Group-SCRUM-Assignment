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
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            Patient newPatient = new Patient();



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
                MessageBox.Show("Sex must be entered");
                cboPatSex.Focus();
            }

               

        
            // Save the Data in the Patient File

            else
            {
                newPatient.setGender(cboPatSex.Text);
                newPatient.setForename(txtForename.Text);
                newPatient.setSurname(txtSurname.Text);
                newPatient.setStreet(txtStreet.Text);
                newPatient.setTown(txtTown.Text);
                newPatient.setCounty(cboCounty.Text);
                //newPatient.setDateofBirth(dateTb + "/" + monthTb + "/" + yearCbo);
                
                MessageBox.Show("Patient Registered");


                //Clear the form
                cboPatSex.Text = null;
                txtForename.Text = "";
                txtSurname.Text = "";
                txtTown.Text = "";
                cboCounty.Text = null;
                txtStreet.Text = "";
                dateDateOfBirth.Text = "";

                btnReg.Visible = false;
                grpDoB.Visible = false;
                grpAddress.Visible = false;


                // Display confirmation Message
                MessageBox.Show(newPatient.getCounty());
            }
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
            grpDoB.Visible = true;
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            grpAddress.Visible = true;

        }

        private void dateDateOfBirth_ValueChanged(object sender, EventArgs e)
        {
            btnReg.Visible = true;
        }

        private void txtForename_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
