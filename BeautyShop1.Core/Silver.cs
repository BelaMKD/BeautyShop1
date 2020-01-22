using System;
using System.Collections.Generic;
using System.Text;

namespace BeautyShop1.Core
{
    public class Silver : Membership
    {
        public Silver()
        {
            Id = 2;
        }
        public override double ServiceDiscount()
        {
            return 0.1;
        }
        public override string GetMembershipType()
        {
            return "Silver";
        }
    }
}
