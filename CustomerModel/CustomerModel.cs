using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerModel
{
    public class CustomerModel
    {
        public int ID { get; set; }
        public string CustomerFirstName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
    }
}
