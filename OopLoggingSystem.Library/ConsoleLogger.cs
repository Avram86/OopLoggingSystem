using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopLoggingSystem.Library
{
    public class ConsoleLogger : Logger
    {
        public override void Write(Severity severity, string message)
        {
            var logEntryBuilder = LoggerFormatter.FormatLogger(severity, message);

            switch (severity)
            {
                case Severity.Info:
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine(logEntryBuilder.ToString());
                    Console.ResetColor();
                    break;

                case Severity.Warning:
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine(logEntryBuilder.ToString());
                    Console.ResetColor();
                    break;

                case Severity.High:
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(logEntryBuilder.ToString());
                    Console.ResetColor();
                    break;

                case Severity.Critical:
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(logEntryBuilder.ToString());
                    Console.ResetColor();
                    break;
            }
        }
    }
}
