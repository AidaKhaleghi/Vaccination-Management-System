using CoronaVaccinationSystem.DataLayer;
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
    public partial class frmDeputy_ListPatients : Form
    {
        public string VaccineName { get; set; }
        public frmDeputy_ListPatients(string vaccineName)
        {
            InitializeComponent();
            this.VaccineName = vaccineName;
        }
        void BindGrid()
        {
            dgvPatients.AutoGenerateColumns = false;
            using(UnitOfWork db = new UnitOfWork())
            {
                dgvPatients.DataSource = db.VaccinRepository.VaccineType(VaccineName);
            }
        }

        private void BtnVaccine_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDeputy_AddVaccine addVaccine = new frmDeputy_AddVaccine();
            addVaccine.Show();
        }

        private void PictureBoxExit_Click(object sender, EventArgs e)
        {
            frmDeputy_ListVaccine frm = new frmDeputy_ListVaccine();
            frm.ShowDialog();
            this.Close();
        }

        private void PictureBoxLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.Show();
        }

        private void frmDeputy_ListVaccine_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void btnConfirmClick_Click(object sender, EventArgs e)
        {
            frmDeputy_ListVaccine frm = new frmDeputy_ListVaccine();
            frm.Show();
            this.Close();
        }
    }
}
