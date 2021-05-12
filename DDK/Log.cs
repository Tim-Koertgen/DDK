using System;
namespace DDK
{
    public class Log
    {
        public static void Error(string message)
        {
            LogMessage("error", message);
        }

        private static void LogMessage(string level, string message)
        {

        }
    }
}
