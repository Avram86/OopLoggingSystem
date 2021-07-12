using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopLoggingSystem.Library
{
    public abstract class Logger
    {

        public abstract void Write(Severity severity, string message);
    }
}
