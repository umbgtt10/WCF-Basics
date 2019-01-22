using System;

namespace Chain
{
    public class FileLogger : AbstractLogger
    {

        public FileLogger(int level)
        {
            Level = level;
        }

        protected override void Write(String message)
        {
            Console.WriteLine("Standard file::Logger: " + message);
        }
    }
}