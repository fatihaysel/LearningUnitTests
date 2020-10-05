using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests1
{
    [TestFixture]
    public class ErrorLoggerTests
    {
        private ErrorLogger logger;

        [SetUp]
        public void SetUp()
        {
            logger = new ErrorLogger();
        }
        [Test]
        public void Log_WhenCalled_SetTheLastErrorProperty()
        {
            //Act
            logger.Log("a");

            //Assert
            Assert.That(logger.LastError, Is.EqualTo("a"));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void Log_InvalidError_ThrowArgumentNullOrException(string error)
        {
            //Assert
            Assert.That(() => logger.Log(error),Throws.ArgumentNullException);
        }

        [Test]
        public void Log_ValidError_RaiseErrorLoggedEvent()
        { 
            //Arrange
            var id = Guid.Empty;
            logger.ErrorLogged += (sender, args) => { id = args; };
         
            //Act
            logger.Log("a");

            //Assert
            Assert.That(id, Is.Not.EqualTo(Guid.Empty));
        }
    }
}