using System;

namespace ARL
{
    public class ConsoleUtils
    {
        public static void HighlightAndWrite(string text, string toHighlight)
        { 
            ConsoleColor defaultColor = ConsoleColor.Gray;
            Console.ForegroundColor = defaultColor;
            int index = -1;
            try
            {
                index = text.IndexOf(toHighlight);
            }
            catch
            {
                index = -1;
            }
            if (index != -1)
            {
                Console.Write(text.Substring(0, index)); 
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(toHighlight);
                Console.ForegroundColor = defaultColor;
                int begin = index + toHighlight.Length;
                int end = text.Length - begin;
                Console.Write(text.Substring(begin, end));
            }
            else
            {
                Console.Write(text);
            }
                Console.Write('\n');
        }
    }
}

