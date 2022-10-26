namespace BasicAPI.Controllers.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User(int Id, string name, string email, string password)
        {
            ID = Id;
            Name = name;
            Email = email;
            Password = password;
        }

        public User()
        {
        }
    }
}
