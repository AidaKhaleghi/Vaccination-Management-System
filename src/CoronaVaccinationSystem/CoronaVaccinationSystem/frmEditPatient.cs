using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoronaVaccinationSystem
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
            UserControl_ListPatient listPatient = new UserControl_ListPatient();
            AddPanel(listPatient);
        }

        public void CallPanelLeft()
        {

        }
        private void AddPanel(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelLeft.Controls.Clear();
            panelLeft.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void BtnList_Click(object sender, EventArgs e)
        {
            UserControl_ListPatient listPatient = new UserControl_ListPatient();
            AddPanel(listPatient);
            btnList.BackColor = Color.DarkGreen;
            pictureBoxList.BackColor = Color.DarkGreen;
            btnPatient.BackColor = Color.ForestGreen;
            pictureBoxPatient.BackColor = Color.ForestGreen;
        }

        
        private void BtnPatient_Click(object sender, EventArgs e)
        {
            UserControl_AddPatient addPatient = new UserControl_AddPatient();
            AddPanel(addPatient);
            btnPatient.BackColor = Color.DarkGreen;
            pictureBoxPatient.BackColor = Color.DarkGreen;
            btnList.BackColor = Color.ForestGreen;
            pictureBoxList.BackColor = Color.ForestGreen;
        }

        private void PictureBoxExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PictureBoxLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.Show();
        }
    }
}
