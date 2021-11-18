using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class CategoryModel
    {
        public int CId { get; set; }
        public string Cname { get; set; }

        public virtual News News { get; set; }
    }
}
