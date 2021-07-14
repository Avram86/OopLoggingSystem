using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopLoggingSystem.Library
{
    public static class LoggerFormatter
    {
        public static StringBuilder FormatLogger(Severity severity, string message)
        {
            StringBuilder logEntryBuilder = new StringBuilder();
            logEntryBuilder.AppendLine(new string('-', Console.WindowWidth - 1));
            logEntryBuilder.AppendLine($"[{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff}] [{severity}] : [{message}]");
            logEntryBuilder.AppendLine(new string('-', Console.WindowWidth - 1));

            return logEntryBuilder;
        }
    }
}
