using OopLoggingSystem.Library.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopLoggingSystem.Library
{
    public static class ApplicationLog
    {
        private static LoggerType _loggerType;
        public static void Initialize(LoggerType loggerType)
        {
            //Step 2
            _loggerType = loggerType;
        }

        public static LoggerTypeFactory LoggerTypeFactori{
        
            //Step 4 !!!!!!!!!!!!!!
            get{
                if (_loggerType == LoggerType.Console)
                {
                    return new ConsoleLoggerFactory();
                }
                else if (_loggerType == LoggerType.Debug)
                {
                    return new DebugLoggerFactory();
                }
                else if(_loggerType == LoggerType.FileSystem)
                {
                    return new FileSystemLoggerFactory();
                }
                else
                {
                    return null;
                }
            } 
        }
        public static void WriteLog(Severity severity, string message)
        {
            //After writing to consoler for user, Step 3
            var log = LoggerTypeFactori.GetLogger(_loggerType);

            if (log != null)
            {
                //Step 6
                log.Write(severity, message);
            }
        }
    }
}
