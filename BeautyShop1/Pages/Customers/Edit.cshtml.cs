using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeautyShop1.Core;
using BeautyShop1.Data.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BeautyShop1.Pages.Customers
{
    public class EditModel : PageModel
    {
        private readonly ICustomerInMemory customerInMemory;
        private readonly IMembershipInMemory membershipInMemory;
        [BindProperty]
        public Customer Customer { get; set; }
        public List<SelectListItem> Memberships { get; set; }
        public EditModel(ICustomerInMemory customerInMemory, IMembershipInMemory membershipInMemory)
        {
            this.customerInMemory = customerInMemory;
            this.membershipInMemory = membershipInMemory;
        }
        public IActionResult OnGet(int? id)
        {
            if (id.HasValue)
            {
                Customer = customerInMemory.GetCustomer(id.Value);
                if (Customer==null)
                {
                    return RedirectToPage("/Customers/List");
                }
            }
            else
            {
                Customer = new Customer();
            }
            Memberships = membershipInMemory.GetMemberships().Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.GetMembershipType()
            }).ToList();
            return Page();
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                var membrshipType = membershipInMemory.GetMembership(Customer.MembershipId);
                Customer.Membership = membrshipType;
                if (Customer.Id == 0)
                {
                    Customer = customerInMemory.Create(Customer);
                }
                else
                {
                    Customer = customerInMemory.Update(Customer);
                }
                return RedirectToPage("/Customers/List");
            }
            else
            {
                Memberships = membershipInMemory.GetMemberships().Select(x => new SelectListItem
                {
                    Value = x.Id.ToString(),
                    Text = x.GetMembershipType()
                }).ToList();
                return Page();
            }
        }
    }
}