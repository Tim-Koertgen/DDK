using System;
using System.Collections.Generic;

namespace DDK
{
    public class IO
    {
        public static void Write(string output)
        {
            Console.WriteLine(output);
        }

        public static void Write(List<string> outputList)
        {
            foreach (string output in outputList)
            {
                Write(output);
            }
        }

        public static void Write(string output, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Write(output);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void Write(List<string> outputList, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Write(outputList);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
