//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class News
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
