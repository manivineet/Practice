using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesAnAverageGrade()
        {

            var book = new InMemoryBook("new Gradebook");
            book.AddGrade(89.1);
            book.AddGrade(90.1);
            book.AddGrade(78.1);
            book.AddGrade(66.1);

            var result = book.GetStatistics();

            Assert.Equal(80.8, result.Average, 1);
            Assert.Equal(90.1, result.High, 1);
            Assert.Equal(66.1, result.Low, 1);
        }
    }
}
