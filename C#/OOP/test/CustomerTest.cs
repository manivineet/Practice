using System;
using ACM.BL;
using Xunit;

namespace test
{
    public class CustomerTest
    {
        [Fact]
        public void FullNameLastNameEmpty()
        {
            //Arrange
            var customer = new Customer()
            {
                FirstName = "Vineet",
                LastName = "Singh"
            };

            var expected = "Singh, Vineet";

            //Act
            var actual = customer.FullName;

            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void StaticTest()
        {
            //-- Arrange
            var c1 = new Customer();
            c1.FirstName = "Bilbo";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Frodo";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Rosie";
            Customer.InstanceCount += 1;

            //-- Act

            //-- Assert
            Assert.Equal(3, Customer.InstanceCount);
        }

        [Fact]
        public void ValidateValid()
        {
            //-- Arrange
            var customer = new Customer
            {
                LastName = "Baggins",
                EmailAddress = "fbaggins@hobbiton.me"
            };

            var expected = true;

            //-- Act
            var actual = customer.Validate();

            //-- Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ValidateMissingLastName()
        {
            //-- Arrange
            var customer = new Customer
            {
                EmailAddress = "fbaggins@hobbiton.me"
            };

            var expected = false;

            //-- Act
            var actual = customer.Validate();

            //-- Assert
            Assert.Equal(expected, actual);
        }


    }
}
