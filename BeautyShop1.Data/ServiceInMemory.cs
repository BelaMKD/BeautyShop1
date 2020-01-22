using BeautyShop1.Core;
using BeautyShop1.Data.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeautyShop1.Data
{
    public class ServiceInMemory : IServiceInMemory
    {
        private readonly IProductInMemory productInMemory;

        private List<Service> services;
        private List<Product> products;
        public ServiceInMemory(IProductInMemory productInMemory)
        {
            this.productInMemory = productInMemory;
            products = productInMemory.GetProducts();
            services = new List<Service>()
            {
                new Service
                {
                    Id = 1+products.Count,
                    Name="Hair Cut for men",
                    Price=5.00,
                    Selected=false,
                    ImgPath="cutMen.jpg"
                },
                new Service
                {
                    Id = 2+products.Count,
                    Name="Hair Cut for girls",
                    Price=10.00,
                    Selected=false,
                    ImgPath="cutWomen.jpg"
                },
                new Service
                {
                    Id = 3+products.Count,
                    Name="Manicure",
                    Price=15.00,
                    Selected=false,
                    ImgPath="manicures.jpeg"
                },
                new Service
                {
                    Id = 4+products.Count,
                    Name="Pedicure",
                    Price=25.00,
                    Selected=false,
                    ImgPath="pedicure.jpg"
                },
                new Service
                {
                    Id = 5+products.Count,
                    Name="Nails Polish",
                    Price=10.00,
                    Selected=false,
                    ImgPath="polish.jpg"
                },
                new Service
                {
                    Id = 6+products.Count,
                    Name="Massage",
                    Price=30.00,
                    Selected=false,
                    ImgPath="massage.jpg"
                }

            };
        }

        public List<Service> GetServices()
        {
            return services;
        }
    }
}
