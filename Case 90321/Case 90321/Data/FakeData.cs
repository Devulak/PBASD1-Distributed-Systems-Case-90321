using Bogus;
using DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Case_90321.Data
{
    public class FakeData
    {
        public int ClothingTypeId = 1;
        public List<ClothingType> ClothingTypes = new List<ClothingType>();

        public int ProductId = 1;
        public List<Product> Products = new List<Product>();

        private Faker f;


        public FakeData()
        {
            f = new Faker();

            GenerateClothingTypes(f.Random.Number(8, 12));
        }

        private void GenerateClothingTypes(int blogCount)
        {
            for (var i = 0; i < blogCount; i++, ClothingTypeId++)
            {
                var clothingTypes = new ClothingType
                {
                    Id = ClothingTypeId,
                    Name = f.Commerce.ProductAdjective()
                };

                ClothingTypes.Add(clothingTypes);

                GenerateProduct(clothingTypes, f.Random.Number(20, 50));
            };
        }

        private void GenerateProduct(ClothingType b, int postCount)
        {
            for (var i = 0; i < postCount; i++, ProductId++)
            {
                var product = new Product
                {
                    Id = ProductId,
                    ClothingTypeId = b.Id,
                    Name = f.Commerce.ProductName(),
                    Description = f.Commerce.ProductDescription(),
                    Gender = f.PickRandom<GenderEnum>()
            };

                Products.Add(product);
            }
        }
    }
}
