using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class BookLibrary
    {
        private string name;
        private List<Book> books;
        public BookLibrary(string name)
        {
            Name = name;
            Books = new List<Book>();
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public List<Book> Books
        {
            get { return books; }
            set { books = value; }
        }
        public void AddBook(string title, double rating)
        {
            Book newBook = new Book(title, rating);
            this.books.Add(newBook);
        }
        public double AverageRating()
        {
            double ave = 0;
            for (int i = 0; i < Books.Count; i++)
                ave += Books[i].Rating;
            ave /= Books.Count;
            return ave;
        }
        public List<string> GetBooksByRating(double rating)
        {
            List<string> res = new List<string>();
            for (int i = 0; i < Books.Count; i++)
                if (Books[i].Rating > rating) res.Add(Books[i].Title);
            return res;
        }
        public List<Book> SortByTitle()
        {
            Books = Books.OrderBy(x => x.Title).ToList();
            return Books;
        }
        public List<Book> SortByRating()
        {
            Books = Books.OrderByDescending(x => x.Rating).ToList();
            return Books;
        }
        public string[] ProvideInformationAboutAllBooks()
        {
            string[] res = new string[this.Books.Count];
            for (int i = 0; i < Books.Count; i++)
                res[i] = Books[i].ToString();
            return res;
        }
        public bool CheckBookIsInBookLibrary(string title)
        {
            for (int i = 0; i < Books.Count; i++)
                if (Books[i].Title == title) return true;
            return false;
        }
    }
}