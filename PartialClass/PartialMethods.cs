using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part
{
    partial class Person
    {

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        public void PrintFullName()
        {
            Console.WriteLine(GetFullName());
        }
    }
}
