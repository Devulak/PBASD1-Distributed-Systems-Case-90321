using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataModels
{
    public enum GenderEnum
    {
        Unisex = 0,
        Male = 1,
        Female = 2,
        Kids = 3
    }

    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public GenderEnum Gender { get; set; }
        public virtual IEnumerable<ProductImage> Images { get; set; }
        public virtual IEnumerable<ProductDiscount> ProductDiscounts { get; set; }
        public virtual IEnumerable<ProductConfiguration> ProductConfigurations { get; set; }

        public int ClothingTypeId { get; set; }
        public ClothingType ClothingType { get; set; }
    }
}
