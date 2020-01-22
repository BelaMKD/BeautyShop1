using System;
using System.Collections.Generic;
using System.Text;

namespace BeautyShop1.Core
{
    public class Bronze : Membership
    {
        public Bronze()
        {
            Id = 1;
        }
        public override double ServiceDiscount()
        {
            return 0.05;
        }
        public override string GetMembershipType()
        {
            return "Bronze";
        }
    }
}
