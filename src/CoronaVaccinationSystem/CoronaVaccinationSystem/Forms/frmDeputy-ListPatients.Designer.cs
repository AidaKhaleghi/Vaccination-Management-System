namespace CoronaVaccinationSystem
{
    partial class frmDeputy_ListPatients
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
            this.lblDeputy = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.pictureBoxVaccine = new System.Windows.Forms.PictureBox();
            this.pictureBoxList = new System.Windows.Forms.PictureBox();
            this.btnVaccine = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.panelPictureBox = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.dgvPatients = new System.Windows.Forms.DataGridView();
            this.NameOfPatient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FamilyOfPatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtConfirm = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVaccine)).BeginInit();
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
            this.panelTop.Controls.Add(this.lblDeputy);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(610, 43);
            this.panelTop.TabIndex = 0;
            // 
            // lblDeputy
            // 
            this.lblDeputy.AutoSize = true;
            this.lblDeputy.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDeputy.Font = new System.Drawing.Font("IranNastaliq", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblDeputy.Location = new System.Drawing.Point(227, 1);
            this.lblDeputy.Name = "lblDeputy";
            this.lblDeputy.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDeputy.Size = new System.Drawing.Size(112, 41);
            this.lblDeputy.TabIndex = 12;
            this.lblDeputy.Text = "نماینده وزارت بهداشت";
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.Green;
            this.panelRight.Controls.Add(this.pictureBoxVaccine);
            this.panelRight.Controls.Add(this.pictureBoxList);
            this.panelRight.Controls.Add(this.btnVaccine);
            this.panelRight.Controls.Add(this.btnList);
            this.panelRight.Controls.Add(this.panelPictureBox);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(466, 43);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(144, 355);
            this.panelRight.TabIndex = 1;
            // 
            // pictureBoxVaccine
            // 
            this.pictureBoxVaccine.BackColor = System.Drawing.Color.ForestGreen;
            this.pictureBoxVaccine.Image = global::CoronaVaccinationSystem.Properties.Resources.vaccine__1_;
            this.pictureBoxVaccine.Location = new System.Drawing.Point(116, 229);
            this.pictureBoxVaccine.Name = "pictureBoxVaccine";
            this.pictureBoxVaccine.Size = new System.Drawing.Size(28, 49);
            this.pictureBoxVaccine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxVaccine.TabIndex = 5;
            this.pictureBoxVaccine.TabStop = false;
            // 
            // pictureBoxList
            // 
            this.pictureBoxList.BackColor = System.Drawing.Color.DarkGreen;
            this.pictureBoxList.Image = global::CoronaVaccinationSystem.Properties.Resources.list;
            this.pictureBoxList.Location = new System.Drawing.Point(116, 172);
            this.pictureBoxList.Name = "pictureBoxList";
            this.pictureBoxList.Size = new System.Drawing.Size(28, 49);
            this.pictureBoxList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxList.TabIndex = 4;
            this.pictureBoxList.TabStop = false;
            // 
            // btnVaccine
            // 
            this.btnVaccine.BackColor = System.Drawing.Color.ForestGreen;
            this.btnVaccine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVaccine.FlatAppearance.BorderSize = 0;
            this.btnVaccine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVaccine.Font = new System.Drawing.Font("IranNastaliq", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnVaccine.Location = new System.Drawing.Point(0, 228);
            this.btnVaccine.Name = "btnVaccine";
            this.btnVaccine.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnVaccine.Size = new System.Drawing.Size(144, 50);
            this.btnVaccine.TabIndex = 3;
            this.btnVaccine.Text = "واکسن جدید";
            this.btnVaccine.UseVisualStyleBackColor = false;
            this.btnVaccine.Click += new System.EventHandler(this.BtnVaccine_Click);
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
            this.btnList.TabIndex = 2;
            this.btnList.Text = "لیست واکسن ها";
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
            this.pictureBoxLogo.TabIndex = 1;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.dgvPatients);
            this.panelLeft.Controls.Add(this.txtConfirm);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.Location = new System.Drawing.Point(0, 43);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(466, 355);
            this.panelLeft.TabIndex = 2;
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
            this.PatientPhoneNumber});
            this.dgvPatients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvPatients.Location = new System.Drawing.Point(5, 6);
            this.dgvPatients.Name = "dgvPatients";
            this.dgvPatients.ReadOnly = true;
            this.dgvPatients.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvPatients.Size = new System.Drawing.Size(457, 282);
            this.dgvPatients.TabIndex = 20;
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
            this.FamilyOfPatientName.Width = 120;
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
            // txtConfirm
            // 
            this.txtConfirm.BackColor = System.Drawing.Color.Green;
            this.txtConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtConfirm.FlatAppearance.BorderSize = 0;
            this.txtConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtConfirm.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtConfirm.Location = new System.Drawing.Point(37, 303);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtConfirm.Size = new System.Drawing.Size(73, 35);
            this.txtConfirm.TabIndex = 19;
            this.txtConfirm.Text = "تایید";
            this.txtConfirm.UseVisualStyleBackColor = false;
            this.txtConfirm.Click += new System.EventHandler(this.btnConfirmClick_Click);
            // 
            // frmDeputy_ListPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 398);
            this.ControlBox = false;
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmDeputy_ListPatients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmDeputy_ListVaccine_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVaccine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxList)).EndInit();
            this.panelPictureBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label lblDeputy;
        private System.Windows.Forms.Panel panelPictureBox;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnVaccine;
        private System.Windows.Forms.PictureBox pictureBoxList;
        private System.Windows.Forms.PictureBox pictureBoxVaccine;
        private System.Windows.Forms.Button txtConfirm;
        private System.Windows.Forms.DataGridView dgvPatients;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameOfPatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn FamilyOfPatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientPhoneNumber;
    }
}