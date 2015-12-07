using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Version 0.1
 */
namespace Doc_Sys
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Terminate Application
            System.Environment.Exit(1);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void recordPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mnuPatReg_Click(object sender, EventArgs e)
        {
            frmRegPat registerPatient = new frmRegPat();
            registerPatient.Show();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void mnuPatList_Click(object sender, EventArgs e)
        {

            
        }

        private void mnuPatDeReg_Click(object sender, EventArgs e)
        {

        }

        private void mnuPatAmend_Click(object sender, EventArgs e)
        {

        }

        private void registerDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegDoc regDoc = new frmRegDoc();
            regDoc.Show();
        }

        private void deregisterDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void createAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cancelAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void doctorsScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void checkinPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void issueInvoicesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnRegPat_Click(object sender, EventArgs e)
        {
            frmRegPat registerPatient = new frmRegPat();
            registerPatient.Show();
        }

        private void btnRegDoc_Click(object sender, EventArgs e)
        {
            frmRegDoc regDoc = new frmRegDoc();
            regDoc.Show();
        }

        private void btnCreateApp_Click(object sender, EventArgs e)
        {
            frmCreateAppointment regDoc = new frmCreateAppointment();
            regDoc.Show();
        }

        private void btnCancelApp_Click(object sender, EventArgs e)
        {

        }

        private void btnCheckInPat_Click(object sender, EventArgs e)
        {

        }

        private void btnRecordPayment_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DialogResult answer = MessageBox.Show("Would you like to create an appointment for this Date? ", 
                "Create Appointment?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (answer.Equals(DialogResult.OK))
            {

            }
        }
    }
}
