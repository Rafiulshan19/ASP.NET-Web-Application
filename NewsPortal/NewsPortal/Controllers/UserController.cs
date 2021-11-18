using BLL;
using BEL; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NewsPortal.Controllers
{
    public class UserController : ApiController
    {
        [Route("api/User/Username")]
        [HttpGet]
        public List<string> GetUsername()
        {
            return UserService.GetUsername();
        }
        [Route("api/User/All")]
        [HttpGet]
        public List<UserModel> GetAll()
        {
            return UserService.Get();
        }
        [Route("api/User/Create")]
        [HttpPost]
        public void Add(UserModel s)
        {
            UserService.Add(s);
        }
    }
}
