using Customer.Data.DataAccess;
using Customer.Data.Entities.Configurations;
using Customer.Data.Services;
using Customer.Data.Services.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomerApp.Business.Services.Impl
{
    public class OrdersService : IOrdersService
    {
        private readonly IOrdersRepository _ordersRepository;
        public OrdersService(IOrdersRepository ordersRepository)
        {
            this._ordersRepository = ordersRepository;
        }

        public IEnumerable<Customer.Data.Entities.Configurations.Orders> GetAll()
        {
            return _ordersRepository.GetAllOrders();
        }


    }
}
