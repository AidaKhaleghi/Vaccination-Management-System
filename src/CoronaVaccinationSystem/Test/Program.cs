using CoronaVaccinationSystem.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (UnitOfWork db = new UnitOfWork())
            //{
                //Patients p1 = new Patients() { Name = "مهدی یار", LastName = "Poursalari", BirthDate = "test", FirstDose = true, FirstDoseDate = "test", Gender = "test", PatientId = 5420064985, Phone = 0633200, ScondDoseDate = "test", SecondDoze = false, Vaccinename = "test" };
                //db.PatientsRepository.AddPatient(p1);
                //db.Save();

                //var list2 = db.PatientsRepository.Filter("542006498");
                //Patients p2 = db.PatientsRepository.GetPatientById(5420064996);
                //p2.Vaccinename = "آسترازنکا";
                //db.PatientsRepository.Update(p2);
                //db.PatientsRepository.Delete(p2);
                // db.Save();
                //var list = db.PatientsRepository.GetAllPatients();
                //Vaccines v = new Vaccines() { VaccineName = "آسترازنکا", EntryDose = 30000000 };
                //db.VaccinRepository.AddNewVaccine(v);
                //db.Save();
                //var list = db.VaccinRepository.GetAllVaccines();
                //var p = db.VaccinRepository.VaccineType("آسترازنکا");
                //var list = db.VaccinRepository.GetVaccineNames();
           // }
            //    Covid19_DBEntities db = new Covid19_DBEntities();
            //Admins[] list = db.Admins.ToArray();
            //Admins admin = new Admins();
            //admin = list[0];
            //db.Admins.Remove(admin);
            //using (UnitOfWork db = new UnitOfWork())
            //{
            //    db.AdminsRepository.AddAdmins("admin", "admin");
            //    db.DeputiesRepository.AddDeputy("deputy", "deputy");
            //    bool a = db.Save();
            //}

        }
    }
}
