using BeautyShop1.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeautyShop1.Data.Interface
{
    public interface IMembershipInMemory
    {
        Membership GetMembership(int? id);
        IEnumerable<Membership> GetMemberships();
    }
}
