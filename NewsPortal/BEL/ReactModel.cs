using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class ReactModel
    {
        public int Id { get; set; }
        public Nullable<int> Like { get; set; }
        public Nullable<int> Dislike { get; set; }

        public virtual News News { get; set; }
    }
}
