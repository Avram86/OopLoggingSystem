using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopLoggingSystem.Library.Factories
{
    public abstract class LoggerTypeFactory
    {
        public abstract Logger CreateLoggerTypeFactory(LoggerType loggerType);

        public Logger GetLogger(LoggerType loggerType)
        {
            var logger = CreateLoggerTypeFactory(loggerType);
            return logger;
        }
    }
}
