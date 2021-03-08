using System;

namespace DataModels
{
    public class ProductDiscount
    {
        public int Id { get; set; }
        public double DiscountPercent { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
