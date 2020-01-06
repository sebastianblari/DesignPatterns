using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Gradebook.Tests
{
    public delegate string WriteLogDelegate(string LogMessage);
    public class TypeTest
    {
        public int count = 0;

        [Fact]
        public void WriteLogDelegateCanPointToMethod()
        {
            
            //WriteLogDelegate log;
            /*
                Syntaxis larga
             */
            //log = new WriteLogDelegate(ReturnMesage);
            /*
                Syntaxis corta
             */
            //log = ReturnMesage;
            WriteLogDelegate log = ReturnMesage;
            log += ReturnMesage;
            log += IncrementCount;

            var result = log("Hello!");
            Assert.Equal("Hello!", result);
            Assert.Equal(3, count);

        }
       
        string ReturnMesage(string message)
        {
            count++;
            return message;
        }

        string IncrementCount(string message)
        {
            count++;
            return message.ToLower();
        }

        [Fact]
        public void GetBookReturnsDifferentObject()
        {
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");


            //Assert.Equal("", book1.name);
            //Assert.Equal("", book2.name);

            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);

        }
        [Fact]
        public void TwoVarsCanReferenceSameObject()
        {
            var book1 = GetBook("Book 1");
            var book2 = book1;
            Assert.Same(book1, book2);
            Assert.True(Object.ReferenceEquals(book1, book2));
        }

        [Fact]
        public void CanSetNameFromReference()
        {
            var book1 = GetBook("Book 1");
            SetName(book1, "New Book");
            Assert.Equal("New Book", book1.Name);
        }
        void SetName(Book book, string name)
        {
            book.Name = name;
        }

        [Fact]
        public void CSharphCanPassByRef()
        {
            var book1 = GetBook("Book 1");
            GetBookSetName(ref book1, "New Book");
            Assert.Equal("New Book", book1.Name);
        }
        void GetBookSetName(ref Book book, string name)
        {
            book = new Book(name);
        }

        Book GetBook(string name)
        {
            return new Book(name);
        }


    }
}
