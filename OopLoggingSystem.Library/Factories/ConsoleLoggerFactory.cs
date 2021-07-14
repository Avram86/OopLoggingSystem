using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopLoggingSystem.Library.Factories
{
    public class ConsoleLoggerFactory : LoggerTypeFactory
    {
        //Step 5
        public override Logger CreateLoggerTypeFactory(LoggerType loggerType)
        {
            if(loggerType is LoggerType.Console)
            {
                return new ConsoleLogger();
            }

            return null;
        }
    }
}
