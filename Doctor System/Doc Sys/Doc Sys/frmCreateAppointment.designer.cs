namespace Doc_Sys
{
    partial class frmCreateAppointment
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDocId = new System.Windows.Forms.Label();
            this.lstDoctors = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpSurname = new System.Windows.Forms.GroupBox();
            this.btnSurnameGo = new System.Windows.Forms.Button();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grpPatients = new System.Windows.Forms.GroupBox();
            this.lstPatients = new System.Windows.Forms.ListBox();
            this.lblTown = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblPatId = new System.Windows.Forms.Label();
            this.grpApp = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lstAvailable = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCreateAppointment = new System.Windows.Forms.Button();
            this.grpSurname.SuspendLayout();
            this.grpPatients.SuspendLayout();
            this.grpApp.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create Appointment";
            // 
            // lblStreet
            // 
            this.lblStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreet.Location = new System.Drawing.Point(203, 70);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(58, 18);
            this.lblStreet.TabIndex = 49;
            this.lblStreet.Text = "Street:             ";
            this.lblStreet.Visible = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(80, 70);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 48;
            this.lblName.Text = "Name:";
            this.lblName.Visible = false;
            // 
            // lblDocId
            // 
            this.lblDocId.AutoSize = true;
            this.lblDocId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocId.Location = new System.Drawing.Point(8, 70);
            this.lblDocId.Name = "lblDocId";
            this.lblDocId.Size = new System.Drawing.Size(54, 13);
            this.lblDocId.TabIndex = 47;
            this.lblDocId.Text = "Doctor Id:";
            this.lblDocId.Visible = false;
            // 
            // lstDoctors
            // 
            this.lstDoctors.FormattingEnabled = true;
            this.lstDoctors.Location = new System.Drawing.Point(11, 91);
            this.lstDoctors.Name = "lstDoctors";
            this.lstDoctors.ScrollAlwaysVisible = true;
            this.lstDoctors.Size = new System.Drawing.Size(433, 82);
            this.lstDoctors.Sorted = true;
            this.lstDoctors.TabIndex = 46;
            this.lstDoctors.SelectedIndexChanged += new System.EventHandler(this.lstDoctors_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 18);
            this.label2.TabIndex = 51;
            this.label2.Text = "List of available Doctors:";
            // 
            // grpSurname
            // 
            this.grpSurname.Controls.Add(this.btnSurnameGo);
            this.grpSurname.Controls.Add(this.txtSurname);
            this.grpSurname.Controls.Add(this.label6);
            this.grpSurname.Location = new System.Drawing.Point(13, 179);
            this.grpSurname.Name = "grpSurname";
            this.grpSurname.Size = new System.Drawing.Size(465, 37);
            this.grpSurname.TabIndex = 62;
            this.grpSurname.TabStop = false;
            this.grpSurname.Visible = false;
            // 
            // btnSurnameGo
            // 
            this.btnSurnameGo.Location = new System.Drawing.Point(336, 13);
            this.btnSurnameGo.Name = "btnSurnameGo";
            this.btnSurnameGo.Size = new System.Drawing.Size(75, 23);
            this.btnSurnameGo.TabIndex = 65;
            this.btnSurnameGo.Text = "Select";
            this.btnSurnameGo.UseVisualStyleBackColor = true;
            this.btnSurnameGo.Click += new System.EventHandler(this.btnSurnameGo_Click);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(144, 13);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(170, 20);
            this.txtSurname.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Enter Patient Surname:";
            // 
            // grpPatients
            // 
            this.grpPatients.Controls.Add(this.lstPatients);
            this.grpPatients.Controls.Add(this.lblTown);
            this.grpPatients.Controls.Add(this.label8);
            this.grpPatients.Controls.Add(this.label9);
            this.grpPatients.Controls.Add(this.lblPatId);
            this.grpPatients.Location = new System.Drawing.Point(15, 231);
            this.grpPatients.Name = "grpPatients";
            this.grpPatients.Size = new System.Drawing.Size(463, 157);
            this.grpPatients.TabIndex = 71;
            this.grpPatients.TabStop = false;
            this.grpPatients.Text = "SELECT PATIENT";
            this.grpPatients.Visible = false;
            // 
            // lstPatients
            // 
            this.lstPatients.FormattingEnabled = true;
            this.lstPatients.Location = new System.Drawing.Point(25, 67);
            this.lstPatients.Name = "lstPatients";
            this.lstPatients.Size = new System.Drawing.Size(412, 69);
            this.lstPatients.TabIndex = 75;
            this.lstPatients.SelectedIndexChanged += new System.EventHandler(this.lstPatients_SelectedIndexChanged);
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTown.Location = new System.Drawing.Point(364, 46);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(44, 18);
            this.lblTown.TabIndex = 74;
            this.lblTown.Text = "DOB";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(218, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 18);
            this.label8.TabIndex = 73;
            this.label8.Text = "Street:             ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(121, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 18);
            this.label9.TabIndex = 72;
            this.label9.Text = "Name:";
            // 
            // lblPatId
            // 
            this.lblPatId.AutoSize = true;
            this.lblPatId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatId.Location = new System.Drawing.Point(25, 46);
            this.lblPatId.Name = "lblPatId";
            this.lblPatId.Size = new System.Drawing.Size(78, 18);
            this.lblPatId.TabIndex = 71;
            this.lblPatId.Text = "PatientId:";
            // 
            // grpApp
            // 
            this.grpApp.Controls.Add(this.label3);
            this.grpApp.Controls.Add(this.lstAvailable);
            this.grpApp.Controls.Add(this.dateTimePicker1);
            this.grpApp.Location = new System.Drawing.Point(15, 394);
            this.grpApp.Name = "grpApp";
            this.grpApp.Size = new System.Drawing.Size(455, 113);
            this.grpApp.TabIndex = 72;
            this.grpApp.TabStop = false;
            this.grpApp.Text = "Enter Appointment Date/Time";
            this.grpApp.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Available times:";
            // 
            // lstAvailable
            // 
            this.lstAvailable.FormattingEnabled = true;
            this.lstAvailable.Location = new System.Drawing.Point(198, 31);
            this.lstAvailable.Name = "lstAvailable";
            this.lstAvailable.Size = new System.Drawing.Size(231, 69);
            this.lstAvailable.TabIndex = 55;
            this.lstAvailable.Visible = false;
            this.lstAvailable.SelectedIndexChanged += new System.EventHandler(this.lstAvailable_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(7, 19);
            this.dateTimePicker1.MinDate = new System.DateTime(2014, 12, 7, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(132, 20);
            this.dateTimePicker1.TabIndex = 54;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(378, 602);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(121, 35);
            this.btnExit.TabIndex = 73;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCreateAppointment
            // 
            this.btnCreateAppointment.Location = new System.Drawing.Point(236, 602);
            this.btnCreateAppointment.Name = "btnCreateAppointment";
            this.btnCreateAppointment.Size = new System.Drawing.Size(121, 35);
            this.btnCreateAppointment.TabIndex = 74;
            this.btnCreateAppointment.Text = "Create Appointment";
            this.btnCreateAppointment.UseVisualStyleBackColor = true;
            this.btnCreateAppointment.Click += new System.EventHandler(this.btnCreateAppointmnet_Click);
            // 
            // frmCreateAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(511, 649);
            this.Controls.Add(this.btnCreateAppointment);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpApp);
            this.Controls.Add(this.grpPatients);
            this.Controls.Add(this.grpSurname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblStreet);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblDocId);
            this.Controls.Add(this.lstDoctors);
            this.Controls.Add(this.label1);
            this.Name = "frmCreateAppointment";
            this.Text = "frmCreateAppointment";
            this.Load += new System.EventHandler(this.frmCreateAppointment_Load);
            this.grpSurname.ResumeLayout(false);
            this.grpSurname.PerformLayout();
            this.grpPatients.ResumeLayout(false);
            this.grpPatients.PerformLayout();
            this.grpApp.ResumeLayout(false);
            this.grpApp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDocId;
        private System.Windows.Forms.ListBox lstDoctors;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpSurname;
        private System.Windows.Forms.Button btnSurnameGo;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpPatients;
        private System.Windows.Forms.ListBox lstPatients;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblPatId;
        private System.Windows.Forms.GroupBox grpApp;
        private System.Windows.Forms.ListBox lstAvailable;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCreateAppointment;
    }
}