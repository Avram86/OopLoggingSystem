using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopLoggingSystem.Library.Factories
{
    public class DebugLoggerFactory : LoggerTypeFactory
    {
        //Step 5
        public override Logger CreateLoggerTypeFactory(LoggerType loggerType)
        {
            if (loggerType is LoggerType.Debug)
            {
                return new DebugLogger(); 
            }

            return null;
        }
    }
}
