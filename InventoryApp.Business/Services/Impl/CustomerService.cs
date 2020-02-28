using Customer.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomerApp.Business.Services.Impl
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomersRepository _customersRepository;
        public delegate void GetNNumbers();
        public CustomerService(ICustomersRepository customersRepository)
        {
            this._customersRepository = customersRepository;
        }

        public IEnumerable<Customer.Data.Entities.Configurations.Customer> GetFirstFiveCustomers()
        {
            return _customersRepository.GetAll().Take(5);
        }

    }
}
