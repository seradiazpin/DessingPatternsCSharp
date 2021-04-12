using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Basic
{
    class DecoratorB:IComponent
    {
        public string addedState = "past the Coffee Shop ";
        IComponent component;
        public DecoratorB(IComponent c)
        {
            this.component = c;
        }
        public string Operation()
        {
            string s = component.Operation();
            s += "to Schol";
            return s;
        }

        public string AddBehavior()
        {
            return "and I bought a cappuccino";
        }
    }
}
