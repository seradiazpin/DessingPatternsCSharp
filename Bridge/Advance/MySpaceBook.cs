using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Advance
{
    public class MySpaceBook
    {
        SpaceBook mySpaceBook;
        string password;
        string name;
        bool loggedIn = false;
        void Register()
        {
            Console.WriteLine("Let's register you for SpaceBook");
            do
            {
                Console.WriteLine("All Spacebook names must be unique");
                Console.Write("Type in a user name: ");
                name = Console.ReadLine();
            } while (SpaceBook.IsUnique(name));
            Console.Write("Type in a password ");
            password = Console.ReadLine();
            Console.WriteLine("Thanks for registering with spacebook");
        }

        bool Authenticate()
        {
            Console.Write("Welcome " + name + ". Please type in yout password: ");
            string supplied = Console.ReadLine();
            if(supplied == password)
            {
                loggedIn = true;
                Console.WriteLine("Logged into SpaceBook");
                if(mySpaceBook == null)
                {
                    mySpaceBook = new SpaceBook(name);
                }
                return true;
            }
            Console.WriteLine("Incorrect password");
            return false;
        }

        public void Add(string message)
        {
            Check();
            if (loggedIn) mySpaceBook.Add(message);
        }

        public void Add(string friend, string message)
        {
            Check();
            if (loggedIn) mySpaceBook.Add(friend, name + "said: "+message);
        }

        public void Poke(string who)
        {
            Check();
            if (loggedIn) mySpaceBook.Poke(who, name);
        }

        void Check()
        {
            if (!loggedIn)
            {
                if (password == null)
                    Register();
                if (mySpaceBook == null)
                {
                    Authenticate();
                }
            }
        }

    }
}
