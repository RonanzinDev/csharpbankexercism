using System.Collections.Generic;

namespace bankexercism
{
    public class User
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Balance { get; set; }

        public User(int id, string nome, string email, int balance)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Balance = balance;

        }

    }
}