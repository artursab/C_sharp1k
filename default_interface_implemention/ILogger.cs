using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace default_interface_implemention
{
    interface ILogger
    {
        void Log(LogLevel loglevel, string message);


        void Foo()
        {

        }
    }
}
