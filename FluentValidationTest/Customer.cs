using System.Collections.Generic;

namespace FluentValidationTest
{
    public class Customer
    {
        public string Surname { get; set; }
        public string Forename { get; set; }
        public string Address { get; set; }
        public string Postcode { get; set; }
        public int Discount { get; set; }
        public bool HasDiscount { get; set; }
    }

    public class CustomerGroup
    {
        public CustomerGroup(string name)
        {
            Name = name;
        }

        public string Name { get;  }
        public ICollection<Customer>  Customers { get; } = new List<Customer>();
    }
}