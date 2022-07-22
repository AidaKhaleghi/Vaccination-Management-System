using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace CoronaVaccinationSystem.DataLayer.Repositoreis
{
    class VaccineRepository : IVaccinRepository
    {
        Covid19_DBEntities db;
        public VaccineRepository(Covid19_DBEntities context)
        {
            db = context;
        }

        public bool AddNewVaccine(Vaccines vaccines)
        {
            try
            {
                db.Entry(vaccines).State = EntityState.Added;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Vaccines> GetAllVaccines()
        {
            return db.Vaccines.ToList();
        }

        public List<string> GetVaccineNames()
        {
            return db.Vaccines.Select(v => v.VaccineName).ToList();
        }
        public List<object> GetObjectiveVaccineNames()
        {
            var StringList = GetVaccineNames();
            List<object> ObjectList = new List<object>();
            foreach (var item in StringList)
            {
                ObjectList.Add(item);
            }
            return ObjectList;
        }
        public List<Patients> VaccineType(string vaccineType)
        {
            return db.Patients.Where(p => p.VaccineName.Contains(vaccineType)).ToList();
        }

        public Vaccines GetVaccineById(int VaccineId)
        {
            return db.Vaccines.Find(VaccineId);
        }

        public bool Update(Vaccines vaccine)
        {
            try
            {
                db.Entry(vaccine).State = EntityState.Modified;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(int vaccineId)
        {
            try
            {
                Vaccines vaccine = GetVaccineById(vaccineId);
                Delete(vaccine);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(Vaccines vaccine)
        {
            try
            {
                db.Entry(vaccine).State = EntityState.Deleted;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
