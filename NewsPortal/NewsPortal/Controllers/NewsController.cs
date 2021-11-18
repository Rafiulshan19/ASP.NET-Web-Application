using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NewsPortal.Controllers
{
    public class NewsController : ApiController
    {
        [Route("api/News/Titles")]
        [HttpGet]
        public List<string> GetTitles()
        {
            return NewsService.GetTitles();
        }
        [Route("api/News/All")]
        [HttpGet]
        public List<NewsModel> GetAll()
        {
            return NewsService.Get();
        }
        [Route("api/News/Create")]
        [HttpPost]
        public void Add(NewsModel s)
        {
            NewsService.Add(s);
        }
    }
}
