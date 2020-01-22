using System;
using System.Collections.Generic;
using System.Text;

namespace BeautyShop1.Core
{
    public class Gold : Membership
    {
        public Gold()
        {
            Id = 3;
        }
        public override double ServiceDiscount()
        {
            return 0.15;
        }
        public override string GetMembershipType()
        {
            return "Gold";
        }
    }
}
