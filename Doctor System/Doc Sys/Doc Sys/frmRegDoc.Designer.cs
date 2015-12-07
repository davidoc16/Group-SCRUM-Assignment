namespace Doc_Sys
{
    partial class frmRegDoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegDoc));
            this.cboCounty = new System.Windows.Forms.ComboBox();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDocID = new System.Windows.Forms.Label();
            this.txtDocId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExtRegDoc = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblForename = new System.Windows.Forms.Label();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboDocSex = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grpName = new System.Windows.Forms.GroupBox();
            this.grpAddress = new System.Windows.Forms.GroupBox();
            this.grpDoB = new System.Windows.Forms.GroupBox();
            this.yearCbo = new System.Windows.Forms.ComboBox();
            this.monthTb = new System.Windows.Forms.TextBox();
            this.dateTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gardaGb = new System.Windows.Forms.GroupBox();
            this.gardavetCkb = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpName.SuspendLayout();
            this.grpAddress.SuspendLayout();
            this.grpDoB.SuspendLayout();
            this.gardaGb.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboCounty
            // 
            this.cboCounty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCounty.FormattingEnabled = true;
            this.cboCounty.Items.AddRange(new object[] {
            "Cork",
            "Kerry",
            "Limerick"});
            this.cboCounty.Location = new System.Drawing.Point(128, 89);
            this.cboCounty.MaxDropDownItems = 32;
            this.cboCounty.Name = "cboCounty";
            this.cboCounty.Size = new System.Drawing.Size(234, 21);
            this.cboCounty.TabIndex = 52;
            this.cboCounty.SelectedIndexChanged += new System.EventHandler(this.cboCounty_SelectedIndexChanged);
            // 
            // txtTown
            // 
            this.txtTown.Location = new System.Drawing.Point(128, 61);
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(234, 20);
            this.txtTown.TabIndex = 50;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(128, 31);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(234, 20);
            this.txtStreet.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(63, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 18);
            this.label8.TabIndex = 62;
            this.label8.Text = "County:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(73, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 18);
            this.label7.TabIndex = 61;
            this.label7.Text = "Town:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(71, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 18);
            this.label6.TabIndex = 60;
            this.label6.Text = "Street:";
            // 
            // lblDocID
            // 
            this.lblDocID.AutoSize = true;
            this.lblDocID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocID.Location = new System.Drawing.Point(185, 57);
            this.lblDocID.Name = "lblDocID";
            this.lblDocID.Size = new System.Drawing.Size(96, 25);
            this.lblDocID.TabIndex = 59;
            this.lblDocID.Text = "Doctor Id:";
            // 
            // txtDocId
            // 
            this.txtDocId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocId.Location = new System.Drawing.Point(290, 54);
            this.txtDocId.Name = "txtDocId";
            this.txtDocId.ReadOnly = true;
            this.txtDocId.Size = new System.Drawing.Size(113, 30);
            this.txtDocId.TabIndex = 58;
            this.txtDocId.Text = "1001";
            this.txtDocId.TextChanged += new System.EventHandler(this.txtDocId_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 18);
            this.label3.TabIndex = 57;
            this.label3.Text = "Date Of Birth:";
            // 
            // btnExtRegDoc
            // 
            this.btnExtRegDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtRegDoc.Location = new System.Drawing.Point(254, 596);
            this.btnExtRegDoc.Name = "btnExtRegDoc";
            this.btnExtRegDoc.Size = new System.Drawing.Size(89, 40);
            this.btnExtRegDoc.TabIndex = 56;
            this.btnExtRegDoc.Text = "Cancel";
            this.btnExtRegDoc.UseVisualStyleBackColor = true;
            this.btnExtRegDoc.Click += new System.EventHandler(this.btnExtRegDoc_Click);
            // 
            // btnReg
            // 
            this.btnReg.Enabled = false;
            this.btnReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReg.Location = new System.Drawing.Point(112, 596);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(89, 40);
            this.btnReg.TabIndex = 54;
            this.btnReg.Text = "Register";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(131, 61);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(231, 20);
            this.txtSurname.TabIndex = 47;
            this.txtSurname.TextChanged += new System.EventHandler(this.txtSurname_TextChanged);
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(49, 61);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(72, 18);
            this.lblSurname.TabIndex = 51;
            this.lblSurname.Text = "Surname:";
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForename.Location = new System.Drawing.Point(41, 31);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(80, 18);
            this.lblForename.TabIndex = 49;
            this.lblForename.Text = "Forename:";
            // 
            // txtForename
            // 
            this.txtForename.Location = new System.Drawing.Point(131, 29);
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(231, 20);
            this.txtForename.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 46;
            this.label1.Text = "Gender:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cboDocSex
            // 
            this.cboDocSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDocSex.FormattingEnabled = true;
            this.cboDocSex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cboDocSex.Location = new System.Drawing.Point(118, 99);
            this.cboDocSex.Name = "cboDocSex";
            this.cboDocSex.Size = new System.Drawing.Size(116, 21);
            this.cboDocSex.TabIndex = 44;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(464, 370);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 201);
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft New Tai Lue", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(146, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(313, 42);
            this.label4.TabIndex = 64;
            this.label4.Text = "Register New Doctor";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // grpName
            // 
            this.grpName.Controls.Add(this.txtForename);
            this.grpName.Controls.Add(this.lblForename);
            this.grpName.Controls.Add(this.lblSurname);
            this.grpName.Controls.Add(this.txtSurname);
            this.grpName.Location = new System.Drawing.Point(22, 122);
            this.grpName.Name = "grpName";
            this.grpName.Size = new System.Drawing.Size(381, 97);
            this.grpName.TabIndex = 65;
            this.grpName.TabStop = false;
            this.grpName.Text = "Name";
            // 
            // grpAddress
            // 
            this.grpAddress.Controls.Add(this.txtStreet);
            this.grpAddress.Controls.Add(this.label6);
            this.grpAddress.Controls.Add(this.label7);
            this.grpAddress.Controls.Add(this.label8);
            this.grpAddress.Controls.Add(this.cboCounty);
            this.grpAddress.Controls.Add(this.txtTown);
            this.grpAddress.Location = new System.Drawing.Point(22, 270);
            this.grpAddress.Name = "grpAddress";
            this.grpAddress.Size = new System.Drawing.Size(378, 125);
            this.grpAddress.TabIndex = 66;
            this.grpAddress.TabStop = false;
            this.grpAddress.Text = "Address";
            this.grpAddress.Visible = false;
            this.grpAddress.Enter += new System.EventHandler(this.grpAddress_Enter);
            // 
            // grpDoB
            // 
            this.grpDoB.Controls.Add(this.yearCbo);
            this.grpDoB.Controls.Add(this.monthTb);
            this.grpDoB.Controls.Add(this.dateTb);
            this.grpDoB.Controls.Add(this.label3);
            this.grpDoB.Location = new System.Drawing.Point(22, 225);
            this.grpDoB.Name = "grpDoB";
            this.grpDoB.Size = new System.Drawing.Size(381, 39);
            this.grpDoB.TabIndex = 67;
            this.grpDoB.TabStop = false;
            this.grpDoB.Visible = false;
            // 
            // yearCbo
            // 
            this.yearCbo.DropDownHeight = 100;
            this.yearCbo.FormattingEnabled = true;
            this.yearCbo.IntegralHeight = false;
            this.yearCbo.Items.AddRange(new object[] {
            "1990",
            "1989",
            "1988",
            "1987",
            "1986",
            "1985",
            "1984",
            "1983",
            "1982",
            "1981",
            "1980",
            "1979",
            "1978",
            "1977",
            "1976",
            " 1975",
            "1974",
            "1973",
            "1972 ",
            "1971",
            "1970"});
            this.yearCbo.Location = new System.Drawing.Point(249, 11);
            this.yearCbo.Name = "yearCbo";
            this.yearCbo.Size = new System.Drawing.Size(72, 21);
            this.yearCbo.TabIndex = 60;
            this.yearCbo.SelectionChangeCommitted += new System.EventHandler(this.yearCbo_SelectionChangeCommitted);
            // 
            // monthTb
            // 
            this.monthTb.Location = new System.Drawing.Point(187, 12);
            this.monthTb.Name = "monthTb";
            this.monthTb.Size = new System.Drawing.Size(34, 20);
            this.monthTb.TabIndex = 59;
            this.monthTb.Text = "MM";
            this.monthTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.monthTb.Enter += new System.EventHandler(this.monthTb_Enter);
            // 
            // dateTb
            // 
            this.dateTb.Location = new System.Drawing.Point(131, 12);
            this.dateTb.Name = "dateTb";
            this.dateTb.Size = new System.Drawing.Size(34, 20);
            this.dateTb.TabIndex = 58;
            this.dateTb.Text = "DD";
            this.dateTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dateTb.Enter += new System.EventHandler(this.dateTb_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 18);
            this.label2.TabIndex = 68;
            this.label2.Text = "Is this person Garda Vetted?";
            // 
            // gardaGb
            // 
            this.gardaGb.Controls.Add(this.gardavetCkb);
            this.gardaGb.Controls.Add(this.label2);
            this.gardaGb.Location = new System.Drawing.Point(22, 420);
            this.gardaGb.Name = "gardaGb";
            this.gardaGb.Size = new System.Drawing.Size(376, 48);
            this.gardaGb.TabIndex = 69;
            this.gardaGb.TabStop = false;
            this.gardaGb.Visible = false;
            // 
            // gardavetCkb
            // 
            this.gardavetCkb.AutoSize = true;
            this.gardavetCkb.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gardavetCkb.Location = new System.Drawing.Point(232, 19);
            this.gardavetCkb.Name = "gardavetCkb";
            this.gardavetCkb.Size = new System.Drawing.Size(15, 14);
            this.gardavetCkb.TabIndex = 69;
            this.gardavetCkb.UseVisualStyleBackColor = true;
            this.gardavetCkb.CheckedChanged += new System.EventHandler(this.gardavetCkb_CheckedChanged);
            // 
            // frmRegDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(744, 648);
            this.Controls.Add(this.gardaGb);
            this.Controls.Add(this.grpDoB);
            this.Controls.Add(this.grpAddress);
            this.Controls.Add(this.grpName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblDocID);
            this.Controls.Add(this.txtDocId);
            this.Controls.Add(this.btnExtRegDoc);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboDocSex);
            this.Name = "frmRegDoc";
            this.Text = "frmRegDoc";
            this.Load += new System.EventHandler(this.frmRegDoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpName.ResumeLayout(false);
            this.grpName.PerformLayout();
            this.grpAddress.ResumeLayout(false);
            this.grpAddress.PerformLayout();
            this.grpDoB.ResumeLayout(false);
            this.grpDoB.PerformLayout();
            this.gardaGb.ResumeLayout(false);
            this.gardaGb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCounty;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDocID;
        private System.Windows.Forms.TextBox txtDocId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExtRegDoc;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboDocSex;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpName;
        private System.Windows.Forms.GroupBox grpAddress;
        private System.Windows.Forms.GroupBox grpDoB;
        private System.Windows.Forms.ComboBox yearCbo;
        private System.Windows.Forms.TextBox monthTb;
        private System.Windows.Forms.TextBox dateTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gardaGb;
        private System.Windows.Forms.CheckBox gardavetCkb;
    }
}