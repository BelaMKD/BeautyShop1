using BeautyShop1.Core;
using BeautyShop1.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeautyShop1.Data
{
    public class ProductInMemory : IProductInMemory
    {
        private List<Product> products;
        public ProductInMemory()
        {
            products = new List<Product>()
            {
                new Product
                {
                    Id = 1,
                    Name="Eye Liner",
                    Price=22.00,
                    Selected=false,
                    ImgPath="liner.jpg"
                },
                new Product
                {
                    Id = 2,
                    Name="Eye Shadows",
                    Price=30.00,
                    Selected=false,
                    ImgPath="shadow.jpg"
                },
                new Product
                {
                    Id = 3,
                    Name="Mascara",
                    Price=18.50,
                    Selected=false,
                    ImgPath="mascara.jpg"
                },
                new Product
                {
                    Id = 4,
                    Name="Lipstick",
                    Price=26.00,
                    Selected=false,
                    ImgPath="lipstick.jpg"
                },
                new Product
                {
                    Id = 5,
                    Name="Lip Liner",
                    Price=19.50,
                    Selected=false,
                    ImgPath="lipLiner.jpg"
                },
                new Product
                {
                    Id = 6,
                    Name="Lip Plumper",
                    Price=14.00,
                    Selected=false,
                    ImgPath="plumper.jpg"
                },
                new Product
                {
                    Id = 7,
                    Name="Anti-Dandruff & Scalp Care",
                    Price=19.00,
                    Selected=false,
                    ImgPath="antiDandruff.jpg"
                },
                new Product
                {
                    Id = 8,
                    Name="Shampoo",
                    Price=18.00,
                    Selected=false,
                    ImgPath="shampoo.jpg"
                },
                new Product
                {
                    Id = 9,
                    Name="Hair Oil",
                    Price=28.00,
                    Selected=false,
                    ImgPath="hairOil.jpg"
                },
                new Product
                {
                    Id = 10,
                    Name="Hair Dryer",
                    Price=235.00,
                    Selected=false,
                    ImgPath="hairDryer.jpg"
                },
                new Product
                {
                    Id = 11,
                    Name="Hair Curler",
                    Price=195.00,
                    Selected=false,
                    ImgPath="hairCurler.jpg"
                },
                new Product
                {
                    Id = 12,
                    Name="Flat Iron",
                    Price=180.00,
                    Selected=false,
                    ImgPath="flatIron.jpg"
                }
            };
        }

        public List<Product> GetProducts()
        {
            return products;
        }

        public Product GetProduct(int id)
        {
            return products.SingleOrDefault(x => x.Id == id);
        }
    }
}
