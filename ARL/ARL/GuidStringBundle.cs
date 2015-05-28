using System;
using System.Collections.Generic;

namespace ARL
{
    public class GuidStringBundle
    {

        private List<string> fullList = new List<string>();

        public List<string> FullList
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
            for (int i = 0; i < n; i++)
            {
                fullList.Add(Guid.NewGuid().ToString());
            }
        }
        //find the list of common substrings for the amount of the minimum of two strings
        public List<string> GetRepeatingStrings()
        {
            HashSet<String> results = new HashSet<string>();
            for (int i = 0; i < fullList.Count; i++)
            {
                for (int j = fullList.Count - 1; j > 0 + i; j--)
                {
                    HashSet<string> temporaryResult = ListFormat.CommonSubstrings(fullList[i], fullList[j]);
                    foreach (string s in temporaryResult)
                    {
                        results.Add(s);
                    }
                }
            }
            return new List<string>(results);
        }
    }
}

