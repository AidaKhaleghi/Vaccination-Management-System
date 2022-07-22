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
    public partial class frmAdmin_ListPatient : Form
    {
        public frmAdmin_ListPatient()
        {
            InitializeComponent();
        }
        void BindGrid()
        {
            dgvPatients.AutoGenerateColumns = false;
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvPatients.DataSource = db.PatientsRepository.GetAllPatients();
            }
            dgvPatients.AllowUserToOrderColumns = false;
        }
        private void BtnPatient_Click(object sender, EventArgs e)
        {
            frmAdmin_AddPatient frm = new frmAdmin_AddPatient();
            frm.ShowDialog();
            this.Close();
        }

        private void PictureBoxExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PictureBoxLogout_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();
            this.Close();
        }

        private void frmAdmin_ListPatient_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (dgvPatients.CurrentRow != null)
            {
                if (dgvPatients.CurrentRow.Selected)
                {
                    long id = long.Parse(dgvPatients.CurrentRow.Cells[2].Value.ToString());
                    frmAdmin_EditPatient frm = new frmAdmin_EditPatient(id);
                    frm.Show();
                    this.Close();
                }
                else
                    RtlMessageBox.Show("لطفا سطر مربوط به اطلاعات یک شخص را انتخاب کنید.", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                RtlMessageBox.Show("لطفا یک شخص جدید را به لیست اضافه کنید.", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            if (txtSearch.Text != "")
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    dgvPatients.DataSource = db.PatientsRepository.Filter(txtSearch.Text);
                }
            }
            else
                BindGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (dgvPatients.CurrentRow != null)
            {
                if (dgvPatients.CurrentRow.Selected)
                {
                    if (RtlMessageBox.Show($"آیا از حذف {dgvPatients.CurrentRow.Cells[0].Value} {dgvPatients.CurrentRow.Cells[1].Value} مطمعن هستید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        long id = long.Parse(dgvPatients.CurrentRow.Cells[2].Value.ToString());
                        using (UnitOfWork db = new UnitOfWork())
                        {
                            Patients p = db.PatientsRepository.GetPatientById(id);
                            try
                            {
                                if (db.PatientsRepository.Delete(p))
                                {
                                    db.Save();
                                    RtlMessageBox.Show("عملیات با موفقیت انجام شد.", "تبریک", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    BindGrid();
                                }
                            }
                            catch (Exception)
                            {
                                RtlMessageBox.Show("عملیات با شکست مواجه شد.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else
                    RtlMessageBox.Show("لطفا یک سطر را انتخاب کنید.", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                RtlMessageBox.Show("لطفا یک شخص جدید را به لیست اضافه کنید.", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);




        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
            this.Close();
        }
    }

}
