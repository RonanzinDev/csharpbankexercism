using System;


namespace bankexercism
{
    class Program
    {
        public static bool TemSaldoSuficiente(User usuario, int valor)
        {
            if (usuario.Balance < valor)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static int transferir(User usuario, User usuario2, int valor)
        {
            if (TemSaldoSuficiente(usuario, valor))
            {
                return usuario.Balance - valor;

            }
            else
            {
                return 1;
            }
        }
        static void Main(string[] args)
        {
            User usuario = new User(1, "Gabriel", "g@gmail.com", 1000);
            User usuario2 = new User(2, "Rafael", "r@gmail", 1000);
            Console.WriteLine(transferir(usuario, usuario2, 200));

        }


    }
}
