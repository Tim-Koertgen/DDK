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
                Console.WriteLine(output);
            }
        }
    }
}
