using Proxy.Advance;
using Proxy.Basic;
using System;

namespace Proxy
{
    class Program
    {
        static void ProxyBasic()
        {
            Console.WriteLine("Proxy Pattern\n");

            ISubject subject = new Proxy.Basic.Proxy();
            Console.WriteLine(subject.Request());
            Console.WriteLine(subject.Request());

            ProxyProtection subject2 = new ProxyProtection();
            Console.WriteLine(subject2.Request());
            Console.WriteLine((subject2 as ProxyProtection).Authenticate("Secret"));
            Console.WriteLine((subject2 as ProxyProtection).Authenticate("abracadabra"));
            Console.WriteLine(subject2.Request());

        }

        static void ProxyAdvanced()
        {
            MySpaceBook me = new MySpaceBook();
            me.Add("Hello World");
            me.Add("Today I worked 18 hours");
            MySpaceBook tom = new MySpaceBook();
            tom.Poke("Juddith");
            tom.Add("Juddith", "¨Poor you");
            tom.Add("Off to see the lion king");
        }

        static void Main(string[] args)
        {
            //ProxyBasic();
            ProxyAdvanced();
        }
    }
}
