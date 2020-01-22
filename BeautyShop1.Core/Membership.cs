using System;
using System.Collections.Generic;
using System.Text;

namespace BeautyShop1.Core
{
    public abstract class Membership
    {
        public int Id { get; set; }
        public abstract string GetMembershipType();
        public abstract double ServiceDiscount();
        public virtual double ProductDiscount()
        {
            return 10 / 100.0;
        }
    }
}
