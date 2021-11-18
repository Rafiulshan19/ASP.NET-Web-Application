using AutoMapper;
using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserService
    {
        public static List<UserModel> Get()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<User, UserModel>();
            }
            );
            var mapper = new Mapper(config);
            var data = mapper.Map<List<UserModel>>(UserRepo.Get());
            return data;
        }
        public static List<string> GetUsername()
        {
            var data = UserRepo.Get().Select(e => e.Username).ToList();
            return data;
        }
        
        public static void Add(UserModel s)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<UserModel, User>();
            }
            );
            var mapper = new Mapper(config);
            var data = mapper.Map<User>(s);
            UserRepo.Add(data);
        }
    }
}
