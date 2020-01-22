using BeautyShop1.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeautyShop1.Data.Interface
{
    public interface ICustomerInMemory
    {
        public Customer GetCustomer(int id);
        public IEnumerable<Customer> GetCustomers(string name = null);
        public Customer Create(Customer customer);
        public Customer Update(Customer customer);
        public int Commit();
    }
}
