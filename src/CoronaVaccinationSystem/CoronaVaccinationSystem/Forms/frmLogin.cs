using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoronaVaccinationSystem.DataLayer;
using CoronaVaccinationSystem.Utility;

namespace CoronaVaccinationSystem
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (LoginVaidations.AdminsValidation(txtUserName.Text, txtPassword.Text))
            {
                frmAdmin_ListPatient frm = new frmAdmin_ListPatient();
                frm.Show();
                this.Close();
            }
            else if (LoginVaidations.DeputeisValidation(txtUserName.Text, txtPassword.Text))
            {
                frmDeputy_ListVaccine frm = new frmDeputy_ListVaccine();
                frm.Show();
                this.Close();
            }
            else
                RtlMessageBox.Show("نام کابری یا رمز عبور وارد شده صحیح نمی باشد.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void PictureBoxPassword_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void PictureBoxPassword_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void TxtUserName_Click(object sender, EventArgs e)
        {
            panelUserName.BackColor = Color.White;
            txtUserName.BackColor = Color.White;
            panelPassword.BackColor = SystemColors.Control;
            txtPassword.BackColor = SystemColors.Control;
        }

        private void TxtPassword_Click(object sender, EventArgs e)
        {
            panelPassword.BackColor = Color.White;
            txtPassword.BackColor = Color.White;
            panelUserName.BackColor = SystemColors.Control;
            txtUserName.BackColor = SystemColors.Control;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtUserName.Text = null;
            txtPassword.Text = null;
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (LoginVaidations.AdminsValidation(txtUserName.Text, txtPassword.Text))
            {
                frmAdmin_ListPatient frm = new frmAdmin_ListPatient();
                frm.Show();
                this.Close();
            }
            else if (LoginVaidations.DeputeisValidation(txtUserName.Text, txtPassword.Text))
            {
                frmDeputy_ListVaccine frm = new frmDeputy_ListVaccine();
                frm.Show();
                this.Close();
            }
            else
                RtlMessageBox.Show("نام کاربری یا رمز عبور وارد شده صحیح نمی باشد.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click_2(object sender, EventArgs e)
        {
            frmInfo Info = new frmInfo();
            Info.Show();
            this.Close();
        }
    }
}
