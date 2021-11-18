using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        static NEWS2Entities db;
        static DataAccessFactory()
        {
            db = new NEWS2Entities();
        }
        public static IRepository<News, int> NewsDataAcees()
        {
            return new NewsRepo(db);
        }
        public static IRepository<User, int> UserDataAccess()
        {
            return new UserRepo(db);
        }
    }
}
