namespace CoronaVaccinationSystem
{
    partial class frmDeputy_ListVaccine
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
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogout = new System.Windows.Forms.PictureBox();
            this.panelRight = new System.Windows.Forms.Panel();
            this.pictureBoxVaccine = new System.Windows.Forms.PictureBox();
            this.pictureBoxList = new System.Windows.Forms.PictureBox();
            this.btnVaccine = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.panelPictureBox = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.txtPatients = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.dgvVaccines = new System.Windows.Forms.DataGridView();
            this.VaccinesId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VaccineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProduceCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntryDoses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogout)).BeginInit();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVaccine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxList)).BeginInit();
            this.panelPictureBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaccines)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Green;
            this.panelTop.Controls.Add(this.lblDeputy);
            this.panelTop.Controls.Add(this.pictureBoxExit);
            this.panelTop.Controls.Add(this.pictureBoxLogout);
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
            // pictureBoxExit
            // 
            this.pictureBoxExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxExit.Image = global::CoronaVaccinationSystem.Properties.Resources.power_button;
            this.pictureBoxExit.Location = new System.Drawing.Point(573, 0);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(37, 43);
            this.pictureBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxExit.TabIndex = 11;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.Click += new System.EventHandler(this.PictureBoxExit_Click);
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
            this.pictureBoxLogout.TabIndex = 10;
            this.pictureBoxLogout.TabStop = false;
            this.pictureBoxLogout.Click += new System.EventHandler(this.PictureBoxLogout_Click);
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
            this.panelLeft.Controls.Add(this.txtPatients);
            this.panelLeft.Controls.Add(this.btnDelete);
            this.panelLeft.Controls.Add(this.btnEdit);
            this.panelLeft.Controls.Add(this.dgvVaccines);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.Location = new System.Drawing.Point(0, 43);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(466, 355);
            this.panelLeft.TabIndex = 2;
            // 
            // txtPatients
            // 
            this.txtPatients.BackColor = System.Drawing.Color.Green;
            this.txtPatients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtPatients.FlatAppearance.BorderSize = 0;
            this.txtPatients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtPatients.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPatients.Location = new System.Drawing.Point(37, 303);
            this.txtPatients.Name = "txtPatients";
            this.txtPatients.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPatients.Size = new System.Drawing.Size(73, 35);
            this.txtPatients.TabIndex = 19;
            this.txtPatients.Text = "اشخاص";
            this.txtPatients.UseVisualStyleBackColor = false;
            this.txtPatients.Click += new System.EventHandler(this.btnPatients_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnDelete.Location = new System.Drawing.Point(195, 303);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnDelete.Size = new System.Drawing.Size(73, 35);
            this.btnDelete.TabIndex = 18;
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
            this.btnEdit.Location = new System.Drawing.Point(116, 303);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnEdit.Size = new System.Drawing.Size(73, 35);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "ویرایش";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // dgvVaccines
            // 
            this.dgvVaccines.AllowUserToAddRows = false;
            this.dgvVaccines.AllowUserToDeleteRows = false;
            this.dgvVaccines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVaccines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VaccinesId,
            this.VaccineName,
            this.ProduceCountry,
            this.EntryDoses});
            this.dgvVaccines.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvVaccines.Location = new System.Drawing.Point(27, 9);
            this.dgvVaccines.Name = "dgvVaccines";
            this.dgvVaccines.ReadOnly = true;
            this.dgvVaccines.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvVaccines.Size = new System.Drawing.Size(409, 278);
            this.dgvVaccines.TabIndex = 1;
            // 
            // VaccinesId
            // 
            this.VaccinesId.DataPropertyName = "VaccineId";
            this.VaccinesId.HeaderText = "آیدی واکسن ها";
            this.VaccinesId.Name = "VaccinesId";
            this.VaccinesId.ReadOnly = true;
            this.VaccinesId.Visible = false;
            // 
            // VaccineName
            // 
            this.VaccineName.DataPropertyName = "VaccineName";
            this.VaccineName.HeaderText = "نام واکسن";
            this.VaccineName.Name = "VaccineName";
            this.VaccineName.ReadOnly = true;
            // 
            // ProduceCountry
            // 
            this.ProduceCountry.DataPropertyName = "ProduceCountry";
            this.ProduceCountry.HeaderText = "کشور سازنده";
            this.ProduceCountry.Name = "ProduceCountry";
            this.ProduceCountry.ReadOnly = true;
            // 
            // EntryDoses
            // 
            this.EntryDoses.DataPropertyName = "EntryDose";
            this.EntryDoses.HeaderText = "تعداد دوز های وارد شده";
            this.EntryDoses.Name = "EntryDoses";
            this.EntryDoses.ReadOnly = true;
            this.EntryDoses.Width = 150;
            // 
            // frmDeputy_ListVaccine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 398);
            this.ControlBox = false;
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmDeputy_ListVaccine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmDeputy_ListVaccine_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogout)).EndInit();
            this.panelRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVaccine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxList)).EndInit();
            this.panelPictureBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaccines)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.PictureBox pictureBoxLogout;
        private System.Windows.Forms.PictureBox pictureBoxExit;
        private System.Windows.Forms.Label lblDeputy;
        private System.Windows.Forms.Panel panelPictureBox;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnVaccine;
        private System.Windows.Forms.PictureBox pictureBoxList;
        private System.Windows.Forms.PictureBox pictureBoxVaccine;
        private System.Windows.Forms.DataGridView dgvVaccines;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn VaccinesId;
        private System.Windows.Forms.DataGridViewTextBoxColumn VaccineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProduceCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntryDoses;
        private System.Windows.Forms.Button txtPatients;
    }
}