using System;
using FluentAssertions;
using FluentValidation;
using Xunit;

namespace FluentValidationTest
{
    public class CustomerValidatorTest
    {
        [Fact]
        public void Customer_Must_Have_Postcode()
        {
            Action act = () => new CustomerValidator().ValidateAndThrow(new Customer());
            act.Should().Throw<ValidationException>();
        }

        [Fact]
        public void Customer_Group_Must_Have_All_Customers()
        {
            var customers = new CustomerGroup("");
            customers.Customers.Add(new Customer());

            Action act = () => new CustomerValidator().ValidateAndThrow(new Customer());
            act.Should().Throw<ValidationException>();
        }
    }
}
