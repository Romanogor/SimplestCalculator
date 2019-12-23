using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimplestCalculator.UnitTests
{
    [TestFixture]
    class CalculatorTests
    {
        [Test]
        public void Add_GoodParameters_ReturnSum()
        {
            //Arrange
            ILoggerManager loggerManager = new FakeLoggerManager();
            Calculator calculator = new Calculator(loggerManager);

            //Act
            var result = calculator.Add("4", "7");

            //Assert
            Assert.True(result == 11);
        }



        [Test]
        public void Add_InValidFirstParameter_ReturnNull()
        {
            //Arrange
            ILoggerManager loggerManager = new FakeLoggerManager();
            Calculator calculator = new Calculator(loggerManager);

            //Act
            var result = calculator.Add("sdf", "2");

            //Assert
            Assert.True(result == null);
            
        }

        [Test]
        public void Add_InValidSecondParameter_ThrowException()
        {
            //Arrange
            ILoggerManager loggerManager = new FakeLoggerManager();
            Calculator calculator = new Calculator(loggerManager);

            //Act
            var ex = Assert.Catch<Exception>(
                () => calculator.Add("3", "ase"));

            //Assert
            StringAssert.Contains("Input string was ", ex.Message);



        }

        [Test]
        public void Substruct_GoodParameters_ReturnSubstructResult()
        {
            //Arrange
            ILoggerManager loggerManager = new FakeLoggerManager();
            Calculator calculator = new Calculator(loggerManager);

            //Act
            var result = calculator.Substruct("44", "27");

            //Assert
            Assert.True(result == 17);
        }



        [Test]
        public void Substruct_InValidFirstParameter_ReturnNull()
        {
            //Arrange
            ILoggerManager loggerManager = new FakeLoggerManager();
            Calculator calculator = new Calculator(loggerManager);

            //Act
            var result = calculator.Substruct("sdf", "4");

            //Assert
            Assert.True(result == null);
            
        }

        [Test]
        public void Substruct_InValidSecondParameter_ThrowException()
        {
            //Arrange
            ILoggerManager loggerManager = new FakeLoggerManager();
            Calculator calculator = new Calculator(loggerManager);

            //Act
            var ex = Assert.Catch<Exception>(
                () => calculator.Substruct("3", "ase"));

            //Assert
            StringAssert.Contains("Input string was ", ex.Message);



        }

        [Test]
        public void Multiply_GoodParameters_ReturnMultiplyResult()
        {
            //Arrange
            ILoggerManager loggerManager = new FakeLoggerManager();
            Calculator calculator = new Calculator(loggerManager);

            //Act
            var result = calculator.Multiply("4", "7");

            //Assert
            Assert.True(result == 28);
        }



        [Test]
        public void Multiply_InValidFirstParameter_ReturnNull()
        {
            //Arrange
            ILoggerManager loggerManager = new FakeLoggerManager();
            Calculator calculator = new Calculator(loggerManager);

            //Act
            var result = calculator.Multiply("sdf", "4");

            //Assert
            Assert.True(result == null);
            
        }

        [Test]
        public void Multiply_InValidSecondParameter_ThrowException()
        {
            //Arrange
            ILoggerManager loggerManager = new FakeLoggerManager();
            Calculator calculator = new Calculator(loggerManager);

            //Act
            var ex = Assert.Catch<Exception>(
                () => calculator.Multiply("3", "ase"));

            //Assert
            StringAssert.Contains("Input string was ", ex.Message);



        }

        [Test]
        public void Divide_GoodParameters_ReturnDivideResult()
        {
            //Arrange
            ILoggerManager loggerManager = new FakeLoggerManager();
            Calculator calculator = new Calculator(loggerManager);

            //Act
            var result = calculator.Divide("8", "2");

            //Assert
            Assert.True(result == 4);
        }



        [Test]
        public void Divide_InValidFirstParameter_ReturnNull()
        {
            //Arrange
            ILoggerManager loggerManager = new FakeLoggerManager();
            Calculator calculator = new Calculator(loggerManager);

            //Act
            var result = calculator.Divide("sdf", "4");

            //Assert
            Assert.True(result == null);
            
        }

        [Test]
        public void Divide_InValidSecondParameter_ThrowException()
        {
            //Arrange
            ILoggerManager loggerManager = new FakeLoggerManager();
            Calculator calculator = new Calculator(loggerManager);

            //Act
            var ex = Assert.Catch<Exception>(
                () => calculator.Divide("3", "ase"));

            //Assert
            StringAssert.Contains("Input string was ", ex.Message);



        }

        [Test]
        public void Divide_SecondParameterIsZero_ThrowDivideByZeroException()
        {
            //Arrange
            ILoggerManager loggerManager = new FakeLoggerManager();
            Calculator calculator = new Calculator(loggerManager);

            //Act
            var ex = Assert.Catch<DivideByZeroException>(
                () => calculator.Divide("3", "0"));

            //Assert
            StringAssert.Contains("divide by zero", ex.Message);



        }
    }

    public class FakeLoggerManager : ILoggerManager
    {
        public void LogMessage(string message)
        {
            //throw new NotImplementedException();
        }
    }
}
