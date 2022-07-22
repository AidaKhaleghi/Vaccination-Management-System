using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaVaccinationSystem.DataLayer.Repositoreis
{
    public interface IDeputiesRepository
    {
        List<Deputies> GetDeputiesList();
        bool AddDeputy(string userName, string passWord);
    }
}
