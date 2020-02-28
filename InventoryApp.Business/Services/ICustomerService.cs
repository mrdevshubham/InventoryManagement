using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerApp.Business.Services
{
    public interface ICustomerService
    {

        IEnumerable<Customer.Data.Entities.Configurations.Customer> GetFirstFiveCustomers();

    }
}
