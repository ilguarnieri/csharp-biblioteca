﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Book : Document
    {
        public string Isbn
        {
            get
            {
                return base.id;
            }
            set
            {
                base.id = value;
            }
        }

        public int numberPages;

        //costruttore
        public Book(string isbn, string title, uint year, string sector, bool state, string shelf, string author, int numberPages) :
            base(isbn, title, year, sector, state, shelf, author)
        {
            this.numberPages = numberPages;
        }

    }
}