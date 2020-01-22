using BeautyShop1.Core;
using BeautyShop1.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeautyShop1.Data
{
    public class VisitInMemory : IVisitInMemory
    {
        private List<Visit> visits;
        public VisitInMemory()
        {
            visits = new List<Visit>();
        }
        public Visit AddVisit(Visit visit)
        {
            visit.Id = visits.Any() ? visits.Max(x=>x.Id) + 1 : 1;
            visits.Add(visit);
            return visit;
        }

        public Visit GetVisit(int id)
        {
            return visits.SingleOrDefault(x => x.Id == id);
        }

        public IEnumerable<Visit> GetVisits(string name = null)
        {
            return visits.Where(x=>string.IsNullOrEmpty(name) || x.Customer.FirstName.ToLower().StartsWith(name.ToLower()) || x.Customer.LastName.ToLower().StartsWith(name.ToLower()));
        }

        public Visit Update(Visit visit)
        {
            var tempVisit = visits.SingleOrDefault(x => x.Id == visit.Id);
            if (tempVisit!=null)
            {
                tempVisit.CustomerId = visit.CustomerId;
                tempVisit.Products = visit.Products;
                tempVisit.Services = visit.Services;
            }
            return tempVisit;
        }
    }
}
