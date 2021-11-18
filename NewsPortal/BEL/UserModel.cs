using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class UserModel
    {
        public int UId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Type { get; set; }

        public virtual News News { get; set; }
    }
}
