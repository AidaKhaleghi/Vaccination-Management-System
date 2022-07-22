using CoronaVaccinationSystem.DataLayer.Repositoreis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaVaccinationSystem.DataLayer
{
    public class UnitOfWork:IDisposable
    {
        Covid19_DBEntities db = new Covid19_DBEntities();
        IPatientRepository _patientRepository;
        public IPatientRepository PatientsRepository
        {
            get
            {
                if (_patientRepository == null)
                {
                    _patientRepository = new PatientsRepository(db);
                }
                return _patientRepository;
            }
        }
        IVaccinRepository _vaccineRepository;
        public IVaccinRepository VaccinRepository
        {
            get
            {
                if (_vaccineRepository == null)
                {
                    _vaccineRepository = new VaccineRepository(db);
                }
                return _vaccineRepository;
            }
        }
        IAdminsRepository _adminsRepository;
        public IAdminsRepository AdminsRepository 
        { get
            {
                if (_adminsRepository == null)
                {
                    _adminsRepository = new AdminsRepository(db);
                }
                return _adminsRepository;
            } 
        }
        IDeputiesRepository _deputiesRepository;
        public IDeputiesRepository DeputiesRepository
        {
            get
            {
                if (_deputiesRepository == null)
                {
                    _deputiesRepository = new DeputiesRepository(db);
                }
                return _deputiesRepository;
            }
        }


        public void Dispose()
        {
            db.Dispose();
        }

        public bool Save()
        {
            try
            {
                db.SaveChanges();
                return true;
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException)
            {
                return false;
            }
        }
    }
}
