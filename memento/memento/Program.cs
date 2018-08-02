using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book
            {
                Isbn = "12345",
                Title = "Sefiller",
                Author = "Victor Hugo"
            };
            book.ShowBook();
            CareTaker history = new CareTaker();
            history.Mementon = book.CreateUndo();
            book.Isbn = "54321";
            book.Title = "VICTOR HUGO";
            book.ShowBook();
            book.RestoreFromUndo(history.Mementon);
            book.ShowBook();
            


            Console.ReadLine();

            

        }
    }
    class Book
    {
        private string _title;
        private string _author;
        private string _ısbn;
        DateTime _LastEdited;

        public string Title
        {
            get { return _title;}

            set
            {
                _title = value;
                SetLastEdited();
            }
        }

        public string Author
        {
            get{return _author;}

            set
            {
                _author = value;
                SetLastEdited();
            }
        }

        public string Isbn
        {
            get { return _ısbn; }

            set
            {
                _ısbn = value;
                SetLastEdited();
            }
        }
        private void SetLastEdited()
        {
            _LastEdited = DateTime.UtcNow;
        }
        public Memento CreateUndo()
        {
            return new Memento(_ısbn,_title,_author,_LastEdited);
        }
        public  void    RestoreFromUndo(Memento memento)
        {
            _title = memento.Title;
            _author = memento.Author;
            _LastEdited = memento.LAstEdited;
            _ısbn=memento.Isbn;
        }
        public void ShowBook()
        {
            Console.WriteLine("{0},{1},{2} edited :{3}", Isbn, Title, Author,_LastEdited);
        }

 
    }
    class Memento
    {
        public string Isbn { get; set; }
         public string Title { get; set; }
        public string Author { get; set; }
        public DateTime LAstEdited { get; set; }
        public Memento ( string isbn, string title,string author,DateTime lastEdit)
        {
            Isbn = isbn;
            Title = title;
            Author = author;
            LAstEdited = lastEdit;
        }

    }
    class CareTaker
    {
        public  Memento Mementon { get; set; }
    }

}
