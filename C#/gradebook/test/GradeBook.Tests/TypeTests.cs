using System;
using Xunit;

namespace GradeBook.Tests
{
    public delegate string WriteLogDelegate(string logMessage);

    public class TypeTests
    {

        int count = 0;

        [Fact]
        public void WriteLogDelegatePointToMethod()
        {
            WriteLogDelegate log = ReturnMessage;

            log += ReturnMessage;
            log += IncrementCount;

            var result = log("Hello!");

            Assert.Equal(3, count);

        }

        string IncrementCount(string message)
        {
            count++;
            return message;
        }
        string ReturnMessage(string message)
        {
            count++;
            return message;
        }

        [Fact]
        public void CSharpCanPassByRef()
        {
            //Given
            var book1 = GetBook("Book 1");
            GetBookSetName(out book1, "New Name");

            Assert.Equal("New Name", book1.Name);

        }

        private void GetBookSetName(out InMemoryBook book, string name)
        {
            book = new InMemoryBook(name);
        }


        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            //Given
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);

        }

        [Fact]
        public void TwoVariablesCanReferenceSameReferences()
        {
            //Given
            var book1 = GetBook("Book 1");
            var book2 = book1;

            Assert.Same(book1, book2);
            Assert.True(Object.ReferenceEquals(book1, book2));
        }
        InMemoryBook GetBook(string name)
        {
            return new InMemoryBook(name);
        }

    }

}