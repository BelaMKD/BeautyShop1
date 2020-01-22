using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeautyShop1.Core;
using BeautyShop1.Data.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BeautyShop1.Pages.Customers
{
    public class ListModel : PageModel
    {
        private readonly ICustomerInMemory customerInMemory;
        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }
        public IEnumerable<Customer> Customers { get; set; }
        public ListModel(ICustomerInMemory customerInMemory)
        {
            this.customerInMemory = customerInMemory;
        }
        public void OnGet()
        {
            Customers = customerInMemory.GetCustomers(SearchTerm);
        }
    }
}