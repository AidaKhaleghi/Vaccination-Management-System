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
    public partial class frmDeputy_ListVaccine : Form
    {
        public frmDeputy_ListVaccine()
        {
            InitializeComponent();
        }
        void BindGrid()
        {
            dgvVaccines.AutoGenerateColumns = false;
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvVaccines.DataSource = db.VaccinRepository.GetAllVaccines();
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
            Application.Exit();
        }

        private void PictureBoxLogout_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvVaccines.CurrentRow != null)
            {
                if (dgvVaccines.CurrentRow.Selected)
                {
                    int vaccineId = int.Parse(dgvVaccines.CurrentRow.Cells[0].Value.ToString());
                    frmDeputy_AddVaccine frm = new frmDeputy_AddVaccine(vaccineId);
                    frm.ShowDialog();
                    this.Close();
                }
                else
                    RtlMessageBox.Show("لطفا سطر مربوط به اطلاعات یک واکسن را انتخاب کنید.", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                RtlMessageBox.Show("لطفا یک واکسن جدید اضافه کنید.", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void frmDeputy_ListVaccine_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvVaccines.CurrentRow != null)
            {
                if (dgvVaccines.CurrentRow.Selected)
                {
                    int vaccineId = int.Parse(dgvVaccines.CurrentRow.Cells[0].Value.ToString());
                    Vaccines vaccine = new Vaccines();                    
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        vaccine = db.VaccinRepository.GetVaccineById(vaccineId);
                        //if (db.VaccinRepository.VaccineType(vaccine.VaccineName).Count == 0)
                        //{
                            if (RtlMessageBox.Show($"آیا از حذف واکسن {vaccine.VaccineName} مطمعن هستید؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                            {                         
                                
                                    if (db.VaccinRepository.Delete(vaccine))
                                    {
                                        db.Save();
                                        RtlMessageBox.Show("عملیات با موفقیت انجام شد.", "تبریک", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    }
                                    else
                                        RtlMessageBox.Show("عملیات با شکست مواجه شد.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);                               
                            }
                      //  }
                       // else
                          //  RtlMessageBox.Show("این واکسن در کشور و در پایگاه های واکسیناسیون تزریق شده است. امکان حذف شدن آن وجود ندارد.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    RtlMessageBox.Show("لطفا یک سطر را انتخاب کنید.", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                RtlMessageBox.Show("لطفا یک واکسن جدید اضافه کنید.", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            BindGrid();
        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            if (dgvVaccines.CurrentRow != null)
            {
                if (dgvVaccines.CurrentRow.Selected)
                {
                    string vaccineName = dgvVaccines.CurrentRow.Cells[1].Value.ToString();
                    frmDeputy_ListPatients frm = new frmDeputy_ListPatients(vaccineName);
                    frm.ShowDialog();
                    this.Close();
                }
                else
                    RtlMessageBox.Show("لطفا یک سطر را انتخاب کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                RtlMessageBox.Show("لطفا یک واکسن جدید اضافه کنید.", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
            this.Close();
        }
    }
}
