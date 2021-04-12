using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Basic
{
    class Abstraction
    {
        Bridge bridge;
        public Abstraction(Bridge implementation)
        {
            bridge = implementation;
        }
        public string Operation()
        {
            return "Abstraction" + " <<< BRIDGE >>>" + bridge.OperationImpl();
        }
    }
}
