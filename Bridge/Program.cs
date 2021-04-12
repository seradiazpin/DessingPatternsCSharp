using Bridge.Basic;
using System;

namespace Bridge
{
    class Program
    {
        static void BasicBridge()
        {
            Console.WriteLine("Bridge Pattern\n");
            Console.WriteLine(new Abstraction(new ImplementationA()).Operation());
            Console.WriteLine(new Abstraction(new ImplementationB()).Operation());
        }

        static void AdvanceBridge()
        {
            Console.WriteLine("Bridge Pattern\n");
            Advance.BridgePattern.Test();
        }
        static void Main(string[] args)
        {
            //BasicBridge();
            AdvanceBridge();
        }
    }
}
