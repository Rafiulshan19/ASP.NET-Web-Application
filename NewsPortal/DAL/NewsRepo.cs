using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NewsRepo
    {
        static NEWS2Entities db;
        static NewsRepo()
        {
            db = new NEWS2Entities();
        }
        
        public static void Add(News s)
        {
            db.News.Add(s);
            db.SaveChanges();
        }
        public static void Edit(int id)
        {
            var ds =db.News.FirstOrDefault(e => e.Id == id);
            db.Entry(ds).CurrentValues.SetValues(id);
            db.SaveChanges();
        }
        public static void Delete(int id)
        {
            var ds = db.News.FirstOrDefault(e => e.Id == id);
            db.News.Remove(ds);
            db.SaveChanges();
        }
        public static List<News> Get()
        {
            return db.News.ToList();
        }
        public static News Get(int id)
        {
            return db.News.FirstOrDefault(e => e.Id == id);
        }
    }
}
