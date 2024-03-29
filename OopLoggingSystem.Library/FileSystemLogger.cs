﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopLoggingSystem.Library
{
    public class FileSystemLogger : Logger
    {
        public FileSystemLogger(string directory, string fileName="error.txt")
        {
            Directory = directory;
            FileName = fileName;
        }
        public string Directory { get;  }

        public string FileName { get; }

        public override void Write(Severity severity, string message)
        {
            var logEntryBuilder = LoggerFormatter.FormatLogger(severity, message);

            string actualDirectory = Directory;
            if (string.IsNullOrWhiteSpace(actualDirectory))
            {
                actualDirectory = Path.GetTempPath();
            }

            string actualFileName = FileName;
            if (string.IsNullOrWhiteSpace(actualFileName))
            {
                actualFileName = "error.txt";
            }

            if (!System.IO.Directory.Exists(actualDirectory))
            {
                System.IO.Directory.CreateDirectory(actualDirectory);
            }

            using (StreamWriter outputFile =new StreamWriter(Path.Combine(actualDirectory, actualFileName), append: true))
            {
                outputFile.WriteLine(logEntryBuilder.ToString());
            }
        }
    }
}
