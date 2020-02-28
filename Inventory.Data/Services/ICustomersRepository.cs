using System;
using System.Collections.Generic;
using System.Text;

namespace Customer.Data.Services
{
    public interface ICustomersRepository
    {
        IEnumerable<Customer.Data.Entities.Configurations.Customer> GetAll();
    }
}
