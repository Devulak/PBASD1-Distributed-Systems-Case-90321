using System;
using System.Collections.Generic;
using System.Text;

namespace DataModels
{
    public class ProductImage
    {
        public int Id { get; set; }
        public byte[] Image { get; set; }

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
