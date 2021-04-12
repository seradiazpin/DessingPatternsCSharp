using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Advance
{
    public class MyOpenBook : Bridge
    {
        SpaceBook spaceBook;
        string name;
        static int users;

        public MyOpenBook(string n)
        {
            name = n;
            users++;
            spaceBook = new SpaceBook(name +"-" + users);
        }
        public void Add(string message)
        {
            spaceBook.Add(message);
        }

        public void Add(string friend, string message)
        {
            spaceBook.Add(friend, name + "said:" + message);
        }

        public void Poke(string who)
        {
            spaceBook.Poke(who, name);
        }

        public void SuperPoke(string who, string what)
        {
            spaceBook.Add(who, what + " you");
        }
    }
}
