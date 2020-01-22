using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeautyShop1.Data.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BeautyShop1.Pages.Visit
{
    public class ListModel : PageModel
    {
        private readonly IVisitInMemory visitInMemory;
        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }
        public IEnumerable<Core.Visit> Visits { get; set; }
        public ListModel(IVisitInMemory visitInMemory)
        {
            this.visitInMemory = visitInMemory;
        }
        public void OnGet()
        {
            Visits = visitInMemory.GetVisits(SearchTerm);
        }
    }
}