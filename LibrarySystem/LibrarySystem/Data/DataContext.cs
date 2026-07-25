using System.Collections.Generic;
using LibrarySystem.Models;

namespace LibrarySystem.Data
{
    public static class DataContext
    {
        public static List<Book> Books { get; set; }
        public static List<User> Users { get; set; }
        public static List<Loan> Loans { get; set; }

        private static int _nextBookId = 1;
        private static int _nextUserId = 1;
        private static int _nextLoanId = 1;

        // Construtor estático para inicializar as listas de forma segura
        static DataContext()
        {
            Books = new List<Book>();
            Users = new List<User>();
            Loans = new List<Loan>();
        }

        public static int GetNextBookId()
        {
            return _nextBookId++;
        }

        public static int GetNextUserId()
        {
            return _nextUserId++;
        }

        public static int GetNextLoanId()
        {
            return _nextLoanId++;
        }
    }
}