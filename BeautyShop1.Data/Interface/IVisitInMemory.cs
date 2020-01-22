using BeautyShop1.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeautyShop1.Data.Interface
{
    public interface IVisitInMemory
    {
        Visit GetVisit(int id);
        IEnumerable<Visit> GetVisits(string name = null);
        Visit AddVisit(Visit visit);
        Visit Update(Visit visit);
    }
}
