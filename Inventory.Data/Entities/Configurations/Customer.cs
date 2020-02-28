using System.ComponentModel.DataAnnotations.Schema;

namespace Customer.Data.Entities.Configurations
{
    [Table("Customers")]
    public class Customer
    {
        public int ID { get; set; }
        [Column("Name")]
        public string CustomerFirstName { get; set; }
        [Column("Phone")]
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
    }
}
