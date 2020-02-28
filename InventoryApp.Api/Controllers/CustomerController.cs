using System;
using System.Collections.Generic;
using System.Linq;
using CustomerApp.Business.Services;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;

namespace Customer.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private ICustomerService _customerService;
        private IOrdersService _orders;
        private IMapper _mapper;

        public CustomerController(ICustomerService customerService, IOrdersService orders, IMapper mapper)
        {
            this._customerService = customerService;
            _orders = orders;
            this._mapper = mapper;
        }


        [HttpGet("GetCustomers")]
        public IEnumerable<CustomerModel.CustomerModel> GetFirstFiveCustomers()
        {
            var Result = _customerService.GetFirstFiveCustomers();
            return _mapper.Map<List<CustomerModel.CustomerModel>>(Result.ToList()); ;
        }

        [HttpPost("CreateCustomer")]
        public IActionResult POST(Model.CustomerModel customerModel)
        {

            return Ok("Successful Authentication.");
        }


        [HttpGet("GetOrders")]
        public IActionResult GetOrders()
        {
            var Result = _orders.GetAll();
            return Ok(Result);
        }

    }
}