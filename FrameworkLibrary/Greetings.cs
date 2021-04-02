using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkLibrary
{
    public class Greetings
    {
        public string Welcome(Person p)
        {
            return $"Welcome to our presentation {p.FirstName} {p.LastName}";
        }
    }
}
