using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {
        [Fact] 
        public void CSharpCanPassByRef()
        {
            //arrange
            var book1 = GetBook("Book 1");
            GetBookSetName(out book1, "Science Book");

            //action

            //assert
            Assert.Equal("Science Book", book1.Name);
        }

        [Fact] 
       public void CSharpIsPassByValue()
        {
            //arrange
            var book1 = GetBook("Book 1");
            SetName(book1, "Science Book");

            //action

            //assert
            Assert.Equal("Science Book", book1.Name);
        }

        [Fact]
        public void TwoReferencesReturnsDifferentObjects()
        {
            //arrange
            var book1 = new Book("Book 1");
            var book2 = new Book("Book 2");
            var book3 = GetBook("Book 3"); // to use a method inside the tests(No fact attribute is used)

            //action

            //assert
            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
            Assert.Equal("Book 3", book3.Name);
            Assert.NotSame(book1, book2);

        }

        [Fact]
        public void TwoVariablesReturnsSameObjects()
        {
            //Variables always holds the same values which points to same object. They do not hold the object id
            var book1 = GetBook("Science");
            var book2 = book1;
            Assert.Equal(book2, book1);
            Assert.Same(book2, book1); //Asserting that both points to same object in memory
            Assert.True(Object.ReferenceEquals(book1, book2)); // same as Assert.Same
        } 
        Book GetBook(string name)
        {
            return new Book(name);
        }
        
        private void GetBookSetName(ref Book book, string name)
        {
            // this creates a new instance of book object. Changing the value of book param to point
            // to different book object. This is an ideal situation as we do not want the copy to 
            // change the original object. 
            book = new Book(name);
        }
        
        private void SetName(Book book, string name)
        {
            book.Name = name;
        }

    }
}
