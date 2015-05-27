using System;
using System.Collections.Generic;


namespace ARL
{
    class MainClass
    {
        public const string HelpMessage = 
            "\nTest application" +
            "\ncommands:" +
            "\n\t1 <guides> <zeroes> - returns 'guides' amount of guides. Each contains the right number of 'zeroes'" +
            "\n\t2 <guides> - returns 'guides' amount of guides and max common substrings";

        public static int Main(string[] args)
        {
            try
            {
                if (args.Length == 0 || args[0] == "?")
                {
                    Console.WriteLine(HelpMessage);
                    return 0;
                }
                string subtask = args[0];

                if (subtask == "1" && args.Length >= 3)
                {
                    return MainFunctions.FindGuidsContainingZeroes(args[1], args[2]);
                } 
                if (subtask == "2" && args.Length >= 2)
                {
                    return MainFunctions.MaxSubs(args[1]);
                }

                Console.WriteLine("you have typed not enough values or they are wrong, try to restart the application");
                Console.WriteLine(HelpMessage);
                return 0;

            }
            catch (Exception e)
            {
                Console.WriteLine("Fatal error: " + e.Message);
                return 1;
            }
        }
    }
}
