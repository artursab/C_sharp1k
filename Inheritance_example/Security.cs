using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_example
{
    class Security : Employee
    {
        
        public void Guard()
        {
            Console.WriteLine("I guard!");
        }
    }
}
