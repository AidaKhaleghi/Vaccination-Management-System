using CoronaVaccinationSystem.Utility;
using System.Collections.Generic;

namespace CoronaVaccinationSystem
{
    partial class frmAdmin_AddPatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin_AddPatient));
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.groupBoxVaccinInformation = new System.Windows.Forms.GroupBox();
            this.lblSecondDozeDate = new System.Windows.Forms.Label();
            this.lblFirstDozeDate = new System.Windows.Forms.Label();
            this.checkBoxSecondDoze = new System.Windows.Forms.CheckBox();
            this.comboBoxVaccineName = new System.Windows.Forms.ComboBox();
            this.checkBoxFirstDoze = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LblDoze = new System.Windows.Forms.Label();
            this.lblVaccineName = new System.Windows.Forms.Label();
            this.groupBoxPerdonalInformation = new System.Windows.Forms.GroupBox();
            this.txtPatientId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtTelNum = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblTelNum = new System.Windows.Forms.Label();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.comboBoxMonth = new System.Windows.Forms.ComboBox();
            this.comboBoxDay = new System.Windows.Forms.ComboBox();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblPersonalID = new System.Windows.Forms.Label();
            this.txtFamilyName = new System.Windows.Forms.TextBox();
            this.lblFamilyName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.panelPictureBox = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.btnList = new System.Windows.Forms.Button();
            this.pictureBoxList = new System.Windows.Forms.PictureBox();
            this.pictureBoxPatient = new System.Windows.Forms.PictureBox();
            this.panelRight = new System.Windows.Forms.Panel();
            this.btnPatient = new System.Windows.Forms.Button();
            this.requiredFieldValidator1 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator2 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator3 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator4 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            this.panelLeft.SuspendLayout();
            this.groupBoxVaccinInformation.SuspendLayout();
            this.groupBoxPerdonalInformation.SuspendLayout();
            this.panelPictureBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPatient)).BeginInit();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Green;
            this.panelTop.Controls.Add(this.lblAdmin);
            this.panelTop.Controls.Add(this.pictureBoxExit);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(730, 43);
            this.panelTop.TabIndex = 1;
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
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.btnClear);
            this.panelLeft.Controls.Add(this.btnConfirm);
            this.panelLeft.Controls.Add(this.groupBoxVaccinInformation);
            this.panelLeft.Controls.Add(this.groupBoxPerdonalInformation);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.Location = new System.Drawing.Point(0, 43);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(586, 354);
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
            this.btnClear.Location = new System.Drawing.Point(162, 269);
            this.btnClear.Name = "btnClear";
            this.btnClear.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnClear.Size = new System.Drawing.Size(82, 33);
            this.btnClear.TabIndex = 71;
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
            this.btnConfirm.Location = new System.Drawing.Point(40, 269);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnConfirm.Size = new System.Drawing.Size(82, 33);
            this.btnConfirm.TabIndex = 70;
            this.btnConfirm.Text = "ثبت";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // groupBoxVaccinInformation
            // 
            this.groupBoxVaccinInformation.BackColor = System.Drawing.Color.Snow;
            this.groupBoxVaccinInformation.Controls.Add(this.lblSecondDozeDate);
            this.groupBoxVaccinInformation.Controls.Add(this.lblFirstDozeDate);
            this.groupBoxVaccinInformation.Controls.Add(this.checkBoxSecondDoze);
            this.groupBoxVaccinInformation.Controls.Add(this.comboBoxVaccineName);
            this.groupBoxVaccinInformation.Controls.Add(this.checkBoxFirstDoze);
            this.groupBoxVaccinInformation.Controls.Add(this.label12);
            this.groupBoxVaccinInformation.Controls.Add(this.label11);
            this.groupBoxVaccinInformation.Controls.Add(this.LblDoze);
            this.groupBoxVaccinInformation.Controls.Add(this.lblVaccineName);
            this.groupBoxVaccinInformation.Font = new System.Drawing.Font("IranNastaliq", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBoxVaccinInformation.Location = new System.Drawing.Point(4, 3);
            this.groupBoxVaccinInformation.Name = "groupBoxVaccinInformation";
            this.groupBoxVaccinInformation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBoxVaccinInformation.Size = new System.Drawing.Size(280, 220);
            this.groupBoxVaccinInformation.TabIndex = 69;
            this.groupBoxVaccinInformation.TabStop = false;
            this.groupBoxVaccinInformation.Text = "اطلاعات واکسن";
            // 
            // lblSecondDozeDate
            // 
            this.lblSecondDozeDate.AutoSize = true;
            this.lblSecondDozeDate.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblSecondDozeDate.Location = new System.Drawing.Point(82, 163);
            this.lblSecondDozeDate.Name = "lblSecondDozeDate";
            this.lblSecondDozeDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSecondDozeDate.Size = new System.Drawing.Size(70, 26);
            this.lblSecondDozeDate.TabIndex = 79;
            this.lblSecondDozeDate.Text = "0000/00/00";
            this.lblSecondDozeDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFirstDozeDate
            // 
            this.lblFirstDozeDate.AutoSize = true;
            this.lblFirstDozeDate.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblFirstDozeDate.Location = new System.Drawing.Point(81, 126);
            this.lblFirstDozeDate.Name = "lblFirstDozeDate";
            this.lblFirstDozeDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblFirstDozeDate.Size = new System.Drawing.Size(70, 26);
            this.lblFirstDozeDate.TabIndex = 74;
            this.lblFirstDozeDate.Text = "0000/00/00";
            this.lblFirstDozeDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBoxSecondDoze
            // 
            this.checkBoxSecondDoze.AutoSize = true;
            this.checkBoxSecondDoze.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.checkBoxSecondDoze.Location = new System.Drawing.Point(36, 80);
            this.checkBoxSecondDoze.Name = "checkBoxSecondDoze";
            this.checkBoxSecondDoze.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxSecondDoze.Size = new System.Drawing.Size(52, 30);
            this.checkBoxSecondDoze.TabIndex = 78;
            this.checkBoxSecondDoze.Text = "دوم";
            this.checkBoxSecondDoze.UseVisualStyleBackColor = true;
            this.checkBoxSecondDoze.CheckedChanged += new System.EventHandler(this.checkBoxSecondDoze_CheckedChanged);
            // 
            // comboBoxVaccineName
            // 
            this.comboBoxVaccineName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVaccineName.Font = new System.Drawing.Font("Mj_Flow Bold", 9.75F, System.Drawing.FontStyle.Bold);
            this.comboBoxVaccineName.FormattingEnabled = true;
            this.comboBoxVaccineName.Items.AddRange(new object[] {
            "انتخاب کنید"});
            this.comboBoxVaccineName.Location = new System.Drawing.Point(8, 50);
            this.comboBoxVaccineName.Name = "comboBoxVaccineName";
            this.comboBoxVaccineName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBoxVaccineName.Size = new System.Drawing.Size(144, 26);
            this.comboBoxVaccineName.TabIndex = 77;
            this.comboBoxVaccineName.Enter += new System.EventHandler(this.comboBoxVaccineName_Enter);
            // 
            // checkBoxFirstDoze
            // 
            this.checkBoxFirstDoze.AutoSize = true;
            this.checkBoxFirstDoze.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.checkBoxFirstDoze.Location = new System.Drawing.Point(103, 80);
            this.checkBoxFirstDoze.Name = "checkBoxFirstDoze";
            this.checkBoxFirstDoze.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxFirstDoze.Size = new System.Drawing.Size(49, 30);
            this.checkBoxFirstDoze.TabIndex = 66;
            this.checkBoxFirstDoze.Text = "اول";
            this.checkBoxFirstDoze.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Mj_Flow Bold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(158, 166);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label12.Size = new System.Drawing.Size(106, 18);
            this.label12.TabIndex = 67;
            this.label12.Text = "تاریخ تزریق دوز دوم:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Mj_Flow Bold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(159, 128);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(101, 18);
            this.label11.TabIndex = 66;
            this.label11.Text = "تاریخ تزریق دوز اول:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblDoze
            // 
            this.LblDoze.AutoSize = true;
            this.LblDoze.Font = new System.Drawing.Font("Mj_Flow Bold", 9.75F, System.Drawing.FontStyle.Bold);
            this.LblDoze.Location = new System.Drawing.Point(233, 88);
            this.LblDoze.Name = "LblDoze";
            this.LblDoze.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblDoze.Size = new System.Drawing.Size(27, 18);
            this.LblDoze.TabIndex = 65;
            this.LblDoze.Text = "دوز:";
            this.LblDoze.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblVaccineName
            // 
            this.lblVaccineName.AutoSize = true;
            this.lblVaccineName.Font = new System.Drawing.Font("Mj_Flow Bold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblVaccineName.Location = new System.Drawing.Point(193, 52);
            this.lblVaccineName.Name = "lblVaccineName";
            this.lblVaccineName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblVaccineName.Size = new System.Drawing.Size(67, 18);
            this.lblVaccineName.TabIndex = 64;
            this.lblVaccineName.Text = "نام واکسن:";
            this.lblVaccineName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBoxPerdonalInformation
            // 
            this.groupBoxPerdonalInformation.BackColor = System.Drawing.Color.Snow;
            this.groupBoxPerdonalInformation.Controls.Add(this.txtPatientId);
            this.groupBoxPerdonalInformation.Controls.Add(this.label1);
            this.groupBoxPerdonalInformation.Controls.Add(this.txtAddress);
            this.groupBoxPerdonalInformation.Controls.Add(this.txtTelNum);
            this.groupBoxPerdonalInformation.Controls.Add(this.lblAddress);
            this.groupBoxPerdonalInformation.Controls.Add(this.lblTelNum);
            this.groupBoxPerdonalInformation.Controls.Add(this.comboBoxYear);
            this.groupBoxPerdonalInformation.Controls.Add(this.comboBoxMonth);
            this.groupBoxPerdonalInformation.Controls.Add(this.comboBoxDay);
            this.groupBoxPerdonalInformation.Controls.Add(this.lblBirthDate);
            this.groupBoxPerdonalInformation.Controls.Add(this.radioButtonFemale);
            this.groupBoxPerdonalInformation.Controls.Add(this.radioButtonMale);
            this.groupBoxPerdonalInformation.Controls.Add(this.lblGender);
            this.groupBoxPerdonalInformation.Controls.Add(this.lblPersonalID);
            this.groupBoxPerdonalInformation.Controls.Add(this.txtFamilyName);
            this.groupBoxPerdonalInformation.Controls.Add(this.lblFamilyName);
            this.groupBoxPerdonalInformation.Controls.Add(this.txtName);
            this.groupBoxPerdonalInformation.Controls.Add(this.lblName);
            this.groupBoxPerdonalInformation.Font = new System.Drawing.Font("IranNastaliq", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBoxPerdonalInformation.Location = new System.Drawing.Point(291, 3);
            this.groupBoxPerdonalInformation.Name = "groupBoxPerdonalInformation";
            this.groupBoxPerdonalInformation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBoxPerdonalInformation.Size = new System.Drawing.Size(291, 348);
            this.groupBoxPerdonalInformation.TabIndex = 68;
            this.groupBoxPerdonalInformation.TabStop = false;
            this.groupBoxPerdonalInformation.Text = "اطلاعات شخصی";
            // 
            // txtPatientId
            // 
            this.txtPatientId.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPatientId.Location = new System.Drawing.Point(33, 128);
            this.txtPatientId.Name = "txtPatientId";
            this.txtPatientId.Size = new System.Drawing.Size(144, 28);
            this.txtPatientId.TabIndex = 81;
            this.txtPatientId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPatientId_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(6, 237);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(32, 23);
            this.label1.TabIndex = 80;
            this.label1.Text = "98+";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtAddress.Location = new System.Drawing.Point(33, 270);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(156, 70);
            this.txtAddress.TabIndex = 73;
            // 
            // txtTelNum
            // 
            this.txtTelNum.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtTelNum.Location = new System.Drawing.Point(45, 237);
            this.txtTelNum.MaxLength = 11;
            this.txtTelNum.Name = "txtTelNum";
            this.txtTelNum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTelNum.Size = new System.Drawing.Size(144, 28);
            this.txtTelNum.TabIndex = 72;
            this.txtTelNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelNum_KeyPress);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblAddress.Location = new System.Drawing.Point(226, 294);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAddress.Size = new System.Drawing.Size(48, 26);
            this.lblAddress.TabIndex = 71;
            this.lblAddress.Text = "آدرس:";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTelNum
            // 
            this.lblTelNum.AutoSize = true;
            this.lblTelNum.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTelNum.Location = new System.Drawing.Point(191, 235);
            this.lblTelNum.Name = "lblTelNum";
            this.lblTelNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTelNum.Size = new System.Drawing.Size(83, 26);
            this.lblTelNum.TabIndex = 70;
            this.lblTelNum.Text = "شماره تماس:";
            this.lblTelNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.CausesValidation = false;
            this.comboBoxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxYear.Font = new System.Drawing.Font("Mj_Flow Bold", 9.75F, System.Drawing.FontStyle.Bold);
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Location = new System.Drawing.Point(136, 197);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBoxYear.Size = new System.Drawing.Size(64, 26);
            this.comboBoxYear.TabIndex = 69;
            this.comboBoxYear.Enter += new System.EventHandler(this.comboBoxYear_Enter);
            // 
            // comboBoxMonth
            // 
            this.comboBoxMonth.CausesValidation = false;
            this.comboBoxMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMonth.Font = new System.Drawing.Font("Mj_Flow Bold", 9.75F, System.Drawing.FontStyle.Bold);
            this.comboBoxMonth.FormattingEnabled = true;
            this.comboBoxMonth.Items.AddRange(new object[] {
            "ماه"});
            this.comboBoxMonth.Location = new System.Drawing.Point(62, 197);
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBoxMonth.Size = new System.Drawing.Size(68, 26);
            this.comboBoxMonth.TabIndex = 68;
            this.comboBoxMonth.Enter += new System.EventHandler(this.comboBoxMonth_Enter);
            // 
            // comboBoxDay
            // 
            this.comboBoxDay.CausesValidation = false;
            this.comboBoxDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDay.Font = new System.Drawing.Font("Mj_Flow Bold", 9.75F, System.Drawing.FontStyle.Bold);
            this.comboBoxDay.FormattingEnabled = true;
            this.comboBoxDay.Items.AddRange(new object[] {
            "روز"});
            this.comboBoxDay.Location = new System.Drawing.Point(6, 197);
            this.comboBoxDay.Name = "comboBoxDay";
            this.comboBoxDay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBoxDay.Size = new System.Drawing.Size(50, 26);
            this.comboBoxDay.TabIndex = 67;
            this.comboBoxDay.Enter += new System.EventHandler(this.comboBoxDay_Enter);
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblBirthDate.Location = new System.Drawing.Point(203, 197);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblBirthDate.Size = new System.Drawing.Size(71, 26);
            this.lblBirthDate.TabIndex = 66;
            this.lblBirthDate.Text = "تاریخ تولد:";
            this.lblBirthDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Font = new System.Drawing.Font("Mj_Flow Bold", 9.75F, System.Drawing.FontStyle.Bold);
            this.radioButtonFemale.Location = new System.Drawing.Point(60, 162);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButtonFemale.Size = new System.Drawing.Size(36, 22);
            this.radioButtonFemale.TabIndex = 65;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "زن";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Font = new System.Drawing.Font("Mj_Flow Bold", 9.75F, System.Drawing.FontStyle.Bold);
            this.radioButtonMale.Location = new System.Drawing.Point(114, 162);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButtonMale.Size = new System.Drawing.Size(43, 22);
            this.radioButtonMale.TabIndex = 64;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "مرد";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblGender.Location = new System.Drawing.Point(214, 162);
            this.lblGender.Name = "lblGender";
            this.lblGender.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblGender.Size = new System.Drawing.Size(60, 26);
            this.lblGender.TabIndex = 63;
            this.lblGender.Text = "جنسیت:";
            this.lblGender.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPersonalID
            // 
            this.lblPersonalID.AutoSize = true;
            this.lblPersonalID.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPersonalID.Location = new System.Drawing.Point(219, 124);
            this.lblPersonalID.Name = "lblPersonalID";
            this.lblPersonalID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPersonalID.Size = new System.Drawing.Size(55, 26);
            this.lblPersonalID.TabIndex = 59;
            this.lblPersonalID.Text = "کد ملی:";
            this.lblPersonalID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFamilyName
            // 
            this.txtFamilyName.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtFamilyName.Location = new System.Drawing.Point(33, 86);
            this.txtFamilyName.Name = "txtFamilyName";
            this.txtFamilyName.Size = new System.Drawing.Size(144, 28);
            this.txtFamilyName.TabIndex = 58;
            // 
            // lblFamilyName
            // 
            this.lblFamilyName.AutoSize = true;
            this.lblFamilyName.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblFamilyName.Location = new System.Drawing.Point(189, 88);
            this.lblFamilyName.Name = "lblFamilyName";
            this.lblFamilyName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblFamilyName.Size = new System.Drawing.Size(85, 26);
            this.lblFamilyName.TabIndex = 57;
            this.lblFamilyName.Text = "نام خانوادگی:";
            this.lblFamilyName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtName.Location = new System.Drawing.Point(33, 48);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(144, 28);
            this.txtName.TabIndex = 56;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblName.Location = new System.Drawing.Point(243, 52);
            this.lblName.Name = "lblName";
            this.lblName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblName.Size = new System.Drawing.Size(31, 26);
            this.lblName.TabIndex = 55;
            this.lblName.Text = "نام:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.btnList.TabIndex = 1;
            this.btnList.Text = "لیست بیماران";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.BtnList_Click);
            // 
            // pictureBoxList
            // 
            this.pictureBoxList.BackColor = System.Drawing.Color.ForestGreen;
            this.pictureBoxList.Image = global::CoronaVaccinationSystem.Properties.Resources.medical_records__1_;
            this.pictureBoxList.Location = new System.Drawing.Point(116, 173);
            this.pictureBoxList.Name = "pictureBoxList";
            this.pictureBoxList.Size = new System.Drawing.Size(28, 49);
            this.pictureBoxList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxList.TabIndex = 2;
            this.pictureBoxList.TabStop = false;
            // 
            // pictureBoxPatient
            // 
            this.pictureBoxPatient.BackColor = System.Drawing.Color.DarkGreen;
            this.pictureBoxPatient.Image = global::CoronaVaccinationSystem.Properties.Resources.medical;
            this.pictureBoxPatient.Location = new System.Drawing.Point(116, 229);
            this.pictureBoxPatient.Name = "pictureBoxPatient";
            this.pictureBoxPatient.Size = new System.Drawing.Size(28, 49);
            this.pictureBoxPatient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPatient.TabIndex = 3;
            this.pictureBoxPatient.TabStop = false;
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
            this.panelRight.TabIndex = 2;
            // 
            // btnPatient
            // 
            this.btnPatient.BackColor = System.Drawing.Color.DarkGreen;
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
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator1.ControlToValidate = this.txtName;
            this.requiredFieldValidator1.ErrorMessage = "لطفا نام را وارد کنید";
            this.requiredFieldValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator1.Icon")));
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator2.ControlToValidate = this.txtFamilyName;
            this.requiredFieldValidator2.ErrorMessage = "لطفا نام خانوادگی را وارد کنید";
            this.requiredFieldValidator2.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator2.Icon")));
            // 
            // requiredFieldValidator3
            // 
            this.requiredFieldValidator3.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator3.ControlToValidate = this.txtTelNum;
            this.requiredFieldValidator3.ErrorMessage = "لطفا شماره تلفن را وارد کنید";
            this.requiredFieldValidator3.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator3.Icon")));
            // 
            // requiredFieldValidator4
            // 
            this.requiredFieldValidator4.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator4.ControlToValidate = this.txtPatientId;
            this.requiredFieldValidator4.ErrorMessage = "لطفا کد ملی را وارد کنید";
            this.requiredFieldValidator4.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator4.Icon")));
            // 
            // frmAdmin_AddPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 397);
            this.ControlBox = false;
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAdmin_AddPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmAdmin_AddPatient_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            this.panelLeft.ResumeLayout(false);
            this.groupBoxVaccinInformation.ResumeLayout(false);
            this.groupBoxVaccinInformation.PerformLayout();
            this.groupBoxPerdonalInformation.ResumeLayout(false);
            this.groupBoxPerdonalInformation.PerformLayout();
            this.panelPictureBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPatient)).EndInit();
            this.panelRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.PictureBox pictureBoxExit;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.GroupBox groupBoxVaccinInformation;
        private System.Windows.Forms.CheckBox checkBoxSecondDoze;
        private System.Windows.Forms.ComboBox comboBoxVaccineName;
        private System.Windows.Forms.CheckBox checkBoxFirstDoze;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LblDoze;
        private System.Windows.Forms.Label lblVaccineName;
        private System.Windows.Forms.GroupBox groupBoxPerdonalInformation;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtTelNum;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblTelNum;
        private System.Windows.Forms.ComboBox comboBoxYear;
        private System.Windows.Forms.ComboBox comboBoxMonth;
        private System.Windows.Forms.ComboBox comboBoxDay;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblPersonalID;
        private System.Windows.Forms.TextBox txtFamilyName;
        private System.Windows.Forms.Label lblFamilyName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator1;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator2;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator3;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator4;
        private System.Windows.Forms.Label lblFirstDozeDate;
        private System.Windows.Forms.Label lblSecondDozeDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelPictureBox;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.PictureBox pictureBoxList;
        private System.Windows.Forms.PictureBox pictureBoxPatient;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Button btnPatient;
        private System.Windows.Forms.TextBox txtPatientId;
    }
}