using System;
using System.Collections.Generic;

namespace run_indexof
{
    public class Run
    {
        public static int IndexOfLongestRun(string str)
        {
            var length = 0;
            var run = "";
            var firstPosition = 0;
            var position = 0;

            for (var counter = 0; counter < str.Length; counter = counter + 1)
            {
                if (run.Contains(str.Substring(counter, 1)))
                {
                    run = run + str.Substring(counter, 1);
                }
                else
                {
                    if (run.Length > 0 && run.Length >= length)
                    {
                        length = run.Length;
                        position = firstPosition;
                    }
                    run = str.Substring(counter, 1);
                    firstPosition = counter;
                }
            }

            if (run.Length > 0 && run.Length >= length)
            {
                length = run.Length;
                position = firstPosition;
            }

            return position;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(IndexOfLongestRun("abbcccddddcccbba"));
            

            Console.WriteLine(IndexOfLongestRun("abcdefg"));
            Console.Read();
        }
    }
}
