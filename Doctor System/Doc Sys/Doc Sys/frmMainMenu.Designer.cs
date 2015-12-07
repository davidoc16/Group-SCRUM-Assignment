namespace Doc_Sys
{
    partial class frmMainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.picMain = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuPatients = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPatReg = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPatDeReg = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPatAmend = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPatList = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDoctors = new System.Windows.Forms.ToolStripMenuItem();
            this.registerDoctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deregisterDoctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAppointments = new System.Windows.Forms.ToolStripMenuItem();
            this.createAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorsScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkinPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFinance = new System.Windows.Forms.ToolStripMenuItem();
            this.recordPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueInvoicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRegPat = new System.Windows.Forms.Button();
            this.btnRecordPayment = new System.Windows.Forms.Button();
            this.btnRegDoc = new System.Windows.Forms.Button();
            this.btnCreateApp = new System.Windows.Forms.Button();
            this.btnCancelApp = new System.Windows.Forms.Button();
            this.btnCheckInPat = new System.Windows.Forms.Button();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.registerPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lblCalendar = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).BeginInit();
            this.mnuMain.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // picMain
            // 
            this.picMain.Image = ((System.Drawing.Image)(resources.GetObject("picMain.Image")));
            this.picMain.Location = new System.Drawing.Point(286, 91);
            this.picMain.Name = "picMain";
            this.picMain.Size = new System.Drawing.Size(556, 423);
            this.picMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMain.TabIndex = 0;
            this.picMain.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(895, 480);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 36);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPatients,
            this.mnuDoctors,
            this.mnuAppointments,
            this.mnuFinance,
            this.mnuExit});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(1100, 24);
            this.mnuMain.TabIndex = 2;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuPatients
            // 
            this.mnuPatients.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPatReg,
            this.mnuPatDeReg,
            this.mnuPatAmend,
            this.mnuPatList});
            this.mnuPatients.Name = "mnuPatients";
            this.mnuPatients.Size = new System.Drawing.Size(61, 20);
            this.mnuPatients.Text = "Patients";
            // 
            // mnuPatReg
            // 
            this.mnuPatReg.Name = "mnuPatReg";
            this.mnuPatReg.Size = new System.Drawing.Size(175, 22);
            this.mnuPatReg.Text = "Register Patient";
            this.mnuPatReg.Click += new System.EventHandler(this.mnuPatReg_Click);
            // 
            // mnuPatDeReg
            // 
            this.mnuPatDeReg.Name = "mnuPatDeReg";
            this.mnuPatDeReg.Size = new System.Drawing.Size(175, 22);
            this.mnuPatDeReg.Text = "De-Register Patient";
            this.mnuPatDeReg.Click += new System.EventHandler(this.mnuPatDeReg_Click);
            // 
            // mnuPatAmend
            // 
            this.mnuPatAmend.Name = "mnuPatAmend";
            this.mnuPatAmend.Size = new System.Drawing.Size(175, 22);
            this.mnuPatAmend.Text = "Amend Patient";
            this.mnuPatAmend.Click += new System.EventHandler(this.mnuPatAmend_Click);
            // 
            // mnuPatList
            // 
            this.mnuPatList.Name = "mnuPatList";
            this.mnuPatList.Size = new System.Drawing.Size(175, 22);
            this.mnuPatList.Text = "List Patients";
            this.mnuPatList.Click += new System.EventHandler(this.mnuPatList_Click);
            // 
            // mnuDoctors
            // 
            this.mnuDoctors.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerDoctorToolStripMenuItem,
            this.deregisterDoctorToolStripMenuItem});
            this.mnuDoctors.Name = "mnuDoctors";
            this.mnuDoctors.Size = new System.Drawing.Size(60, 20);
            this.mnuDoctors.Text = "Doctors";
            // 
            // registerDoctorToolStripMenuItem
            // 
            this.registerDoctorToolStripMenuItem.Name = "registerDoctorToolStripMenuItem";
            this.registerDoctorToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.registerDoctorToolStripMenuItem.Text = "Register Doctor";
            this.registerDoctorToolStripMenuItem.Click += new System.EventHandler(this.registerDoctorToolStripMenuItem_Click);
            // 
            // deregisterDoctorToolStripMenuItem
            // 
            this.deregisterDoctorToolStripMenuItem.Name = "deregisterDoctorToolStripMenuItem";
            this.deregisterDoctorToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.deregisterDoctorToolStripMenuItem.Text = "De-Register Doctor";
            this.deregisterDoctorToolStripMenuItem.Click += new System.EventHandler(this.deregisterDoctorToolStripMenuItem_Click);
            // 
            // mnuAppointments
            // 
            this.mnuAppointments.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createAppointmentToolStripMenuItem,
            this.cancelAppointmentToolStripMenuItem,
            this.doctorsScheduleToolStripMenuItem,
            this.checkinPatientToolStripMenuItem});
            this.mnuAppointments.Name = "mnuAppointments";
            this.mnuAppointments.Size = new System.Drawing.Size(95, 20);
            this.mnuAppointments.Text = "Appointments";
            // 
            // createAppointmentToolStripMenuItem
            // 
            this.createAppointmentToolStripMenuItem.Name = "createAppointmentToolStripMenuItem";
            this.createAppointmentToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.createAppointmentToolStripMenuItem.Text = "Create Appointment";
            this.createAppointmentToolStripMenuItem.Click += new System.EventHandler(this.createAppointmentToolStripMenuItem_Click);
            // 
            // cancelAppointmentToolStripMenuItem
            // 
            this.cancelAppointmentToolStripMenuItem.Name = "cancelAppointmentToolStripMenuItem";
            this.cancelAppointmentToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.cancelAppointmentToolStripMenuItem.Text = "Cancel Appointment";
            this.cancelAppointmentToolStripMenuItem.Click += new System.EventHandler(this.cancelAppointmentToolStripMenuItem_Click);
            // 
            // doctorsScheduleToolStripMenuItem
            // 
            this.doctorsScheduleToolStripMenuItem.Name = "doctorsScheduleToolStripMenuItem";
            this.doctorsScheduleToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.doctorsScheduleToolStripMenuItem.Text = "Doctor\'s Schedule";
            this.doctorsScheduleToolStripMenuItem.Click += new System.EventHandler(this.doctorsScheduleToolStripMenuItem_Click);
            // 
            // checkinPatientToolStripMenuItem
            // 
            this.checkinPatientToolStripMenuItem.Name = "checkinPatientToolStripMenuItem";
            this.checkinPatientToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.checkinPatientToolStripMenuItem.Text = "Check-in Patient";
            this.checkinPatientToolStripMenuItem.Click += new System.EventHandler(this.checkinPatientToolStripMenuItem_Click);
            // 
            // mnuFinance
            // 
            this.mnuFinance.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recordPaymentToolStripMenuItem,
            this.issueInvoicesToolStripMenuItem});
            this.mnuFinance.Name = "mnuFinance";
            this.mnuFinance.Size = new System.Drawing.Size(60, 20);
            this.mnuFinance.Text = "Finance";
            // 
            // recordPaymentToolStripMenuItem
            // 
            this.recordPaymentToolStripMenuItem.Name = "recordPaymentToolStripMenuItem";
            this.recordPaymentToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.recordPaymentToolStripMenuItem.Text = "Record Payment";
            this.recordPaymentToolStripMenuItem.Click += new System.EventHandler(this.recordPaymentToolStripMenuItem_Click);
            // 
            // issueInvoicesToolStripMenuItem
            // 
            this.issueInvoicesToolStripMenuItem.Name = "issueInvoicesToolStripMenuItem";
            this.issueInvoicesToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.issueInvoicesToolStripMenuItem.Text = "Issue Invoices";
            this.issueInvoicesToolStripMenuItem.Click += new System.EventHandler(this.issueInvoicesToolStripMenuItem_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(37, 20);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Levenim MT", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(332, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome to the Doctor Appointment System";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnRegPat);
            this.flowLayoutPanel1.Controls.Add(this.btnRegDoc);
            this.flowLayoutPanel1.Controls.Add(this.btnCreateApp);
            this.flowLayoutPanel1.Controls.Add(this.btnCancelApp);
            this.flowLayoutPanel1.Controls.Add(this.btnCheckInPat);
            this.flowLayoutPanel1.Controls.Add(this.btnRecordPayment);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(29, 112);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(242, 404);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // btnRegPat
            // 
            this.btnRegPat.Location = new System.Drawing.Point(3, 3);
            this.btnRegPat.Name = "btnRegPat";
            this.btnRegPat.Size = new System.Drawing.Size(239, 59);
            this.btnRegPat.TabIndex = 0;
            this.btnRegPat.Text = "Register New Patient";
            this.btnRegPat.UseVisualStyleBackColor = true;
            this.btnRegPat.Click += new System.EventHandler(this.btnRegPat_Click);
            // 
            // btnRecordPayment
            // 
            this.btnRecordPayment.Location = new System.Drawing.Point(3, 328);
            this.btnRecordPayment.Name = "btnRecordPayment";
            this.btnRecordPayment.Size = new System.Drawing.Size(239, 59);
            this.btnRecordPayment.TabIndex = 1;
            this.btnRecordPayment.Text = "Record Payment";
            this.btnRecordPayment.UseVisualStyleBackColor = true;
            this.btnRecordPayment.Click += new System.EventHandler(this.btnRecordPayment_Click);
            // 
            // btnRegDoc
            // 
            this.btnRegDoc.Location = new System.Drawing.Point(3, 68);
            this.btnRegDoc.Name = "btnRegDoc";
            this.btnRegDoc.Size = new System.Drawing.Size(239, 59);
            this.btnRegDoc.TabIndex = 2;
            this.btnRegDoc.Text = "Register New Doctor";
            this.btnRegDoc.UseVisualStyleBackColor = true;
            this.btnRegDoc.Click += new System.EventHandler(this.btnRegDoc_Click);
            // 
            // btnCreateApp
            // 
            this.btnCreateApp.Location = new System.Drawing.Point(3, 133);
            this.btnCreateApp.Name = "btnCreateApp";
            this.btnCreateApp.Size = new System.Drawing.Size(239, 59);
            this.btnCreateApp.TabIndex = 3;
            this.btnCreateApp.Text = "Create Appointment";
            this.btnCreateApp.UseVisualStyleBackColor = true;
            this.btnCreateApp.Click += new System.EventHandler(this.btnCreateApp_Click);
            // 
            // btnCancelApp
            // 
            this.btnCancelApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelApp.Location = new System.Drawing.Point(3, 198);
            this.btnCancelApp.Name = "btnCancelApp";
            this.btnCancelApp.Size = new System.Drawing.Size(239, 59);
            this.btnCancelApp.TabIndex = 4;
            this.btnCancelApp.Text = "Cancel Appointment";
            this.btnCancelApp.UseVisualStyleBackColor = true;
            this.btnCancelApp.Click += new System.EventHandler(this.btnCancelApp_Click);
            // 
            // btnCheckInPat
            // 
            this.btnCheckInPat.Location = new System.Drawing.Point(3, 263);
            this.btnCheckInPat.Name = "btnCheckInPat";
            this.btnCheckInPat.Size = new System.Drawing.Size(239, 59);
            this.btnCheckInPat.TabIndex = 5;
            this.btnCheckInPat.Text = "Check-In Patient";
            this.btnCheckInPat.UseVisualStyleBackColor = true;
            this.btnCheckInPat.Click += new System.EventHandler(this.btnCheckInPat_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerPatientToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(157, 26);
            // 
            // registerPatientToolStripMenuItem
            // 
            this.registerPatientToolStripMenuItem.Name = "registerPatientToolStripMenuItem";
            this.registerPatientToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.registerPatientToolStripMenuItem.Text = "Register Patient";
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(181, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Frequent Functions:";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(854, 115);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 9;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // lblCalendar
            // 
            this.lblCalendar.AutoSize = true;
            this.lblCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalendar.Location = new System.Drawing.Point(920, 91);
            this.lblCalendar.Name = "lblCalendar";
            this.lblCalendar.Size = new System.Drawing.Size(75, 18);
            this.lblCalendar.TabIndex = 10;
            this.lblCalendar.Text = "Calendar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 519);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "*: See Menu Bar on top for more options";
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1100, 550);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCalendar);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.picMain);
            this.Controls.Add(this.mnuMain);
            this.MainMenuStrip = this.mnuMain;
            this.Name = "frmMainMenu";
            this.Text = "Doc Sys - [Main Menu]";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).EndInit();
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picMain;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuPatients;
        private System.Windows.Forms.ToolStripMenuItem mnuDoctors;
        private System.Windows.Forms.ToolStripMenuItem mnuAppointments;
        private System.Windows.Forms.ToolStripMenuItem mnuFinance;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuPatReg;
        private System.Windows.Forms.ToolStripMenuItem mnuPatDeReg;
        private System.Windows.Forms.ToolStripMenuItem mnuPatAmend;
        private System.Windows.Forms.ToolStripMenuItem mnuPatList;
        private System.Windows.Forms.ToolStripMenuItem registerDoctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deregisterDoctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorsScheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkinPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordPaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueInvoicesToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnRegPat;
        private System.Windows.Forms.Button btnRecordPayment;
        private System.Windows.Forms.Button btnRegDoc;
        private System.Windows.Forms.Button btnCreateApp;
        private System.Windows.Forms.Button btnCancelApp;
        private System.Windows.Forms.Button btnCheckInPat;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem registerPatientToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lblCalendar;
        private System.Windows.Forms.Label label3;
    }
}

