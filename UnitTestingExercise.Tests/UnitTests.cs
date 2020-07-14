using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1,1,2,4)]
        [InlineData(1, 2, 2, 5)]
        [InlineData(1, 3, 2, 6)]
        [InlineData(1, 4, 2, 7)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            UnitTestMethods sut = new UnitTestMethods();
            //Act
            var actual = sut.Addition(num1, num2, num3);
            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(1, 1, 0)]
        [InlineData(4, 2, 2)]
        [InlineData(10, 5, 5)]
        [InlineData(15, 5, 10)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            UnitTestMethods sut = new UnitTestMethods();
            //Act
            var actual = sut.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(1, 2, 2)]
        [InlineData(2, 2, 4)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            UnitTestMethods sut = new UnitTestMethods();
            //Act
            var actual = sut.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(8, 2, 4)]
        [InlineData(20, 2, 10)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            UnitTestMethods sut = new UnitTestMethods();
            //Act
            var actual = sut.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void YourMethodName()
        {
            //Arrange
            UnitTestMethods sut = new UnitTestMethods();
            //Act
            string actual = sut.SayHello();
            //Assert
            Assert.Equal("Hello", actual);
        }

        [Fact]
        public void YourMethodName2()
        {
            //Arrange
            UnitTestMethods sut = new UnitTestMethods();
            //Act
            string actual = sut.SayGoodBye();
            //Assert
            Assert.Equal("Goodbye", actual);
        }   
    }
}
