using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Libraryy
{
    public class Library : IEnumerable<Book>
    {
        private List<Book> books;

        public Library()
        {
            this.books = new List<Book>();
        }

        public void Add(Book book)
        {
            this.books.Add(book);
        }
        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(this.books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private class LibraryIterator : IEnumerator<Book>
        {
            private List<Book> books;
            private int index;
            public LibraryIterator(List<Book> books)
            {
                this.Reset();
                this.books =books;
            }

            public Book Current => this.books[this.index];

            object IEnumerator.Current => this.Current;

            public void Dispose() { }
            public bool MoveNext() => ++this.index < this.books.Count;

            public void Reset() => this.index = -1;
           
        }
    }
}
