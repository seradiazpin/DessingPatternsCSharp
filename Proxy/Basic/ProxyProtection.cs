using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy.Basic
{
    class ProxyProtection : ISubject
    {
        Subject subject;
        string password = "abracadabra";
        public string Authenticate(string supplied)
        {
            if(supplied != password)
            {
                return "Protection Proxy: No access";
            }
            else
            {
                subject = new Subject();
                return "Protection Proxy: Authenticated";
            }
        }
        public string Request()
        {
            if(subject == null)
            {
                return "Protection Proxy: Authenticate first";
            }
            else
            {
                return subject.Request();
            }
        }
    }
}
