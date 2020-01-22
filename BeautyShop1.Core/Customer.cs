using System;
using System.ComponentModel.DataAnnotations;

namespace BeautyShop1.Core
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Display (Name = "Membership Type")]
        public int? MembershipId { get; set; }
        public bool IsMember {
            get
            {
                return Membership != null;
            } 
        }
        public Membership Membership { get; set; }
    }
}
