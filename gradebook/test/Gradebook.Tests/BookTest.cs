using System;
using Xunit;

namespace Gradebook.Tests
{
    public class BookTest
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            var book = new Book("Sebastian's Book");
            book.AddGrade(89.1);
            book.AddGrade(90.7);
            book.AddGrade(92.6);

            // Act
            book.GetStatistics();

            // Assert
            Assert.Equal(89.1, book.result.Low);
            Assert.Equal(92.6, book.result.High);
            Assert.Equal(90.8, book.result.Average);
        }
    }
}
