using CoronaVaccinationSystem.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaVaccinationSystem.Utility
{
    public class LoginVaidations
    {
        public static bool AdminsValidation(string userName, string password)
        {
            List<Admins> AdminsList = new List<Admins>();
            using(UnitOfWork db = new UnitOfWork())
            {
                AdminsList = db.AdminsRepository.GetAdminsList();
            }
            foreach (var item in AdminsList)
            {
                if (userName == item.UserName.Trim() && password == item.PassWord.Trim())
                    return true; 
            }
            return false;

        }
        public static bool DeputeisValidation(string userName, string password)
        {
            List<Deputies> DeputiesList = new List<Deputies>();
            using (UnitOfWork db = new UnitOfWork())
            {
                DeputiesList = db.DeputiesRepository.GetDeputiesList();
            }
            foreach (var item in DeputiesList)
            {
                if (userName == item.UserName.Trim() && password == item.PassWord.Trim())
                    return true;
            }
            return false;
        }
    }
}
