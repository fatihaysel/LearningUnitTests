using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests1
{
    [TestFixture]
    public class CustomerControllerTests
    {
        public void GetCustomer_IdIsZero_ReturnNotFound()
        {
            //Arrange
            var controller = new CustomerController();
            
            //Act
            var result = controller.GetCustomer(0);
            
            //Assert - Not Found
            Assert.That(result, Is.TypeOf<NotFound>());
            
            //Not Found or one of its derivative
            //Assert.That(result, Is.InstanceOf<NotFound>());
        }
        
        
    }
}