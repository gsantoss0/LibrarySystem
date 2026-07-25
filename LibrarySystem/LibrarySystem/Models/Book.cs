namespace LibrarySystem.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public string Genre { get; set; }
        public int PublicationYear { get; set; }
        public bool IsBorrowed { get; set; }

        public Book()
        {
            IsBorrowed = false;
        }

        public Book(int id, string title, string author, string isbn, string genre, int publicationYear)
        {
            Id = id;
            Title = title;
            Author = author;
            ISBN = isbn;
            Genre = genre;
            PublicationYear = publicationYear;
            IsBorrowed = false;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}", Title, Author);
        }
    }
}