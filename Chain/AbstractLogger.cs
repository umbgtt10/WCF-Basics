using System;

namespace Chain
{
    public abstract class AbstractLogger
    {
        public static int INFO = 1;
        public static int DEBUG = 2;
        public static int ERROR = 3;

        protected int Level;

        //next element in chain or responsibility
        protected AbstractLogger NextLogger;

        public void SetNextLogger(AbstractLogger nextLogger)
        {
            NextLogger = nextLogger;
        }

        public void LogMessage(int level, String message)
        {
            if (this.Level <= level)
            {
                Write(message);
            }
            if (NextLogger != null)
            {
                NextLogger.LogMessage(level, message);
            }
        }

        protected abstract void Write(String message);
    }
}