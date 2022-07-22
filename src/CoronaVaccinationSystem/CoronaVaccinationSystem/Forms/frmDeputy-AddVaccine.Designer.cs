namespace CoronaVaccinationSystem
{
    partial class frmDeputy_AddVaccine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeputy_AddVaccine));
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblDeputy = new System.Windows.Forms.Label();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.panelRight = new System.Windows.Forms.Panel();
            this.pictureBoxVaccine = new System.Windows.Forms.PictureBox();
            this.pictureBoxList = new System.Windows.Forms.PictureBox();
            this.btnVaccine = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.panelPictureBox = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.groupBoxVaccinInformation = new System.Windows.Forms.GroupBox();
            this.txtVaccineName = new System.Windows.Forms.TextBox();
            this.txtVaccineCountry = new System.Windows.Forms.TextBox();
            this.txtEnteredDozes = new System.Windows.Forms.TextBox();
            this.lblEnteredDozes = new System.Windows.Forms.Label();
            this.lblVaccineCountry = new System.Windows.Forms.Label();
            this.lblVaccineName = new System.Windows.Forms.Label();
            this.requiredFieldValidator1 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator2 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator3 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVaccine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxList)).BeginInit();
            this.panelPictureBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelLeft.SuspendLayout();
            this.groupBoxVaccinInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Green;
            this.panelTop.Controls.Add(this.lblDeputy);
            this.panelTop.Controls.Add(this.pictureBoxExit);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(610, 43);
            this.panelTop.TabIndex = 1;
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
            this.panelRight.TabIndex = 2;
            // 
            // pictureBoxVaccine
            // 
            this.pictureBoxVaccine.BackColor = System.Drawing.Color.DarkGreen;
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
            this.pictureBoxList.BackColor = System.Drawing.Color.ForestGreen;
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
            this.btnVaccine.BackColor = System.Drawing.Color.DarkGreen;
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
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.ForestGreen;
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
            this.btnList.Click += new System.EventHandler(this.BtnList_Click);
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
            this.panelLeft.Controls.Add(this.btnClear);
            this.panelLeft.Controls.Add(this.btnConfirm);
            this.panelLeft.Controls.Add(this.groupBoxVaccinInformation);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.Location = new System.Drawing.Point(0, 43);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(466, 355);
            this.panelLeft.TabIndex = 3;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnClear.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnClear.Location = new System.Drawing.Point(139, 281);
            this.btnClear.Name = "btnClear";
            this.btnClear.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnClear.Size = new System.Drawing.Size(82, 33);
            this.btnClear.TabIndex = 72;
            this.btnClear.Text = "پاک";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Green;
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnConfirm.Location = new System.Drawing.Point(51, 281);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnConfirm.Size = new System.Drawing.Size(82, 33);
            this.btnConfirm.TabIndex = 71;
            this.btnConfirm.Text = "ثبت واکسن";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // groupBoxVaccinInformation
            // 
            this.groupBoxVaccinInformation.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxVaccinInformation.Controls.Add(this.txtVaccineName);
            this.groupBoxVaccinInformation.Controls.Add(this.txtVaccineCountry);
            this.groupBoxVaccinInformation.Controls.Add(this.txtEnteredDozes);
            this.groupBoxVaccinInformation.Controls.Add(this.lblEnteredDozes);
            this.groupBoxVaccinInformation.Controls.Add(this.lblVaccineCountry);
            this.groupBoxVaccinInformation.Controls.Add(this.lblVaccineName);
            this.groupBoxVaccinInformation.Font = new System.Drawing.Font("IranNastaliq", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBoxVaccinInformation.Location = new System.Drawing.Point(51, 33);
            this.groupBoxVaccinInformation.Name = "groupBoxVaccinInformation";
            this.groupBoxVaccinInformation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBoxVaccinInformation.Size = new System.Drawing.Size(365, 232);
            this.groupBoxVaccinInformation.TabIndex = 70;
            this.groupBoxVaccinInformation.TabStop = false;
            this.groupBoxVaccinInformation.Text = "اطلاعات واکسن";
            // 
            // txtVaccineName
            // 
            this.txtVaccineName.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtVaccineName.Location = new System.Drawing.Point(18, 72);
            this.txtVaccineName.Name = "txtVaccineName";
            this.txtVaccineName.Size = new System.Drawing.Size(143, 31);
            this.txtVaccineName.TabIndex = 81;
            // 
            // txtVaccineCountry
            // 
            this.txtVaccineCountry.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtVaccineCountry.Location = new System.Drawing.Point(18, 120);
            this.txtVaccineCountry.Name = "txtVaccineCountry";
            this.txtVaccineCountry.Size = new System.Drawing.Size(143, 31);
            this.txtVaccineCountry.TabIndex = 80;
            // 
            // txtEnteredDozes
            // 
            this.txtEnteredDozes.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtEnteredDozes.Location = new System.Drawing.Point(18, 167);
            this.txtEnteredDozes.MaxLength = 10;
            this.txtEnteredDozes.Name = "txtEnteredDozes";
            this.txtEnteredDozes.Size = new System.Drawing.Size(143, 28);
            this.txtEnteredDozes.TabIndex = 79;
            this.txtEnteredDozes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEnteredDozes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEnteredDozes_KeyPress);
            // 
            // lblEnteredDozes
            // 
            this.lblEnteredDozes.AutoSize = true;
            this.lblEnteredDozes.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.lblEnteredDozes.Location = new System.Drawing.Point(165, 169);
            this.lblEnteredDozes.Name = "lblEnteredDozes";
            this.lblEnteredDozes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblEnteredDozes.Size = new System.Drawing.Size(186, 26);
            this.lblEnteredDozes.TabIndex = 66;
            this.lblEnteredDozes.Text = "تعداد دوزهای واردشده به کشور:";
            this.lblEnteredDozes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblVaccineCountry
            // 
            this.lblVaccineCountry.AutoSize = true;
            this.lblVaccineCountry.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.lblVaccineCountry.Location = new System.Drawing.Point(242, 122);
            this.lblVaccineCountry.Name = "lblVaccineCountry";
            this.lblVaccineCountry.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblVaccineCountry.Size = new System.Drawing.Size(110, 26);
            this.lblVaccineCountry.TabIndex = 65;
            this.lblVaccineCountry.Text = "کشور تولیدکننده:";
            this.lblVaccineCountry.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblVaccineName
            // 
            this.lblVaccineName.AutoSize = true;
            this.lblVaccineName.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.lblVaccineName.Location = new System.Drawing.Point(273, 74);
            this.lblVaccineName.Name = "lblVaccineName";
            this.lblVaccineName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblVaccineName.Size = new System.Drawing.Size(71, 26);
            this.lblVaccineName.TabIndex = 64;
            this.lblVaccineName.Text = "نام واکسن:";
            this.lblVaccineName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator1.ControlToValidate = this.txtVaccineName;
            this.requiredFieldValidator1.ErrorMessage = "لطفا نام واکسن را وارد کنید";
            this.requiredFieldValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator1.Icon")));
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator2.ControlToValidate = this.txtVaccineCountry;
            this.requiredFieldValidator2.ErrorMessage = "لطفا نام کشور سازنده را وارد کنید";
            this.requiredFieldValidator2.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator2.Icon")));
            // 
            // requiredFieldValidator3
            // 
            this.requiredFieldValidator3.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator3.ControlToValidate = this.txtEnteredDozes;
            this.requiredFieldValidator3.ErrorMessage = "لطفا تعداد دوز های وارد شده را وارد کنید";
            this.requiredFieldValidator3.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator3.Icon")));
            // 
            // frmDeputy_AddVaccine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 398);
            this.ControlBox = false;
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmDeputy_AddVaccine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmDeputy_AddVaccine_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            this.panelRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVaccine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxList)).EndInit();
            this.panelPictureBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelLeft.ResumeLayout(false);
            this.groupBoxVaccinInformation.ResumeLayout(false);
            this.groupBoxVaccinInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblDeputy;
        private System.Windows.Forms.PictureBox pictureBoxExit;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.PictureBox pictureBoxVaccine;
        private System.Windows.Forms.PictureBox pictureBoxList;
        private System.Windows.Forms.Button btnVaccine;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Panel panelPictureBox;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.GroupBox groupBoxVaccinInformation;
        private System.Windows.Forms.TextBox txtVaccineName;
        private System.Windows.Forms.TextBox txtVaccineCountry;
        private System.Windows.Forms.TextBox txtEnteredDozes;
        private System.Windows.Forms.Label lblEnteredDozes;
        private System.Windows.Forms.Label lblVaccineCountry;
        private System.Windows.Forms.Label lblVaccineName;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator1;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator2;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator3;
    }
}