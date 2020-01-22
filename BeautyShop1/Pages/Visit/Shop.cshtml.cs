using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeautyShop1.Core;
using BeautyShop1.Data.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BeautyShop1.Pages.Visit
{
    public class ShopModel : PageModel
    {
        private readonly IProductInMemory productInMemory;
        private readonly IServiceInMemory serviceInMemory;
        private readonly IVisitInMemory visitInMemory;
        private readonly ICustomerInMemory customerInMemory;
        [BindProperty]
        public List<Product> Products { get; set; }
        [BindProperty]
        public List<Service> Services { get; set; }
        [BindProperty]
        public Core.Visit Visit { get; set; }
        public List<SelectListItem> Customers { get; set; }
        public ShopModel(IProductInMemory productInMemory, IServiceInMemory serviceInMemory, IVisitInMemory visitInMemory, ICustomerInMemory customerInMemory)
        {
            this.productInMemory = productInMemory;
            this.serviceInMemory = serviceInMemory;
            this.visitInMemory = visitInMemory;
            this.customerInMemory = customerInMemory;
        }
        public void OnGet()
        {
            Products = productInMemory.GetProducts();
            Services = serviceInMemory.GetServices();
            Customers = customerInMemory.GetCustomers().Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.FirstName +" " + x.LastName
            }).ToList();
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                var customer = customerInMemory.GetCustomer(Visit.CustomerId.Value);
                Visit.Customer = customer;
                foreach (var product in Products)
                {
                    if (product.Selected)
                    {
                        Visit.AddProduct(product);
                    }
                }
                foreach (var service in Services)
                {
                    if (service.Selected)
                    {
                        Visit.AddService(service);
                    }
                }
                Visit = visitInMemory.AddVisit(Visit);
                return RedirectToPage("/Visit/List");
            }
            else
            {
                Products = productInMemory.GetProducts();
                Services = serviceInMemory.GetServices();
                return Page();
            }
            //var customer = customerInMemory.GetCustomer(Visit.CustomerId.Value);
            //Visit.Customer = customer;
            //foreach (var product in Products)
            //{
            //    if (product.Selected)
            //    {
            //        Visit.AddProduct(product);
            //    }
            //}
            //foreach (var service in Services)
            //{
            //    if (service.Selected)
            //    {
            //        Visit.AddService(service);
            //    }
            //}
            //Visit = visitInMemory.AddVisit(Visit);
            //return RedirectToPage("/Visit/List");
        }
    }
}