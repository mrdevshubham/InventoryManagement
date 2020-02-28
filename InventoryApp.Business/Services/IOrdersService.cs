using Customer.Data.Entities.Configurations;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerApp.Business.Services
{
    public interface IOrdersService
    {
       public IEnumerable<Orders> GetAll();
    }
}
