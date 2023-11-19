using NUnit.Framework;

using System;




using NUnit.Framework;
using System;

namespace TestApp.Tests
{
    public class CountRealNumbersTests
    {
        // TODO: finish test
        [Test]
        public void Test_Count_WithEmptyArray_ShouldReturnEmptyString()
        {
            // Arrange
            int[] input = Array.Empty<int>();
            // Act
            string result = CountRealNumbers.Count(input);
            // Assert
            Assert.That(result, Is.Empty);
        }

        [Test]
        public void Test_Count_WithSingleNumber_ShouldReturnCountString()
        {
            // Arrange
            int[] input = new int[] { 1 };
            // Act
            string result = CountRealNumbers.Count(input);
            // Assert
            Assert.That(result, Is.EqualTo("1 -> 1"));
        }

        [Test]
        public void Test_Count_WithMultipleNumbers_ShouldReturnCountString()
        {
            // Arrange
            int[] input = new int[] { 1, 2, 3, 1, 2, 1, 3, 2 };
            // Act
            string result = CountRealNumbers.Count(input);
            // Assert
            Assert.That(result, Is.EqualTo("1 -> 3" + Environment.NewLine + "2 -> 3" + Environment.NewLine + "3 -> 2"));
        }

        [Test]
        public void Test_Count_WithNegativeNumbers_ShouldReturnCountString()
        {
            // Arrange
            int[] input = new int[] { -1, -2, -3, -1, -2, -1, -3, -2 };
            // Act
            string result = CountRealNumbers.Count(input);
            // Assert
            Assert.That(result, Is.EqualTo("-3 -> 2" + Environment.NewLine + "-2 -> 3" + Environment.NewLine + "-1 -> 3"));
        }

        [Test]
        public void Test_Count_WithZero_ShouldReturnCountString()
        {

            // Arrange
            int[] input = new int[] { 0 };
            // Act
            string result = CountRealNumbers.Count(input);
            // Assert
            Assert.That(result, Is.EqualTo("0 -> 1"));
        }

        [Test]
        public void Test2_Count_WithZero_ShouldReturnCountString()
        {

            // Arrange
            int[] input = new int[] { 0, 0, 0, 0 };
            // Act
            string result = CountRealNumbers.Count(input);
            // Assert
            Assert.That(result, Is.EqualTo("0 -> 4"));
        }
    }
}
