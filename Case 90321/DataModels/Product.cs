using System;
using System.Collections.Generic;
using System.Text;

namespace DataModels
{
    public enum GenderEnum
    {
        All = 0,
        Male = 1,
        Female = 2
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public GenderEnum Gender { get; set; }
        public ClothingType ClothingType { get; set; }
        public virtual IEnumerable<ProductImage> Images { get; set; }
        public virtual IEnumerable<ProductDiscount> ProductDiscounts { get; set; }
        public virtual IEnumerable<ProductConfiguration> ProductConfigurations { get; set; }
    }
}
