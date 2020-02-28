using Customer.Data.DataAccess;
using Customer.Data.Entities.Configurations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Customer.Data.Services
{
    public interface IOrdersRepository
    {
        IEnumerable<Orders> GetAllOrders();
        IEnumerable<Orders> GetCustomerOrders(int CustomerId);

    }
}
