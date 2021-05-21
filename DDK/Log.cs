using System;
namespace DDK
{
    public class Log
    {
        public static void Error(string message)
        {
            LogMessage("ERR", message);
        }

        private static void LogMessage(string level, string message)
        {
            IO.Write($"{level}: {DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss")}: {message}", ConsoleColor.Red);
        }
    }
}
