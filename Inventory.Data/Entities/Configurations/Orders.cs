using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Customer.Data.Entities.Configurations
{
    [Table("Orders")]
    public class Orders
    {
        public long ORD_ID { get; set; }
        public int CUST_ID { get; set; }
    }
}
