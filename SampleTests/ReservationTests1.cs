using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests1
{
    [TestFixture]
    public class ReservationTests
    {
        [Test]
        public void CanBeCanceledBy_UserIsAdmin_ReturnsTrue() // MethodName_Scenario_ExpectedBehaviour()
        {
            //Arrange
            var reservation = new Reservation();

            //Act
            var result = reservation.CanBeCancelledBy(new User{IsAdmin = true});

            //Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void CanBeCanceledBy_SameUserCanBeCancelingTheReservation_ReturnsTrue()
        {
            //Arrange
            var user = new User();
            var reservation = new Reservation{MadeBy = user};
            
            //Act
            var result = reservation.CanBeCancelledBy(user);
           
            //Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void CanBeCanceledBy_AnotherUserCanBeCancelingReservation_ReturnsFalse()
        {
            //Arrange
            // var user = new User();
            // var reservation = new Reservation{MadeBy = user};
            var reservation = new Reservation{MadeBy = new User()};
            
            //Act
            var result = reservation.CanBeCancelledBy(new User());
             
            //Assert
            Assert.IsFalse(result);
        }
    }
}