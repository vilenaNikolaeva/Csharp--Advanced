using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Libraryy
{
    public class Book : IComparable<Book>
    {
      
        public string Title { get; set; }
        public int Year { get; set; }
        public IReadOnlyList<string> Authors { get; set; }

        public Book(string title,int year,params string[] author)
        {
            this.Title = title;
            this.Year = year;
            this.Authors = author;
        }

        public int CompareTo([AllowNull] Book other)
        {
            int result = this.Year.CompareTo(other.Year);
            if (result==0)
            {
                result = this.Title.CompareTo(other.Title);
            }
            return result;
        }
        public override string ToString()
        {
            return $"{this.Title} - {this.Year}";
        }
    }
}
