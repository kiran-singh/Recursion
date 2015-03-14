using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;

namespace RecursionDojo.UnitTests
{
    using FluentAssertions;

    using NUnit.Framework;

    [TestFixture]
    public class RecursionFixture
    {
        private Recursion _recursion;
        private Random _random;

        [SetUp]
        public void SetUp()
        {
            _random = new Random();
            _recursion = new Recursion();
        }

        [TestCase(0, 1)]
        [TestCase(2, 2)]
        [TestCase(5, 120)]
        [TestCase(6, 720)]
        public void Factorial_IntegerInput_ResultAsExpected(int input, int expected)
        {
            // Arrange
            // Act
            var actual = _recursion.Factorial(input);

            // Assert
            actual.Should().Be(expected);
        }

        [TestCase(1, 1)]        
        [TestCase(2, 1)]        
        [TestCase(6, 8)]        
        [TestCase(7, 13)]        
        [TestCase(8, 21)]        
        [TestCase(9, 34)]        
        [TestCase(10, 55)]        
        public void Fibonacci_IntegerInput_ResultAsExpected(int input, int expected)
        {
            // Arrange
            // Act
            var actual = _recursion.Fibonacci(input);

            // Assert
            actual.Should().Be(expected);
        }
        
        [Test]
        public void SumOfList_ListInput_ResultAsExpected()
        {
            // Arrange
            var items = new List<int> {1, 2, 3, 4, 5};
            var expected = 15;

            // Act
            var actual = _recursion.SumOfList(items);

            // Assert
            actual.Should().Be(expected);
        }

        [Test]
        public void ItemsInList_ListProvided_ResultAsExpected()
        {
            // Arrange
            var random = new Random();
            var expected = random.Next(5, 55);

            var items = new List<int>();
            Enumerable.Range(1, expected).ToList().ForEach(x => items.Add(random.Next()));

            // Act
            var actual = _recursion.ItemsInList(items);

            // Assert
            actual.Should().Be(expected);
        }

        [Test]
        public void IsEven_EvenNumber_ReturnsTrue()
        {
            // Arrange
            // Act
            var actual = _recursion.IsEven(24678);

            // Assert
            actual.Should().BeTrue();
        }
        
        [Test]
        public void IsOdd_OddNumber_ReturnsTrue()
        {
            // Arrange
            // Act
            var actual = _recursion.IsOdd(65);

            // Assert
            actual.Should().BeTrue();
        }

        [Test]
        public void Ackermann_MisZero_ReturnsNplusOne()
        {
            // Arrange
            var n = _random.Next();
            var expected = n + 1;

            // Act
            var actual = _recursion.Ackermann(0, n);

            // Assert
            actual.Should().Be(expected);
        }
        
        //[Test]
        //public void Ackermann_NisZero_ReturnsAckermannOfMminusOneAndOne()
        //{
        //    // Arrange
        //    var m = 5;
        //    var expected = n + 1;

        //    // Act
        //    var actual = _recursion.Ackermann(m, 0);

        //    // Assert
        //    actual.Should().Be(expected);
        //}
    }
}