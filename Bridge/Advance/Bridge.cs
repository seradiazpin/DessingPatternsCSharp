using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Advance
{
    interface Bridge
    {
        void Add(string message);
        void Add(string friend, string message);
        void Poke(string who);
    }
}
