namespace LibrarySystem.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public User() { }

        public User(int id, string name, string email, string phone)
        {
            Id = id;
            Name = name;
            Email = email;
            Phone = phone;
        }

        public override string ToString()
        {
            return string.Format("{0} ({1})", Name, Email);
        }
    }
}