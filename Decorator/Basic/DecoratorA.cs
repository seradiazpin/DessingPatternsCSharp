using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Basic
{
    class DecoratorA : IComponent
    {
        IComponent component;
        public DecoratorA(IComponent c) {
            this.component = c;
        }
        public string Operation()
        {
            string s = component.Operation();
            s += "and listening to Classic FM";
            return s;
        }
    }
}
