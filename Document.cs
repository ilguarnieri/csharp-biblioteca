using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Document
    {
        public string id;
        public string title;
        public uint year;
        public string sector;
        public bool state;
        public string shelf;
        public string author;

        //costruttore
        public Document(string id, string title, uint year, string sector, bool state, string shelf, string author)
        {
            this.id = id;
            this.title = title;
            this.year = year;
            this.sector = sector;
            this.state = state;
            this.shelf = shelf;
            this.author = author;
        }



    }
}
