using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Task1.Models.Entity
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
    }
}