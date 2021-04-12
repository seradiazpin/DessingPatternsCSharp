using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Basic
{
    class Component : IComponent
    {
        public string Operation()
        {
            return "I am walking";
        }
    }
}
