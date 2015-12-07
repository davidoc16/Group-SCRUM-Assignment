namespace Doc_Sys
{
    partial class frmRegPat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegPat));
            this.cboPatSex = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.lblForename = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.btnReg = new System.Windows.Forms.Button();
            this.btnExtRegPat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dateDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.cboCounty = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpName = new System.Windows.Forms.GroupBox();
            this.grpAddress = new System.Windows.Forms.GroupBox();
            this.grpDoB = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpName.SuspendLayout();
            this.grpAddress.SuspendLayout();
            this.grpDoB.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboPatSex
            // 
            this.cboPatSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPatSex.FormattingEnabled = true;
            this.cboPatSex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cboPatSex.Location = new System.Drawing.Point(152, 124);
            this.cboPatSex.Name = "cboPatSex";
            this.cboPatSex.Size = new System.Drawing.Size(101, 21);
            this.cboPatSex.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sex:";
            // 
            // txtForename
            // 
            this.txtForename.Location = new System.Drawing.Point(128, 24);
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(231, 20);
            this.txtForename.TabIndex = 1;
            this.txtForename.TextChanged += new System.EventHandler(this.txtForename_TextChanged);
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForename.Location = new System.Drawing.Point(38, 26);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(80, 18);
            this.lblForename.TabIndex = 3;
            this.lblForename.Text = "Forename:";
            this.lblForename.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(46, 56);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(72, 18);
            this.lblSurname.TabIndex = 4;
            this.lblSurname.Text = "Surname:";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(128, 56);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(231, 20);
            this.txtSurname.TabIndex = 2;
            this.txtSurname.TextChanged += new System.EventHandler(this.txtSurname_TextChanged);
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(139, 474);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(89, 40);
            this.btnReg.TabIndex = 7;
            this.btnReg.Text = "Register";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Visible = false;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // btnExtRegPat
            // 
            this.btnExtRegPat.Location = new System.Drawing.Point(525, 474);
            this.btnExtRegPat.Name = "btnExtRegPat";
            this.btnExtRegPat.Size = new System.Drawing.Size(89, 40);
            this.btnExtRegPat.TabIndex = 8;
            this.btnExtRegPat.Text = "Exit";
            this.btnExtRegPat.UseVisualStyleBackColor = true;
            this.btnExtRegPat.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Date Of Birth:";
            // 
            // dateDateOfBirth
            // 
            this.dateDateOfBirth.Location = new System.Drawing.Point(109, 16);
            this.dateDateOfBirth.MaxDate = new System.DateTime(2014, 12, 7, 0, 0, 0, 0);
            this.dateDateOfBirth.Name = "dateDateOfBirth";
            this.dateDateOfBirth.Size = new System.Drawing.Size(231, 20);
            this.dateDateOfBirth.TabIndex = 6;
            this.dateDateOfBirth.Value = new System.DateTime(2014, 12, 7, 0, 0, 0, 0);
            this.dateDateOfBirth.ValueChanged += new System.EventHandler(this.dateDateOfBirth_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(60, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 18);
            this.label6.TabIndex = 22;
            this.label6.Text = "Street:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(62, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 18);
            this.label7.TabIndex = 23;
            this.label7.Text = "Town:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(52, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 18);
            this.label8.TabIndex = 24;
            this.label8.Text = "County:";
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(117, 41);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(234, 20);
            this.txtStreet.TabIndex = 3;
            this.txtStreet.TextChanged += new System.EventHandler(this.txtStreet_TextChanged);
            // 
            // txtTown
            // 
            this.txtTown.Location = new System.Drawing.Point(117, 71);
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(234, 20);
            this.txtTown.TabIndex = 4;
            // 
            // cboCounty
            // 
            this.cboCounty.FormattingEnabled = true;
            this.cboCounty.Items.AddRange(new object[] {
            "Cork",
            "Kerry",
            "Limerick"});
            this.cboCounty.Location = new System.Drawing.Point(117, 99);
            this.cboCounty.MaxDropDownItems = 32;
            this.cboCounty.Name = "cboCounty";
            this.cboCounty.Size = new System.Drawing.Size(234, 21);
            this.cboCounty.TabIndex = 5;
            this.cboCounty.SelectedIndexChanged += new System.EventHandler(this.cboCounty_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft New Tai Lue", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(179, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(315, 42);
            this.label4.TabIndex = 29;
            this.label4.Text = "Register New Patient";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(447, 251);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 201);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // grpName
            // 
            this.grpName.Controls.Add(this.lblForename);
            this.grpName.Controls.Add(this.txtForename);
            this.grpName.Controls.Add(this.lblSurname);
            this.grpName.Controls.Add(this.txtSurname);
            this.grpName.Location = new System.Drawing.Point(28, 151);
            this.grpName.Name = "grpName";
            this.grpName.Size = new System.Drawing.Size(412, 89);
            this.grpName.TabIndex = 31;
            this.grpName.TabStop = false;
            this.grpName.Text = "Name:";
            // 
            // grpAddress
            // 
            this.grpAddress.Controls.Add(this.label6);
            this.grpAddress.Controls.Add(this.label7);
            this.grpAddress.Controls.Add(this.label8);
            this.grpAddress.Controls.Add(this.cboCounty);
            this.grpAddress.Controls.Add(this.txtStreet);
            this.grpAddress.Controls.Add(this.txtTown);
            this.grpAddress.Location = new System.Drawing.Point(30, 257);
            this.grpAddress.Name = "grpAddress";
            this.grpAddress.Size = new System.Drawing.Size(410, 142);
            this.grpAddress.TabIndex = 32;
            this.grpAddress.TabStop = false;
            this.grpAddress.Text = "Address:";
            this.grpAddress.Visible = false;
            // 
            // grpDoB
            // 
            this.grpDoB.Controls.Add(this.label3);
            this.grpDoB.Controls.Add(this.dateDateOfBirth);
            this.grpDoB.Location = new System.Drawing.Point(30, 405);
            this.grpDoB.Name = "grpDoB";
            this.grpDoB.Size = new System.Drawing.Size(411, 47);
            this.grpDoB.TabIndex = 33;
            this.grpDoB.TabStop = false;
            this.grpDoB.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(507, 517);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "*without registering a patient";
            // 
            // frmRegPat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(708, 548);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grpDoB);
            this.Controls.Add(this.grpAddress);
            this.Controls.Add(this.grpName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnExtRegPat);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboPatSex);
            this.Name = "frmRegPat";
            this.Text = "Register Patient";
            this.Load += new System.EventHandler(this.frmRegPat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpName.ResumeLayout(false);
            this.grpName.PerformLayout();
            this.grpAddress.ResumeLayout(false);
            this.grpAddress.PerformLayout();
            this.grpDoB.ResumeLayout(false);
            this.grpDoB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboPatSex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Button btnExtRegPat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateDateOfBirth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.ComboBox cboCounty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpName;
        private System.Windows.Forms.GroupBox grpAddress;
        private System.Windows.Forms.GroupBox grpDoB;
        private System.Windows.Forms.Label label2;
    }
}