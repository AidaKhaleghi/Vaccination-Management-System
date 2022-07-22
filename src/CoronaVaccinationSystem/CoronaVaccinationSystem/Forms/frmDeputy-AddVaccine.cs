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
using ValidationComponents;

namespace CoronaVaccinationSystem
{

    public partial class frmDeputy_AddVaccine : Form
    {
        public int VaccineId { get; set; }
        public frmDeputy_AddVaccine(int vaccineId = 0)
        {
            InitializeComponent();
            this.VaccineId = vaccineId;
        }

        private void PictureBoxExit_Click(object sender, EventArgs e)
        {
            frmDeputy_ListVaccine frm = new frmDeputy_ListVaccine();
            frm.Show();
            this.Close();
        }

        private void PictureBoxLogout_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();
            this.Close();
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDeputy_ListVaccine listVaccine = new frmDeputy_ListVaccine();
            listVaccine.Show();
        }

        private void txtEnteredDozes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'آ' && e.KeyChar <= 'ی'))
                e.Handled = true;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (VaccineId == 0)
            {
                if (BaseValidator.IsFormValid(this.components) && CheckExistingVaccineName(txtVaccineName.Text))
                {
                    Vaccines vaccine = new Vaccines();
                    vaccine.VaccineName = txtVaccineName.Text;
                    vaccine.ProduceCountry = txtVaccineCountry.Text;
                    vaccine.EntryDose = long.Parse(txtEnteredDozes.Text);
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        if (db.VaccinRepository.AddNewVaccine(vaccine))
                        {
                            db.Save();
                            RtlMessageBox.Show("عملیات با موفقیت انجام شد.", "تبریک", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            frmDeputy_ListVaccine frm = new frmDeputy_ListVaccine();
                            frm.ShowDialog();
                            this.Close();
                        }
                        else
                            RtlMessageBox.Show("عملیات با شکست مواجه شد.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                Vaccines vaccine = new Vaccines();
                List<Patients> patientList = new List<Patients>();
                using (UnitOfWork db = new UnitOfWork())
                {
                    vaccine = db.VaccinRepository.GetVaccineById(VaccineId);
                    patientList = db.VaccinRepository.VaccineType(vaccine.VaccineName);
                }
                if (BaseValidator.IsFormValid(this.components))
                {
                    vaccine.VaccineName = txtVaccineName.Text;
                    vaccine.ProduceCountry = txtVaccineCountry.Text;
                    vaccine.EntryDose = long.Parse(txtEnteredDozes.Text);

                    using (UnitOfWork db = new UnitOfWork())
                    {
                        if (db.VaccinRepository.Update(vaccine))
                        {
                            foreach (var item in patientList)
                            {
                                item.VaccineName = txtVaccineName.Text;
                                db.PatientsRepository.Update(item);
                            }
                            db.Save();
                            RtlMessageBox.Show("عملیات با موفقیت انجام شد.", "تبریک", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            frmDeputy_ListVaccine frm = new frmDeputy_ListVaccine();
                            frm.ShowDialog();
                            this.Close();
                        }
                        else
                            RtlMessageBox.Show("عملیات با شکست مواجه شد.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }
        bool CheckExistingVaccineName(string vaccineName)
        {
            List<string> VaccineNamesList = new List<string>();
            using (UnitOfWork db = new UnitOfWork())
            {
                VaccineNamesList = db.VaccinRepository.GetVaccineNames();
            }
            bool result = true;
            foreach (var item in VaccineNamesList)
            {
                if (vaccineName.Trim() == item)
                {
                    RtlMessageBox.Show("اطلاعات این واکسن قبلا در سامانه ثبت شده است.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    result = false;
                }
            }
            return result;
        }

        private void frmDeputy_AddVaccine_Load(object sender, EventArgs e)
        {
            if (VaccineId == 0)
            {
                btnVaccine.Text = "ثبت";
                btnConfirm.Text = "ثبت";
            }
            else
            {
                btnVaccine.Text = "ویرایش";
                btnConfirm.Text = "ویرایش";
                Vaccines vaccine = new Vaccines();
                using (UnitOfWork db = new UnitOfWork())
                {
                    vaccine = db.VaccinRepository.GetVaccineById(VaccineId);
                }
                txtVaccineName.Text = vaccine.VaccineName;
                txtVaccineCountry.Text = vaccine.ProduceCountry;
                txtEnteredDozes.Text = vaccine.EntryDose.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtVaccineName.Text = null;
            txtVaccineCountry.Text = null;
            txtEnteredDozes.Text = null;
        }
    }
}
