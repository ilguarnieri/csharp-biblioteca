using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Library
    {
        public List<User> users;
        public List<Book> books;
        public List<Dvd> dvds;

        private bool isLog = false;

        //costruttore
        public Library(List<User> users, List<Book> books, List<Dvd> dvds)
        {
            this.users = users;
            this.books = books;
            this.dvds = dvds;
        }



        public void Home(string title)
        {
            Console.Clear();
            Console.WriteLine(title);
            Console.WriteLine("------------------------------\n");

            Console.WriteLine("1. Registrati");
            Console.WriteLine("2. Login");
            Console.WriteLine("3. Exit\n");

            byte choice;

            choice = this.loopChoice(3);


            switch (choice)
            {
                case 1:
                    this.Register();
                    break;
                case 2:
                    this.Login();
                    break;
                case 3:
                    this.Exit();
                    break;
            }
        }



        private void Register()
        {
            Console.Clear();
            Console.WriteLine(" REGISTRAZIONE UTENTE");
            Console.WriteLine("------------------------------\n");

            Console.Write("NOME: ");
            string name = Console.ReadLine();
            Console.Write("COGNOME: ");
            string surname = Console.ReadLine();
            Console.Write("E-MAIL: ");
            string email = Console.ReadLine();
            Console.Write("PASSWORD: ");
            string password = Console.ReadLine();
            Console.Write("TELEFONO: ");
            string cellNumber = Console.ReadLine();

            User user = new User(name, surname, email, password, cellNumber, true);
            this.users.Add(user);

            Console.Clear();
            this.Home(" REGISTRAZIONE RIUSCITA");
        }



        private void Login()
        {
            Console.Clear();
            Console.WriteLine(" LOGIN");
            Console.WriteLine("------------------------------\n");

            Console.Write("E-MAIL: ");
            string email = Console.ReadLine();
            Console.Write("PASSWORD: ");
            string password = Console.ReadLine();

            foreach (User user in this.users)
            {
                if(user.email == email && user.password == password)
                {
                    isLog = true;
                    Console.Clear();
                    this.Logged();
                    break;
                }
            }

            if (!isLog)
            {
                this.Home(" INSERITI DATI NON CORRETTI");
            }
        }



        private void Logged()
        {
            Console.Clear();
            Console.WriteLine(" BENVENUTO");
            Console.WriteLine("------------------------------\n");

            Console.WriteLine("1. Cerca un libro");
            Console.WriteLine("2. Cerca un DVD");
            Console.WriteLine("3. I tuoi noleggi");
            Console.WriteLine("4. Logout");
            Console.WriteLine("5. Exit\n");

            byte choice;

            choice = this.loopChoice(5);


            switch (choice)
            {
                case 1:
                    Console.Clear();
                    this.SearchBook();
                    break;
                case 2:
                    
                    break;
                case 3:

                    break;
                case 4:
                    isLog = false;
                    this.Home(" MENÙ");
                    break;
                case 5:
                    this.Exit();
                    break;
            }
        }



        private void SearchBook()
        {
            Console.WriteLine(" RICERCA LIBRO");
            Console.WriteLine("------------------------------\n");

            Console.WriteLine("1. Cerca ISBN");
            Console.WriteLine("2. Cerca titolo");
            Console.WriteLine("3. Torna indietro");
            Console.WriteLine("4. Exit\n");

            byte choice;

            choice = this.loopChoice(4);

            switch (choice)
            {
                case 1:
                    this.SearchBookCode();
                    break;
                case 2:
                    this.SearchBookTitle();
                    break;
                case 3:
                    this.Logged();
                    break;
                case 4:
                    this.Exit();
                    break;
            }
        }



        private void SearchBookCode()
        {
            Console.Clear();
            Console.WriteLine(" RICERCA LIBRO");
            Console.WriteLine("------------------------------\n");

            Console.Write($"Inserisci ISBN: ");
            string isbn = Console.ReadLine();

            bool foundBook = false;

            foreach (Book book in books)
            {
                if (book.id == isbn)
                {
                    foundBook = true;
                    this.BookInfo(book);
                    break;
                }
            }

            if (!foundBook)
            {
                Console.Clear();
                Console.WriteLine("*- LIBRO NON TROVATO -*\n");
                this.SearchBook();
            }
        }



        private void SearchBookTitle()
        {
            Console.Clear();
            Console.WriteLine(" RICERCA LIBRO");
            Console.WriteLine("------------------------------\n");

            Console.Write($"Inserisci titolo: ");
            string title = Console.ReadLine();

            bool foundBook = false;

            foreach (Book book in books)
            {
                if (book.title == title)
                {
                    foundBook = true;
                    this.BookInfo(book);
                    break;
                }
            }

            if (!foundBook)
            {
                Console.Clear();
                Console.WriteLine("*- LIBRO NON TROVATO -*\n");
                this.SearchBook();
            }
        }



        private void BookInfo(Book book)
        {
            Console.Clear();
            Console.WriteLine($" {book.title}");
            Console.WriteLine("------------------------------\n");

            Console.WriteLine("1. Informazioni");
            Console.WriteLine("2. Noleggia");
            Console.WriteLine("3. Restituisci");
            Console.WriteLine("4. Cerca un altro articol");
            Console.WriteLine("5. Exit\n");

            byte choice;

            choice = this.loopChoice(5);

            switch (choice)
            {
                case 1:
                    Console.Clear();
                    book.stampInfo();
                    this.MenuInfo();              
                    break;
                case 2:
                    
                    break;
                case 3:

                    break;
                case 4:
                    this.Logged();
                    break;
                case 5:
                    this.Exit();
                    break;
            }
        }



        private void MenuInfo()
        {
            Console.WriteLine("\n1. Noleggia");
            Console.WriteLine("2. Restituisci");
            Console.WriteLine("3. Cerca un altro articolo");
            Console.WriteLine("4. Exit\n");

            byte choice;

            choice = this.loopChoice(4);

            switch (choice)
            {
                case 1:

                    break;
                case 2:

                    break;
                case 3:
                    this.Logged();
                    break;
                case 4:
                    this.Exit();
                    break;
            }
        }



        private void Exit()
        {
            isLog = false;
            Console.Clear();
            Console.WriteLine(" TORNA A TROVARCI PRESTO!");
            Console.WriteLine("------------------------------\n");
        }



        private byte loopChoice(int options)
        {
            byte choice;
            do
            {
                string input = Console.ReadLine();

                if (String.IsNullOrEmpty(input))
                {
                    input = "0";
                }

                choice = Convert.ToByte(input);

                if (choice == 0 || choice > options)
                {
                    Console.WriteLine("La voce di menu selezionata non esite!");
                    Console.WriteLine("Inserisci una voce valida...\n");
                }
            } while (choice == 0 || choice > options);

            return choice;
        }
    }
}
