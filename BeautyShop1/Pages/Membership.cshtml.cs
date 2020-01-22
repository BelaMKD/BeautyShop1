using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeautyShop1.Core;
using BeautyShop1.Data.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BeautyShop1.Pages
{
    public class MembershipModel : PageModel
    {
        private readonly IMembershipInMemory membershipInMemory;
        public IEnumerable<Membership> Memberships { get; set; }
        public MembershipModel(IMembershipInMemory membershipInMemory)
        {
            this.membershipInMemory = membershipInMemory;
        }
        public void OnGet()
        {
            Memberships = membershipInMemory.GetMemberships();
        }
    }
}