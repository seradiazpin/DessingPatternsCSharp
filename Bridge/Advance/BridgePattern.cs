using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Advance
{
    public class BridgePattern
    {
        public static void Test()
        {
            Portal me = new Portal(new MyOpenBook("Judith"));
            me.Add("Hello World");
            me.Add("Today I worked 18 hours");

            Portal tom = new Portal(new MyOpenBook("Tom"));
            tom.Poke("Judith-1");
            tom.SuperPoke("Judith-1", "hugged");
            tom.Add("Judith-1", "Poor you");
            tom.Add("Hey, I'm on open book - it's cool");
        }
    }
}
