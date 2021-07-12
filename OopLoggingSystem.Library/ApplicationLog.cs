using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopLoggingSystem.Library
{
    public static class ApplicationLog
    {
        private static Logger _logger;

        public static void Initialize(Logger logger)
        {
            _logger = logger;
        }
        public static void WriteLog(Severity severity, string message)
        {
            if (ApplicationLog._logger != null)
            {
                ApplicationLog._logger.Write(severity, message);
            }
        }
    }
}
