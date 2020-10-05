using System.Collections;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests1
{
    [TestFixture]
    public class StackTests
    {
        [Test]
        public void Push_ObjectIsNull_ReturnThrowArgumentNullException()
        {
            //Arrange
            var stack = new Stack<string>();
            
            //Assert
            Assert.That(() => stack.Push(null), Throws.ArgumentNullException);
        }
        [Test]
        public void Push_ObjectIsNotNull_ReturnAddObjectToList()
        {
            //Arrange
            var stack = new Stack<string>();
            
            //Act
            stack.Push("a");
            
            //Assert
            Assert.That(stack.Count,Is.EqualTo(1));
        }
        [Test]
        public void Push_ObjectIsEmpty_ReturnZero()
        {            
            //Arrange
            var stack = new Stack<string>();

            //Assert
            Assert.That(stack.Count,Is.EqualTo(0));
        }
    }
}