using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace Doc_Sys
{
    public partial class frmRegDoc : Form
    {
        public frmRegDoc()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {

            grpAddress.Visible = true;

            Doctor newDoctor = new Doctor();

  
                //Convert text box data to int for validation
                int dateInt = 0;
                Int32.TryParse(dateTb.Text, out dateInt);
                int monthInt = 0;
                Int32.TryParse(monthTb.Text, out monthInt);
                //Create the Doctor using the Doctor class

                newDoctor.setGender(cboDocSex.Text);
                newDoctor.setForename(txtForename.Text);
                newDoctor.setSurname(txtSurname.Text);
                newDoctor.setStreet(txtStreet.Text);
                newDoctor.setTown(txtTown.Text);
                newDoctor.setCounty(cboCounty.Text);
                newDoctor.setDateofBirth(dateTb + "/" + monthTb + "/" + yearCbo);
                newDoctor.setGardaVetted(true);

                MessageBox.Show(newDoctor.getCounty());


        }

        private void btnExtRegDoc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            grpDoB.Visible = true;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmRegDoc_Load(object sender, EventArgs e)
        {

        }

        private void dateTb_Enter(object sender, EventArgs e)
        {
            dateTb.Text = "";
        }

        private void monthTb_Enter(object sender, EventArgs e)
        {
            monthTb.Text = "";
        }

        private void yearCbo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            grpAddress.Visible = true;
        }

        private void grpAddress_Enter(object sender, EventArgs e)
        {

        }

        private void gardavetCkb_CheckedChanged(object sender, EventArgs e)
        {
            if (gardavetCkb.Checked)
            {
                btnReg.Enabled = true;
            }
            else
                btnReg.Enabled = false;
        }

        private void cboCounty_SelectedIndexChanged(object sender, EventArgs e)
        {
            gardaGb.Visible = true;
        }

    
    }
}
