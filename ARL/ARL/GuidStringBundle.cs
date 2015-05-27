using System;
using System.Collections.Generic;

namespace ARL
{
    public class GuidStringBundle
    {

        private List<String> fullList = new List<String>();

        public List<String> FullList
        {
            get
            {
                return fullList;    
            }

        }

        public GuidStringBundle(List<Guid> enterList)
        {
            foreach (Guid guid in enterList)
            {
                fullList.Add(guid.ToString());
            }
        }

        public GuidStringBundle(int n)
        {
            foreach (Guid guid in MainFunctions.Guids(n))
            {
                fullList.Add(guid.ToString());
            }

        }
        //find the list of common substrings for the amount of the minimum of two strings
        public List<String> GetRepeatingStrings()
        {
            HashSet<String> results = new HashSet<String>();
            for (int i = 0; i < fullList.Count; i++)
            {
                for (int j = fullList.Count - 1; j > 0 + i; j--)
                {
                    HashSet<String> temporaryResult = ListFormat.CommonSubstrings(fullList[i], fullList[j]);
                    foreach (String s in temporaryResult)
                    {
                        results.Add(s);
                    }
                }
            }
            return new List<String>(results);
        }
    }
}

