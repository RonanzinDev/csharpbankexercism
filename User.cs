using System.Collections.Generic;

namespace bankexercism
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Balance { get; set; }

        public User(int id, string name, string email, int balance)
        {
            Id = id;
            Name = name;
            Email = email;
            Balance = balance;

        }

    }
}