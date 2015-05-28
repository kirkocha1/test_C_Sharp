using System;
using System.Collections.Generic;

namespace ARL
{
    public class MainFunctions
    {
        public static int FindGuidsContainingZeroes(string amountGuidsArg, string amountZeroesArg)
        {
            int amountGuids;
            int amountZeroes;
            try
            {
                amountGuids = int.Parse(amountGuidsArg);
                amountZeroes = int.Parse(amountZeroesArg);
                if (amountGuids <= 0 || amountZeroes <= 0)
                {
                    Console.WriteLine("one of arguments is null or empty");
                    return 1;
                }
            }
            catch
            {
                Console.WriteLine("invalid arguents");
                return 1;
            }

            int i = 0;
            string zeroes = new string('0', amountZeroes); 
            Console.WriteLine("Amount of Guids {0}:", amountGuids);
            while (i < amountGuids)
            { 
                string guid = Guid.NewGuid().ToString(); 
                if (guid.Contains(zeroes))
                { 
                    ConsoleUtils.HighlightAndWrite(guid, zeroes);
                    ++i;
                }
            }
            return 0;
        }

        public static List<Guid> Guids(int amount)
        {
            List<Guid> guids = new List<Guid>();
            for (int i = 0; i < amount; i++)
            {
                guids.Add(Guid.NewGuid());
            }
            return guids;
        }

        public static int MaxSubs(string n)
        {
            int amount;
            try
            {
                amount = int.Parse(n);
                if (amount <= 0)
                {
                    Console.WriteLine("The input value is equal or smaller then zero");
                    return 1;
                }
                if (amount == 1)
                {
                    Console.WriteLine("The input value is equal to 1, nothing to compare");
                    return 1;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("You have put the wrong value", e.Message);
                return 1;
            }
            GuidStringBundle link = new GuidStringBundle(amount);
            foreach (string g in link.FullList)
            {
                Console.WriteLine(g);
            }
            Console.WriteLine("Max Common substring:");
            foreach (string guid in ListFormat.BiggestStrings(link.GetRepeatingStrings()))
            {
                Console.WriteLine(guid);
            }
            return 0;
        }


    }
}

