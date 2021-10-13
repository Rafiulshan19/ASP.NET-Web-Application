﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Task1.Models.Entity
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
    }
}