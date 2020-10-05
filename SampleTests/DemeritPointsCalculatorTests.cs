using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests1
{
    [TestFixture]
    public class DemeritPointsCalculatorTests
    {
        [Test]
        [TestCase(-1)]
        [TestCase(301)]
        public void CalculateDemeritPoints_InputIsNegativeOrUpperOfThreeHundred_ReturnThrowArgumentOutOfRangeException(int speed)
        {
            //Arrange
            var calculator = new DemeritPointsCalculator();

            //Assert
            Assert.That(() => calculator.CalculateDemeritPoints(speed), Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }
        
        [Test]
        [TestCase(0,0)]
        [TestCase(64,0)]
        [TestCase(65,0)]
        [TestCase(66,0)]
        [TestCase(70,1)]
        [TestCase(75,2)]
        public void CalculateDemeritPoints_WhenCalled_ReturnsDemeritPoints(int speed,int expectedResult)
        {
            //Arrange
            var calculate = new DemeritPointsCalculator();
            
            //Act
            var result = calculate.CalculateDemeritPoints(speed);

            //Assert
            Assert.That(result,Is.EqualTo(expectedResult));
        }
    }
}