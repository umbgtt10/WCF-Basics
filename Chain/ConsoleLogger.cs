using System;

namespace Chain
{
    public class ConsoleLogger : AbstractLogger
    {

        public ConsoleLogger(int level)
        {
            Level = level;
        }

        protected override void Write(String message)
        {
            Console.WriteLine("Standard Console::Logger: " + message);
        }
    }
}