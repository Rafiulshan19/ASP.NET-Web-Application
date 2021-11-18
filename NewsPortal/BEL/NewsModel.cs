using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class NewsModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public string Date { get; set; }
        public int UserId { get; set; }
        public int CategoryId { get; set; }
        public int CommentId { get; set; }
        public int ReactId { get; set; }

        public virtual Category Category { get; set; }
        public virtual Comment Comment { get; set; }
        public virtual React React { get; set; }
        public virtual User User { get; set; }
    }
}
