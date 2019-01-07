using FluentValidation;
using Xunit;

namespace FluentValidationTest
{
    public class CustomerValidatorTest
    {
        [Fact]
        public void Customer_Must_Have_Postcode()
        {
            var cust = new Customer();
            new CustomerValidator().ValidateAndThrow(cust);
        }
    }
}
