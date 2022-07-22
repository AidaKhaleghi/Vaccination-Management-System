using CoronaVaccinationSystem.DataLayer;
using CoronaVaccinationSystem.Utility;
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
    public partial class frmAdmin_EditPatient : Form
    {
        Patients patient = new Patients();
        long patientId;
        public frmAdmin_EditPatient(long id)
        {
            InitializeComponent();
            patientId = id;
        }

        private void PictureBoxExit_Click(object sender, EventArgs e)
        {
            frmAdmin_ListPatient frm = new frmAdmin_ListPatient();
            frm.Show();
            this.Close();
        }

        private void PictureBoxLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.Show();
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdmin_ListPatient listPatient = new frmAdmin_ListPatient();
            listPatient.Show();
        }

        private void BtnPatient_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdmin_AddPatient addPatient = new frmAdmin_AddPatient();
            addPatient.Show();
        }

        private void frmAdmin_EditPatient_Load(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                patient = db.PatientsRepository.GetPatientById(patientId);
            }
            txtName.Text = patient.Name;
            txtFamilyName.Text = patient.LastName;
            txtPatientId.Text = patient.PatientId.ToString();
            if (patient.Gender == "مرد")
                radioButtonMale.Checked = true;
            else
                radioButtonFemale.Checked = true;
            txtTelNum.Text = patient.Phone.ToString();
            txtAddress.Text = patient.Address.Trim();
            checkBoxFirstDoze.Checked = patient.FirstDose;
            checkBoxSecondDoze.Checked = patient.SecondDoze;
            if (checkBoxSecondDoze.Checked)
            {
                List<string> SecondDozeDate = new List<string>();
                SecondDozeDate = patient.ScondDoseDate.Split('/').ToList();
                txtDayOfSecondDoze.Text = SecondDozeDate[2];
                txtMonthOfSecondDoze.Text = SecondDozeDate[1];
                txtYearOfSecondDoze.Text = SecondDozeDate[0];

            }
            else
            {
                txtDayOfSecondDoze.ReadOnly = true;
                txtMonthOfSecondDoze.ReadOnly = true;
                txtYearOfSecondDoze.ReadOnly = true;
            }
            string[] FirstDozeDate = patient.FirstDoseDate.Split('/');
            lblFirstDozeDate.Text = patient.FirstDoseDate;
            string[] BirthDate = patient.BirthDate.Split('/');
            comboBoxYear.Items.AddRange(new object[] { BirthDate[0] });
            comboBoxYear.SelectedIndex = 0;
            comboBoxMonth.Items.AddRange(new object[] { MyCalender.GetNameOfMonthBasedMonthNumber(int.Parse(BirthDate[1])) });
            comboBoxMonth.SelectedIndex = 0;
            comboBoxDay.Items.AddRange(new object[] { BirthDate[2] });
            comboBoxDay.SelectedIndex = 0;
            comboBoxVaccineName.Items.Add(patient.VaccineName);
            comboBoxVaccineName.Text = patient.VaccineName;
        }
        void SetNewDatas()
        {
            patient.BirthDate = $"{comboBoxYear.SelectedItem}/{MyCalender.GetMounthNumberBasedMonthName(comboBoxMonth.SelectedItem.ToString())}/{comboBoxDay.SelectedItem}";
            patient.FirstDose = true;
            patient.LastName = txtFamilyName.Text;
            patient.Name = txtName.Text;
            patient.PatientId = long.Parse(txtPatientId.Text);
            patient.Phone = long.Parse(txtTelNum.Text);
            patient.Address = txtAddress.Text;
            patient.VaccineName = comboBoxVaccineName.SelectedItem.ToString();
            patient.SecondDoze = checkBoxSecondDoze.Checked;
            if (radioButtonMale.Checked)
            {
                patient.Gender = radioButtonMale.Text;
            }
            else
            {
                patient.Gender = radioButtonFemale.Text;
            }
        }
        private void comboBoxYear_Enter(object sender, EventArgs e)
        {
            List<object> years = MyCalender.GetYearsForCbYears();
            years.RemoveAt(0);
            comboBoxYear.Items.Clear();
            FillComboBoxes(comboBoxYear, years);
            comboBoxMonth.Items.Clear();
            comboBoxMonth.Items.AddRange(new object[] { "ماه" });
            comboBoxMonth.SelectedIndex = 0;
            comboBoxDay.Items.Clear();
            comboBoxDay.Items.AddRange(new object[] { "روز" });
            comboBoxDay.SelectedIndex = 0;
        }

        private void comboBoxMonth_Enter(object sender, EventArgs e)
        {
            if (comboBoxYear.SelectedItem.ToString() != "سال")
            {
                comboBoxMonth.Items.Clear();
                List<object> Mounth = new List<object>() { "فروردین", "اردیبهشت", "خرداد", "تیر", "مرداد", "شهریور", "مهر", "آبان", "آذر", "دی", "بهمن", "اسفند" };
                if (comboBoxMonth.Items.Count < 2)
                {
                    FillComboBoxes(comboBoxMonth, Mounth);
                }
                comboBoxDay.Items.Clear();
                comboBoxDay.Items.AddRange(new object[] { "روز" });
                comboBoxDay.SelectedIndex = 0;
            }
            else if (comboBoxYear.SelectedItem.ToString() == "سال")
            {
                List<object> Month = new List<object>() { "فروردین", "اردیبهشت", "خرداد", "تیر", "مرداد", "شهرویور", "مهر", "آبان", "آذر", "دی", "بهمن", "اسفند" };
                if (comboBoxMonth.Items.Count > 2)
                {
                    comboBoxMonth.Items.Clear();
                    comboBoxMonth.Items.AddRange(new object[] { "ماه" });
                    comboBoxMonth.SelectedIndex = 0;
                }
                comboBoxDay.Items.Clear();
                comboBoxDay.Items.AddRange(new object[] { "روز" });
                comboBoxDay.SelectedIndex = 0;
            }
        }
        void FillComboBoxes(ComboBox c, List<object> list)
        {
            foreach (var item in list)
            {
                c.Items.Add(item);
            }
        }

        private void comboBoxDay_Enter(object sender, EventArgs e)
        {
            if (comboBoxMonth.SelectedItem.ToString() != "ماه")
            {
                if (comboBoxDay.Items.Count < 2)
                {
                    int month = MyCalender.GetMounthNumberBasedMonthName(comboBoxMonth.SelectedItem.ToString());
                    int daysOfMonth = MyCalender.GetNumberOfDaysinSelectedMounth(int.Parse(comboBoxYear.SelectedItem.ToString()), month);
                    List<object> DaysOfMonth = new List<object>();
                    for (int i = 1; i <= daysOfMonth; i++)
                    {
                        DaysOfMonth.Add(i);
                    }
                    FillComboBoxes(comboBoxDay, DaysOfMonth);
                }
            }
            else if (comboBoxMonth.SelectedItem.ToString() == "ماه")
            {
                if (comboBoxDay.Items.Count > 2)
                {
                    comboBoxDay.Items.Clear();
                    comboBoxDay.Items.AddRange(new object[] { "روز" });
                    comboBoxDay.SelectedIndex = 0;
                }
            }
        }

        private void comboBoxVaccineName_Enter(object sender, EventArgs e)
        {
            string vaccineName = patient.VaccineName;
            if (comboBoxVaccineName.SelectedItem.ToString() == "انتخاب کنید")
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    FillComboBoxes(comboBoxVaccineName, db.VaccinRepository.GetObjectiveVaccineNames());
                    bool key = false;
                    foreach (var item in db.VaccinRepository.GetVaccineNames())
                    {
                        if (vaccineName == item)
                            key = true;
                    }
                    if (!key)
                        comboBoxVaccineName.Items.Add(vaccineName);
                }
            }
            else
            {
                comboBoxVaccineName.Items.Clear();
                using (UnitOfWork db = new UnitOfWork())
                {
                    FillComboBoxes(comboBoxVaccineName, db.VaccinRepository.GetObjectiveVaccineNames());
                    bool key = false;
                    foreach (var item in db.VaccinRepository.GetVaccineNames())
                    {
                        if (vaccineName == item)
                            key = true;
                    }
                    if (key)
                        comboBoxVaccineName.Text = vaccineName;
                    else
                    {
                        comboBoxVaccineName.Items.Add(vaccineName);
                        comboBoxVaccineName.Text = vaccineName;
                    }
                }

            }

        }

        bool BirthDateValidation()
        {
            if (comboBoxDay.SelectedItem.ToString() == "روز" || comboBoxMonth.SelectedItem.ToString() == "ماه" || comboBoxYear.SelectedItem.ToString() == "سال")
            {
                RtlMessageBox.Show("لطفا تاریخ تولد را به درستی وارد کنید.", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
                return true;
        }
        bool VaccineNameValidation()
        {
            if (comboBoxVaccineName.SelectedItem.ToString() == "انتخاب کنید")
            {
                RtlMessageBox.Show("لطفا نوع واکسن را انتخاب کنید.", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
                return true;
        }
        bool RadioButtonsChekValidation()
        {
            if (!radioButtonMale.Checked && !radioButtonFemale.Checked)
            {
                RtlMessageBox.Show("لطفا جنسیت را انتخاب کنید.", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
                return true;
        }
        bool ChekBosxesValidation()
        {
            if (checkBoxFirstDoze.Checked)
                return true;
            else
            {
                RtlMessageBox.Show("لطفا شماره دوز را انتخاب کنید.", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
        bool DateFormatValidation(int year, int month, int day, string doze)
        {

            if (year > MyCalender.GetThisYearNumber() + 1)
            {
                RtlMessageBox.Show($" لطفا تاریخی معتبر برای تزریق دوز {doze} وارد کنید.", "هشدار", MessageBoxButtons.OK);
                return false;
            }
            if (month < 1 || month > 12)
            {
                RtlMessageBox.Show($" لطفا تاریخی معتبر برای تزریق دوز {doze} وارد کنید.", "هشدار", MessageBoxButtons.OK);
                return false;
            }
            if (day < 1 || day > MyCalender.GetNumberOfDaysinSelectedMounth(year, month))
            {
                RtlMessageBox.Show($" لطفا تاریخی معتبر برای تزریق دوز {doze} وارد کنید.", "هشدار", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }
        bool DateValueValidation(string firstDozeDate, string secondDozeDate)
        {
            if (MyCalender.CompareDates(firstDozeDate, secondDozeDate))
                return true;
            else
            {
                RtlMessageBox.Show("تاریخ تزریق دوز دوم نامعتبر است. دقت کنید که دوز دوم حداقل بیست و یک روز پس از دوز اول باید تزریق شود.", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        private void txtPatientId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'آ' && e.KeyChar <= 'ی'))
                e.Handled = true;
        }

        private void txtTelNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'آ' && e.KeyChar <= 'ی'))
                e.Handled = true;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                if (RadioButtonsChekValidation() && BirthDateValidation() && VaccineNameValidation() && ChekBosxesValidation())
                {
                    if (txtDayOfSecondDoze.ReadOnly == false && txtMonthOfSecondDoze.ReadOnly == false && txtYearOfSecondDoze.ReadOnly == false)
                    {
                        if (DateFormatValidation(int.Parse(txtYearOfSecondDoze.Text), int.Parse(txtMonthOfSecondDoze.Text), int.Parse(txtDayOfSecondDoze.Text), "دوم") && DateValueValidation(lblFirstDozeDate.Text, $"{txtYearOfSecondDoze.Text}/{txtMonthOfSecondDoze.Text}/{txtDayOfSecondDoze.Text}"))
                        {
                            patient.ScondDoseDate = $"{txtYearOfSecondDoze.Text}/{txtMonthOfSecondDoze.Text}/{txtDayOfSecondDoze.Text}";
                            SetNewDatas();
                            using (UnitOfWork db = new UnitOfWork())
                            {
                                if (db.PatientsRepository.Update(patient) && db.Save())
                                {

                                    RtlMessageBox.Show("عملیات با موفقیت انجام شد.", "تبریک", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    frmAdmin_ListPatient frm = new frmAdmin_ListPatient();
                                    frm.ShowDialog();
                                    this.Close();
                                }
                            }
                        }

                    }
                    else
                    {
                        SetNewDatas();
                        using (UnitOfWork db = new UnitOfWork())
                        {
                            if (db.PatientsRepository.Update(patient) && db.Save())
                            {
                                RtlMessageBox.Show("عملیات با موفقیت انجام شد.", "تبریک", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                frmAdmin_ListPatient frm = new frmAdmin_ListPatient();
                                frm.ShowDialog();
                                this.Close();
                            }
                        }
                    }
                }
            }
        }

        private void checkBoxFirstDoze_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFirstDoze.Checked == false)
            {
                RtlMessageBox.Show("شما مجاز به نامعتبر کردن این بخش نیستید!", "", MessageBoxButtons.OK);
                checkBoxFirstDoze.Checked = true;
            }

        }
        void Clear()
        {
            txtName.Text = null;
            txtFamilyName.Text = null;
            txtAddress.Text = null;
            txtTelNum.Text = null;
            comboBoxDay.Items.Clear();
            comboBoxDay.Items.AddRange(new object[] { "روز" });
            comboBoxDay.SelectedIndex = 0;
            comboBoxMonth.Items.Clear();
            comboBoxMonth.Items.AddRange(new object[] { "ماه" });
            comboBoxMonth.SelectedIndex = 0;
            comboBoxYear.Items.Clear();
            comboBoxYear.Items.AddRange(new object[] { "سال" });
            comboBoxYear.SelectedIndex = 0;
            comboBoxVaccineName.Items.Clear();
            comboBoxVaccineName.Items.Add("انتخاب کنید");
            comboBoxVaccineName.SelectedIndex = 0;
            radioButtonMale.Checked = false;
            radioButtonFemale.Checked = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void txtDayOfSecondDoze_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'آ' && e.KeyChar <= 'ی'))
                e.Handled = true;
        }

        private void txtMonthOfSecondDoze_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'آ' && e.KeyChar <= 'ی'))
                e.Handled = true;
        }

        private void txtYearOfSecondDoze_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'آ' && e.KeyChar <= 'ی'))
                e.Handled = true;
        }

        private void checkBoxSecondDoze_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSecondDoze.Checked)
            {
                List<string> SecondDozeDate = patient.ScondDoseDate.Split('/').ToList();
                txtDayOfSecondDoze.ReadOnly = false;
                txtDayOfSecondDoze.Text = SecondDozeDate[2];
                txtMonthOfSecondDoze.ReadOnly = false;
                txtMonthOfSecondDoze.Text = SecondDozeDate[1];
                txtYearOfSecondDoze.ReadOnly = false;
                txtYearOfSecondDoze.Text = SecondDozeDate[0];
            }
            if (!checkBoxSecondDoze.Checked)
            {
                txtDayOfSecondDoze.ReadOnly = true;
                txtDayOfSecondDoze.Text = null;
                txtMonthOfSecondDoze.ReadOnly = true;
                txtMonthOfSecondDoze.Text = null;
                txtYearOfSecondDoze.ReadOnly = true;
                txtYearOfSecondDoze.Text = null;
            }
        }
    }
}
