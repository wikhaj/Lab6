﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Lab6
{
    public class Book
    {

        public string Title { get; set; }
        public string Author { get; set; }
        public string Id { get; set; }

        public Book(string title, string author,string id)
        {
            Id = id;
            Title = title;
            Author = author;
        }

    }
}