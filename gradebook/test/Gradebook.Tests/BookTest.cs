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
            var book = new Book("");


            // Act
            var result = book.GetStatistics();


            // Assert
            Assert.Equal(91.5, result.Average);
        }
    }
}
