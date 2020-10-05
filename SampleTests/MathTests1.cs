using System.Linq;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests1
{
    [TestFixture]
    public class MathTests1
    {
        private Math _math;
        //SetUp
        //TearDown
        //using setup method we dont need all the time making variables like ' var math = new Math(); '
        [SetUp]
        public void SetUp()
        { 
            _math = new Math();        
        }
        [Test]
        //[Ignore("Because i wanted to !!!")]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        { 
            //Act
            var result = _math.Add(1, 2);

            //Assert
            Assert.That(result,Is.EqualTo(3));
            //Assert.That(_math, Is.Not.Null); // it is always run. || it makes test your tests.
        }
        /*LongerWay
        [Test]
        public void Max_FirstArgumentIsGreater_ReturnsFirstArgument()
        {
            //Arrange
            //var math = new Math();
            
            //Act
            var result = _math.Max(2, 1);
            
            //Assert
            Assert.That(result, Is.EqualTo(2));
        }
        
        [Test]
        public void Max_SecondArgumentIsGreater_ReturnsSecondArgument()
        {
            //Arrange
            //var math = new Math();
            
            //Act
            var result = _math.Max(1, 2);
            
            //Assert
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Max_ArgumentsAreSame_ReturnsSameArgument()
        {
            //Arrange
            //var math = new Math();
            
            //Act
            var result = _math.Max(1, 1);
            
            //Assert
            Assert.That(result, Is.EqualTo(1));
        }
        */

        //ShorterWay
        [Test]
        [TestCase(1,2,2)]
        [TestCase(2,1,2)]
        [TestCase(1,1,1)]
        public void Max_WhenCalled_ReturnsGreaterArgument(int a,int b,int expectedResult)
        {
            var result =  _math.Max(a, b);
            Assert.That(result,Is.EqualTo(expectedResult));
        }

        [Test]
        public void GetOddNumbers_LimitsIsGreaterThanZero_ReturnOddNumbersUpToLimit()
        {
            var result = _math.GetOddNumbers(5);

            //so general
            //Assert.That(result, Is.Not.Empty);
            //Assert.That(result.Count(), Is.EqualTo(3));

            //suggested way
            // Assert.That(result, Does.Contain(1));
            // Assert.That(result, Does.Contain(3));
            // Assert.That(result, Does.Contain(5));
                
            //Shorter the same way
            Assert.That(result,Is.EquivalentTo(new [] {1,3,5}));

            // Assert.That(result, Is.Ordered);
            // Assert.That(result, Is.Unique);

        }
    }
}