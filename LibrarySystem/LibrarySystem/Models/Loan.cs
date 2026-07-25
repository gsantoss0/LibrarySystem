using System;

namespace LibrarySystem.Models
{
    public class Loan
    {
        public int Id { get; set; }
        public Book Book { get; set; }
        public User User { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime LoanDateDue { get; set; }
        public DateTime? DateReturned { get; set; }

        public bool IsActive
        {
            get { return !DateReturned.HasValue; }
        }

        public Loan() { }

        public Loan(int id, Book book, User user, int daysToReturn)
        {
            Id = id;
            Book = book;
            User = user;
            LoanDate = DateTime.Now;
            LoanDateDue = DateTime.Now.AddDays(daysToReturn);
            DateReturned = null;

            if (Book != null)
            {
                Book.IsBorrowed = true;
            }
        }

        public void RegisterReturn()
        {
            DateReturned = DateTime.Now;
            if (Book != null)
            {
                Book.IsBorrowed = false;
            }
        }

        public override string ToString()
        {
            string title = Book != null ? Book.Title : "Livro";
            string name = User != null ? User.Name : "Usuário";
            return string.Format("{0} - Emprestado para: {1}", title, name);
        }
    }
}