using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserRepo : IRepository<User, int>
    {
        NEWS2Entities db;
        public UserRepo(NEWS2Entities db)
        {
            this.db = db;
        }
        public void Add(User e)
        {
            db.Users.Add(e);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var e = db.Users.FirstOrDefault(en => en.UId == id);
            db.Users.Remove(e);
            db.SaveChanges();
        }

        public void Edit(User e)
        {
            var d = db.Users.FirstOrDefault(en => en.UId == e.UId);
            db.Entry(d).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public List<User> Get()
        {
            return db.Users.ToList();
        }

        public User Get(int id)
        {
            return db.Users.FirstOrDefault(e => e.UId == id);
        }
    }
}

