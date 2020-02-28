using Customer.Data.DataAccess;
using Customer.Data.Entities.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Customer.Data.Services.Impl
{
    public class OrdersRepository : IOrdersRepository
    {
        private readonly CustomerDbContext _customerDbContext;
        public OrdersRepository(CustomerDbContext customerDbContext)
        {
            this._customerDbContext = customerDbContext;
        }


        public IEnumerable<Orders> GetAllOrders()
        {
            return _customerDbContext.orders.ToList();
        }

        public IEnumerable<Orders> GetCustomerOrders(int CustomerId)
        {
            return _customerDbContext.orders.Where(x => x.CUST_ID == CustomerId);
        }
    }
}
