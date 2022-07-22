using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaVaccinationSystem.DataLayer.Repositoreis
{
    public interface IAdminsRepository
    {
        List<Admins> GetAdminsList();
        bool AddAdmins(string userName, string password);
    }
}
