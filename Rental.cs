using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Rental
    {
        public int idUser;
        public User user;
        public Document document;
        public string startDate;
        public string endDate;

        public Rental(int idUser, User user, Document document, string startDate, string endDate)
        {
            this.idUser = idUser;
            this.user = user;
            this.document = document;
            this.startDate = startDate;
            this.endDate = endDate;
        }
    }
}
