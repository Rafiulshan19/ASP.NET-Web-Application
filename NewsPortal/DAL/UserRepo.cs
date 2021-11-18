using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserRepo
    {
        static NEWS2Entities db;
        static UserRepo()
        {
            db = new NEWS2Entities();
        }

        public static void Add(User s)
        {
            db.Users.Add(s);
            db.SaveChanges();
        }
        public static void Edit(int id)
        {
            var ds = db.Users.FirstOrDefault(e => e.UId == id);
            db.Entry(ds).CurrentValues.SetValues(id);
            db.SaveChanges();
        }
        public static void Delete(int id)
        {
            var ds = db.Users.FirstOrDefault(e => e.UId == id);
            db.Users.Remove(ds);
            db.SaveChanges();
        }
        public static List<User> Get()
        {
            return db.Users.ToList();
        }
        public static User Get(int id)
        {
            return db.Users.FirstOrDefault(e => e.UId == id);
        }
    }
}
