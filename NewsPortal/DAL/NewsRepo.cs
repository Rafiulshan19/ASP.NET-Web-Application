using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NewsRepo : IRepository<News, int>
    {
        NEWS2Entities db;
        public NewsRepo(NEWS2Entities db)
        {
            this.db = db;
        }
        public void Add(News e)
        {
            db.News.Add(e);
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            var e = db.News.FirstOrDefault(en => en.Id == id);
            db.News.Remove(e);
            db.SaveChanges();
        }

        public void Edit(News e)
        {
            var d = db.News.FirstOrDefault(en => en.Id == e.Id);
            db.Entry(d).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public List<News> Get()
        {
            return db.News.ToList();
        }

        public News Get(int id)
        {
            return db.News.FirstOrDefault(e => e.Id == id);
        }
    }
}
