using System;
using System.Collections.Generic;
using System.Text;

namespace BeautyShop1.Core
{
    public class Premium : Membership
    {
        public Premium()
        {
            Id = 4;
        }
        public override double ServiceDiscount()
        {
            return 0.2;
        }
        public override string GetMembershipType()
        {
            return "Premium";
        }
    }
}
