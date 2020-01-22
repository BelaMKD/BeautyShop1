using BeautyShop1.Core;
using BeautyShop1.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BeautyShop1.Data
{
    public class MembershipInMemory : IMembershipInMemory
    {
        private List<Membership> memberships;
        public MembershipInMemory()
        {
            memberships = new List<Membership>()
            {
                new Bronze(),
                new Silver(),
                new Gold(),
                new Premium()
            };
        }

        public Membership GetMembership(int? id)
        {
            return memberships.SingleOrDefault(x => x.Id == id);
        }

        public IEnumerable<Membership> GetMemberships()
        {
            return memberships;
        }
    }
}
