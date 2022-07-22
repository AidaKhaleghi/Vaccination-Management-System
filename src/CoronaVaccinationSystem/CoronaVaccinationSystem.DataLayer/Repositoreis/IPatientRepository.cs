using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaVaccinationSystem.DataLayer.Repositoreis
{
    public interface IPatientRepository
    {
        List<Patients> GetAllPatients();
        bool AddPatient(Patients patient);
        bool Update(Patients patient);
        bool Delete(Patients patient);
        bool Delete(long key);
        List<Patients> Filter(string patientId);
        Patients GetPatientById(long patientId);

    }
}
