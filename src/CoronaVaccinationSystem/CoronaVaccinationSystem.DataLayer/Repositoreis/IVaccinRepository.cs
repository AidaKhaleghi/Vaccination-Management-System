using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaVaccinationSystem.DataLayer.Repositoreis
{
    public interface IVaccinRepository
    {
        bool AddNewVaccine(Vaccines vaccines);
        List<Patients> VaccineType(string vaccineType);
        List<Vaccines> GetAllVaccines();
        List<string> GetVaccineNames();
        List<object> GetObjectiveVaccineNames();
        Vaccines GetVaccineById(int VaccineId);
        bool Update(Vaccines vaccine);
        bool Delete(int vaccineId);
        bool Delete(Vaccines vaccine);
    }
}
