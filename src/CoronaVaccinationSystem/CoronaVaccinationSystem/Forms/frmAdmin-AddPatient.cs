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
    public partial class frmAdmin_AddPatient : Form
    {
        public int key = 0;
        public frmAdmin_AddPatient()
        {
            InitializeComponent();
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        void Clear()
        {
            txtName.Text = null;
            txtFamilyName.Text = null;
            txtAddress.Text = null;
            txtPatientId.Text = null;
            txtTelNum.Text = null;
            comboBoxDay.SelectedIndex = 0;
            comboBoxMonth.SelectedIndex = 0;
            comboBoxYear.SelectedIndex = 0;
            comboBoxVaccineName.SelectedIndex = 0;
            radioButtonMale.Checked = false;
            radioButtonFemale.Checked = false;
            checkBoxFirstDoze.Checked = false;
            checkBoxSecondDoze.Checked = false;
        }

        private void frmAdmin_AddPatient_Load(object sender, EventArgs e)
        {
            comboBoxDay.SelectedIndex = 0;
            comboBoxMonth.SelectedIndex = 0;
            List<object> Years = MyCalender.GetYearsForCbYears(); FillComboBoxes(comboBoxYear, Years);
            comboBoxYear.SelectedIndex = 0;
            comboBoxVaccineName.SelectedIndex = 0;
            lblFirstDozeDate.Text = $"{MyCalender.GetThisYearNumber()}/{MyCalender.GetThisMonthNumber()}/{MyCalender.GetTodayNumber()}";
            lblSecondDozeDate.Text = $"{MyCalender.Get21DaysNextFromTodayYearNumber()}/{MyCalender.Get21DaysNextFromTodayMonthNumber()}/{MyCalender.Get21DaysNextFromTodayDayNumber()}";
        }
        void FillComboBoxes(ComboBox c, List<object> list)
        {
            foreach (var item in list)
            {
                c.Items.Add(item);
            }
        }

        private void comboBoxMonth_Enter(object sender, EventArgs e)
        {
            if (comboBoxYear.SelectedItem.ToString() != "سال")
            {
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

        private void comboBoxYear_Enter(object sender, EventArgs e)
        {
            comboBoxMonth.Items.Clear();
            comboBoxMonth.Items.AddRange(new object[] { "ماه" });
            comboBoxMonth.SelectedIndex = 0;
            comboBoxDay.Items.Clear();
            comboBoxDay.Items.AddRange(new object[] { "روز" });
            comboBoxDay.SelectedIndex = 0;
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                if (RadioButtonsChekValidation() && BirthDateValidation() && VaccineNameValidation() && ChekBosxesValidation())
                {
                    {
                        Patients patient = new Patients()
                        {
                            BirthDate = $"{comboBoxYear.SelectedItem}/{MyCalender.GetMounthNumberBasedMonthName(comboBoxMonth.SelectedItem.ToString())}/{comboBoxDay.SelectedItem}",
                            FirstDose = true,
                            FirstDoseDate = lblFirstDozeDate.Text,
                            LastName = txtFamilyName.Text,
                            Name = txtName.Text,
                            PatientId = long.Parse(txtPatientId.Text),
                            Phone = long.Parse(txtTelNum.Text),
                            ScondDoseDate = lblSecondDozeDate.Text,
                            SecondDoze = false,
                            VaccineName = comboBoxVaccineName.SelectedItem.ToString()
                        };
                        if (radioButtonMale.Checked)
                            patient.Gender = radioButtonMale.Text;
                        else
                            patient.Gender = radioButtonFemale.Text;
                        if (txtAddress.Text != null)
                        {
                            patient.Address = txtAddress.Text;
                        }
                        using (UnitOfWork db = new UnitOfWork())
                        {
                            if (db.PatientsRepository.AddPatient(patient))
                            {                                
                                if (db.Save())
                                {
                                    RtlMessageBox.Show("عملیات با موفقیت انجام شد.", "تبریک", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    frmAdmin_ListPatient frm = new frmAdmin_ListPatient();
                                    frm.ShowDialog();
                                    this.Close();                                    
                                }
                                else
                                {
                                    RtlMessageBox.Show("اطلاعات این شخص قبلا در سامانه ثبت شده است.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                            }
                        }

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

        private void checkBoxSecondDoze_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSecondDoze.Checked == true)
            {
                if (!checkBoxFirstDoze.Checked)
                    RtlMessageBox.Show("ابتدا دوز اول را تزریق کنید.", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    RtlMessageBox.Show("لطفا در تاریخ مشخص شده و از قسمت ویرایش در لیست بیماران نسبت به ثبت دوز دوم اقدام کنید.", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            checkBoxSecondDoze.Checked = false;
        }

        private void txtTelNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'آ' && e.KeyChar <= 'ی'))
                e.Handled = true;
        }

        private void comboBoxVaccineName_Enter(object sender, EventArgs e)
        {
            if (comboBoxVaccineName.Items.Count == 1)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    FillComboBoxes(comboBoxVaccineName, db.VaccinRepository.GetObjectiveVaccineNames());
                }
            }
        }

        private void txtPatientId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'آ' && e.KeyChar <= 'ی'))
                e.Handled = true;
        }
    }
}
