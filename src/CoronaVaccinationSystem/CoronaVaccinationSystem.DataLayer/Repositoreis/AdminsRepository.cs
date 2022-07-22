using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CoronaVaccinationSystem.DataLayer.Repositoreis
{
    public class AdminsRepository : IAdminsRepository
    {
        Covid19_DBEntities db = new Covid19_DBEntities();
        public AdminsRepository(Covid19_DBEntities context)
        {
            db = context;
        }
        public List<Admins> GetAdminsList()
        {
            return db.Admins.ToList();
        }
        public bool AddAdmins(string userName, string password)
        {
            Admins admin = new Admins() { UserName = userName, PassWord = password };
            try
            {
                db.Entry(admin).State = EntityState.Added;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
