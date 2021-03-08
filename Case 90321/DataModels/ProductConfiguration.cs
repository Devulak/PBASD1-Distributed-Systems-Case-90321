using System;
using System.Collections.Generic;
using System.Text;

namespace DataModels
{
    public class ProductConfiguration
    {
        public int Id { get; set; }
        public string Size { get; set; }
        public string Colour { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
