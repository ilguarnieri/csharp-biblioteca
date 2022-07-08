using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Dvd : Document
    {
        public string Sn
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

        public int duration;

        //costruttore
        public Dvd(string sn, string title, uint year, string sector, bool state, string shelf, string author, int duration) :
            base (sn, title, year, sector, state, shelf, author)
        {
            this.duration = duration;
        }

    }
}
