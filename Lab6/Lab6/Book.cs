using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Lab6
{
    [Serializable]
    public class Book
    {

        public string Title { get; set; }
        public string Author { get; set; }
        public string Id { get; set; }
        
        public string Publisher { get; set; }
        public int Year { get; set; }
        public string City { get; set; }
        public bool Status { get; set; }

       
        public Book()
        {

        }

        public Book(string title, string author, string id, string publisher, int year, string city, bool status) : this(title, author, id)
        {
            Publisher = publisher;
            Year = year;
            City = city;
            Status = status;
        }

        public Book(string title, string author, string id)
        {
            Id = id;
            Title = title;
            Author = author;
        }
    }
}
