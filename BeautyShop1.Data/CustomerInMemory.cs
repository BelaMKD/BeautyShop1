using BeautyShop1.Core;
using BeautyShop1.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeautyShop1.Data
{
    public class CustomerInMemory : ICustomerInMemory
    {
        private List<Customer> customers;
        public CustomerInMemory()
        {
            customers = new List<Customer>();
        }
        public int Commit()
        {
            return 0;
        }

        public Customer Create(Customer customer)
        {
            customer.Id = customers.Any() ? customers.Max(x => x.Id) + 1 : 1;
            customers.Add(customer);
            return customer;
        }

        public Customer GetCustomer(int id)
        {
            return customers.SingleOrDefault(x => x.Id == id);
        }

        public IEnumerable<Customer> GetCustomers(string name = null)
        {
            return customers.Where(x => string.IsNullOrEmpty(name) || x.FirstName.ToLower().StartsWith(name.ToLower()) || x.LastName.ToLower().StartsWith(name.ToLower()));
        }

        public Customer Update(Customer customer)
        {
            var tempCustomer = customers.SingleOrDefault(x => x.Id == customer.Id);
            if (tempCustomer!=null)
            {
                tempCustomer.FirstName = customer.FirstName;
                tempCustomer.LastName = customer.LastName;
                tempCustomer.MembershipId = customer.MembershipId;
                tempCustomer.Membership = customer.Membership;
            }
            return tempCustomer;
        }
    }
}
