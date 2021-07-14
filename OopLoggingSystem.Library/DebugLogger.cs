using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopLoggingSystem.Library
{
    public class DebugLogger : Logger
    {
        public override void Write(Severity severity, string message)
        {
            var logEntryBuilder=LoggerFormatter.FormatLogger(severity, message);

            System.Diagnostics.Debug.WriteLine(logEntryBuilder.ToString());
        }
    }
}
