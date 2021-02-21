using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPİ.Models.ViewModels
{
    public class ProductVM
    {
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
        public string ImagePath { get; set; }
    }
}