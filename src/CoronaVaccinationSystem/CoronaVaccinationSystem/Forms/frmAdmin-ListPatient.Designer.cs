namespace CoronaVaccinationSystem
{
    partial class frmAdmin_ListPatient
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.pictureBoxLogout = new System.Windows.Forms.PictureBox();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.panelRight = new System.Windows.Forms.Panel();
            this.pictureBoxPatient = new System.Windows.Forms.PictureBox();
            this.pictureBoxList = new System.Windows.Forms.PictureBox();
            this.btnPatient = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.panelPictureBox = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.dgvPatients = new System.Windows.Forms.DataGridView();
            this.NameOfPatient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FamilyOfPatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDateOfPatient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPatient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxList)).BeginInit();
            this.panelPictureBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Green;
            this.panelTop.Controls.Add(this.lblAdmin);
            this.panelTop.Controls.Add(this.pictureBoxLogout);
            this.panelTop.Controls.Add(this.pictureBoxExit);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(730, 43);
            this.panelTop.TabIndex = 0;
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAdmin.Font = new System.Drawing.Font("IranNastaliq", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblAdmin.Location = new System.Drawing.Point(335, 1);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAdmin.Size = new System.Drawing.Size(61, 41);
            this.lblAdmin.TabIndex = 5;
            this.lblAdmin.Text = "ادمین سیستم";
            // 
            // pictureBoxLogout
            // 
            this.pictureBoxLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxLogout.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxLogout.Image = global::CoronaVaccinationSystem.Properties.Resources.swipe_left;
            this.pictureBoxLogout.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogout.Name = "pictureBoxLogout";
            this.pictureBoxLogout.Size = new System.Drawing.Size(39, 43);
            this.pictureBoxLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogout.TabIndex = 9;
            this.pictureBoxLogout.TabStop = false;
            this.pictureBoxLogout.Click += new System.EventHandler(this.PictureBoxLogout_Click);
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxExit.Image = global::CoronaVaccinationSystem.Properties.Resources.power_button;
            this.pictureBoxExit.Location = new System.Drawing.Point(693, 0);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(37, 43);
            this.pictureBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxExit.TabIndex = 8;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.Click += new System.EventHandler(this.PictureBoxExit_Click);
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.Green;
            this.panelRight.Controls.Add(this.pictureBoxPatient);
            this.panelRight.Controls.Add(this.pictureBoxList);
            this.panelRight.Controls.Add(this.btnPatient);
            this.panelRight.Controls.Add(this.btnList);
            this.panelRight.Controls.Add(this.panelPictureBox);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(586, 43);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(144, 354);
            this.panelRight.TabIndex = 1;
            // 
            // pictureBoxPatient
            // 
            this.pictureBoxPatient.BackColor = System.Drawing.Color.ForestGreen;
            this.pictureBoxPatient.Image = global::CoronaVaccinationSystem.Properties.Resources.medical;
            this.pictureBoxPatient.Location = new System.Drawing.Point(116, 229);
            this.pictureBoxPatient.Name = "pictureBoxPatient";
            this.pictureBoxPatient.Size = new System.Drawing.Size(28, 49);
            this.pictureBoxPatient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPatient.TabIndex = 3;
            this.pictureBoxPatient.TabStop = false;
            // 
            // pictureBoxList
            // 
            this.pictureBoxList.BackColor = System.Drawing.Color.DarkGreen;
            this.pictureBoxList.Image = global::CoronaVaccinationSystem.Properties.Resources.medical_records__1_;
            this.pictureBoxList.Location = new System.Drawing.Point(116, 173);
            this.pictureBoxList.Name = "pictureBoxList";
            this.pictureBoxList.Size = new System.Drawing.Size(28, 49);
            this.pictureBoxList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxList.TabIndex = 2;
            this.pictureBoxList.TabStop = false;
            // 
            // btnPatient
            // 
            this.btnPatient.BackColor = System.Drawing.Color.ForestGreen;
            this.btnPatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPatient.FlatAppearance.BorderSize = 0;
            this.btnPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatient.Font = new System.Drawing.Font("IranNastaliq", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnPatient.Location = new System.Drawing.Point(0, 228);
            this.btnPatient.Name = "btnPatient";
            this.btnPatient.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnPatient.Size = new System.Drawing.Size(144, 50);
            this.btnPatient.TabIndex = 2;
            this.btnPatient.Text = "بیمار جدید";
            this.btnPatient.UseVisualStyleBackColor = false;
            this.btnPatient.Click += new System.EventHandler(this.BtnPatient_Click);
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.DarkGreen;
            this.btnList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnList.FlatAppearance.BorderSize = 0;
            this.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnList.Font = new System.Drawing.Font("IranNastaliq", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnList.Location = new System.Drawing.Point(0, 172);
            this.btnList.Name = "btnList";
            this.btnList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnList.Size = new System.Drawing.Size(144, 50);
            this.btnList.TabIndex = 1;
            this.btnList.Text = "لیست بیماران";
            this.btnList.UseVisualStyleBackColor = false;
            // 
            // panelPictureBox
            // 
            this.panelPictureBox.Controls.Add(this.pictureBoxLogo);
            this.panelPictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPictureBox.Location = new System.Drawing.Point(0, 0);
            this.panelPictureBox.Name = "panelPictureBox";
            this.panelPictureBox.Size = new System.Drawing.Size(144, 148);
            this.panelPictureBox.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxLogo.Image = global::CoronaVaccinationSystem.Properties.Resources.لوگو_وزارت_بهداشت_2__3_;
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(144, 148);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.btnDelete);
            this.panelLeft.Controls.Add(this.btnEdit);
            this.panelLeft.Controls.Add(this.txtSearch);
            this.panelLeft.Controls.Add(this.lblSearch);
            this.panelLeft.Controls.Add(this.dgvPatients);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.Location = new System.Drawing.Point(0, 43);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(586, 354);
            this.panelLeft.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnDelete.Location = new System.Drawing.Point(145, 304);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnDelete.Size = new System.Drawing.Size(96, 38);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Green;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnEdit.Location = new System.Drawing.Point(35, 304);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnEdit.Size = new System.Drawing.Size(96, 38);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "ویرایش";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtSearch.Location = new System.Drawing.Point(258, 313);
            this.txtSearch.MaxLength = 10;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(151, 28);
            this.txtSearch.TabIndex = 11;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("IranNastaliq", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblSearch.Location = new System.Drawing.Point(415, 304);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSearch.Size = new System.Drawing.Size(124, 41);
            this.lblSearch.TabIndex = 10;
            this.lblSearch.Text = "کدملی مورد نظر را وارد کنید:";
            // 
            // dgvPatients
            // 
            this.dgvPatients.AllowUserToAddRows = false;
            this.dgvPatients.AllowUserToDeleteRows = false;
            this.dgvPatients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPatients.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvPatients.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameOfPatient,
            this.FamilyOfPatientName,
            this.PatientId,
            this.PatientPhoneNumber,
            this.BirthDateOfPatient});
            this.dgvPatients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvPatients.Location = new System.Drawing.Point(9, 10);
            this.dgvPatients.Name = "dgvPatients";
            this.dgvPatients.ReadOnly = true;
            this.dgvPatients.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvPatients.Size = new System.Drawing.Size(569, 278);
            this.dgvPatients.TabIndex = 9;
            // 
            // NameOfPatient
            // 
            this.NameOfPatient.DataPropertyName = "Name";
            this.NameOfPatient.HeaderText = "نام";
            this.NameOfPatient.Name = "NameOfPatient";
            this.NameOfPatient.ReadOnly = true;
            this.NameOfPatient.Width = 95;
            // 
            // FamilyOfPatientName
            // 
            this.FamilyOfPatientName.DataPropertyName = "LastName";
            this.FamilyOfPatientName.HeaderText = "نام خانوادگی";
            this.FamilyOfPatientName.Name = "FamilyOfPatientName";
            this.FamilyOfPatientName.ReadOnly = true;
            this.FamilyOfPatientName.Width = 140;
            // 
            // PatientId
            // 
            this.PatientId.DataPropertyName = "PatientId";
            this.PatientId.HeaderText = "کدملی";
            this.PatientId.Name = "PatientId";
            this.PatientId.ReadOnly = true;
            this.PatientId.Width = 95;
            // 
            // PatientPhoneNumber
            // 
            this.PatientPhoneNumber.DataPropertyName = "Phone";
            this.PatientPhoneNumber.HeaderText = "شماره تماس";
            this.PatientPhoneNumber.Name = "PatientPhoneNumber";
            this.PatientPhoneNumber.ReadOnly = true;
            this.PatientPhoneNumber.Width = 95;
            // 
            // BirthDateOfPatient
            // 
            this.BirthDateOfPatient.DataPropertyName = "BirthDate";
            this.BirthDateOfPatient.HeaderText = "تاریخ تولد";
            this.BirthDateOfPatient.Name = "BirthDateOfPatient";
            this.BirthDateOfPatient.ReadOnly = true;
            this.BirthDateOfPatient.Width = 80;
            // 
            // frmAdmin_ListPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 397);
            this.ControlBox = false;
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAdmin_ListPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmAdmin_ListPatient_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            this.panelRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPatient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxList)).EndInit();
            this.panelPictureBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelPictureBox;
        private System.Windows.Forms.Button btnPatient;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.PictureBox pictureBoxList;
        private System.Windows.Forms.PictureBox pictureBoxPatient;
        private System.Windows.Forms.PictureBox pictureBoxExit;
        private System.Windows.Forms.PictureBox pictureBoxLogout;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridView dgvPatients;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameOfPatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn FamilyOfPatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDateOfPatient;
        private System.Windows.Forms.Button btnDelete;
    }
}