using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopLoggingSystem.Library.Factories
{
    public class FileSystemLoggerFactory : LoggerTypeFactory
    {
        //Step 5
        public override Logger CreateLoggerTypeFactory(LoggerType loggerType)
        {
            if (loggerType is LoggerType.FileSystem)
            {
                return new FileSystemLogger(@"C:\Users\Ilitzy\FastTrackIt\Lab18\LoogingSystem"); 
            }

            return null;
        }
    }
}
