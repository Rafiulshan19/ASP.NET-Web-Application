using BLL.BEnt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DAL;

namespace BLL
{
    public class NewsService
    {
        public static List<NewsModel> Get()
        {
            var config = new MapperConfiguration(c =>
              {
                  c.CreateMap<News, NewsModel>();
                  c.CreateMap<Category, CategoryModel>();
              }
            );
            var mapper = new Mapper(config);
            var data = mapper.Map<List<NewsModel>>(NewsRepo.Get());
            return data;
        }
        public static List<string> GetTitles()
        {
            var data = NewsRepo.Get().Select(e => e.Title).ToList();
            return data;
        }
        /*
        public static List<string> GetDetails()
        {
            var data = NewsRepo.Get().Select(e => e.Detail).ToList();
            return data;
        }*/
        public static void Add(NewsModel s)
        {
            var config = new MapperConfiguration(c => 
            {
                c.CreateMap<NewsModel, News>();
            }
            );
            var mapper = new Mapper(config);
            var data = mapper.Map<News>(s);
            NewsRepo.Add(data);
        }
    }
}