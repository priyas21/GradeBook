using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesAnAverageGrade()
        {
            //arrange
            var book = new Book("");
            book.AddGrade(89.36);
            book.AddGrade(90.5);
            book.AddGrade(67.7);

            //action
            var result = book.GetStatistics();

            //assert
            Assert.Equal(82.5, result.Average,1) ;
            Assert.Equal(90.5, result.High) ;
            Assert.Equal(67.7, result.Low) ;
        }
    }
}
