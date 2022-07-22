using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CoronaVaccinationSystem.DataLayer.Repositoreis
{
    public class PatientsRepository : IPatientRepository
    {
        Covid19_DBEntities db;
        public PatientsRepository(Covid19_DBEntities context)
        {
            db = context;
        }
        public bool AddPatient(Patients patient)
        {
            try
            {
                db.Entry(patient).State = EntityState.Added;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(Patients patient)
        {
            try
            {
                db.Entry(patient).State = EntityState.Deleted;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(long key)
        {
            try
            {
                Patients patient = db.Patients.Find(key);
                Delete(patient);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Patients> Filter(string patientId)
        {            
            return db.Patients.Where(p => p.PatientId.ToString().Contains(patientId.ToString())).ToList();
        }

        public List<Patients> GetAllPatients()
        {
            return db.Patients.ToList();
        }

        public Patients GetPatientById(long patientId)
        {
            return db.Patients.Find(patientId);
        }

        public bool Update(Patients patient)
        {
            try
            {
                db.Entry(patient).State = EntityState.Modified;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
