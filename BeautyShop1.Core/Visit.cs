using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BeautyShop1.Core
{
    public class Visit
    {
        public int? Id { get; set; }
        [Required, Display (Name = "Customer")]
        public int? CustomerId { get; set; }
        public Customer Customer { get; set; }
        public List<Product> Products { get; set; }
        public List<Service> Services { get; set; }
        public Visit()
        {
            Products = new List<Product>();
            Services = new List<Service>();
        }
        public void AddProduct(Product product)
        {
            Products.Add(product);
        }
        public void AddService(Service service)
        {
            Services.Add(service);
        }
        public double TotalPay()
        {
            var sum = 0.0;
            foreach (var product in Products)
            {
                if (Customer.IsMember)
                {
                    sum += product.Price * (1 - Customer.Membership.ProductDiscount());
                }
                else
                {
                    sum += product.Price;
                }
            }
            foreach (var service in Services)
            {
                if (Customer.IsMember)
                {
                    sum += service.Price * (1 - Customer.Membership.ServiceDiscount());
                }
                else
                {
                    sum += service.Price;
                }
            }
            return sum;
        }
    }
}
