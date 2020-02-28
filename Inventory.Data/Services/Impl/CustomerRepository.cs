using Customer.Data.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Customer.Data.Services.Impl
{
    public class CustomerRepository : ICustomersRepository
    {
        private readonly CustomerDbContext _customerDbContext;

        public CustomerRepository(CustomerDbContext customerDbContext)
        {
            this._customerDbContext = customerDbContext;
        }

        public IEnumerable<Customer.Data.Entities.Configurations.Customer> GetAll()
        {
            return _customerDbContext.Customers.ToList();
        }

        public void Save(Customer.Data.Entities.Configurations.Customer customer)
        {
            _customerDbContext.Customers.Where(cust => cust.ID == 101);
        }
    }
}
