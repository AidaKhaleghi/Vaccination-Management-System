using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CoronaVaccinationSystem.DataLayer.Repositoreis
{
    public class DeputiesRepository : IDeputiesRepository
    {
        Covid19_DBEntities db = new Covid19_DBEntities();
        public DeputiesRepository(Covid19_DBEntities context)
        {
            db = context;
        }

        public bool AddDeputy(string userName, string passWord)
        {
            Deputies deputy = new Deputies() { UserName = userName, PassWord = passWord };
            try
            {
                db.Entry(deputy).State = EntityState.Added;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Deputies> GetDeputiesList()
        {
            return db.Deputies.ToList();
        }
    }
}
