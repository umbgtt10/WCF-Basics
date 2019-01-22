using System;

namespace Chain
{
    public class ErrorLogger : AbstractLogger
    {

        public ErrorLogger(int level)
        {
            Level = level;
        }

        protected override void Write(String message)
        {
            Console.WriteLine("Standard error::Logger: " + message);
        }
    }
}