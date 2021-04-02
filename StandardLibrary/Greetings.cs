using System;
using System.Collections.Generic;
using System.Text;

namespace StandardLibrary
{
    public class Greetings
    {
        public string Welcome(Person p)
        {
            return $"Welcome to our presentation {p.FirstName} {p.LastName}";
        }
    }
}
