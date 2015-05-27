using System;
using System.Collections.Generic;

namespace ARL
{
    public class ListFormat
    {
        public static bool Hyphen(String s)
        {
            return s.Contains("-");
        }

        //find the longest elements in List
        public static List<String> BiggestStrings(List<String> fList)
        {
            List<String> result = new List<string>();
            if (fList.Count == 0)
            {
                return result;
            }
            else
            {
            List<String> workList = fList;
            int k = 1;
            workList.Sort(new StringComparator());
            result.Add(workList[0]);
            while (k < workList.Count)
            {
                if (workList[k].Length == workList[0].Length)
                {
                    result.Add(workList[k]);
                    k++;
                }
                else
                {
                    return result;
                }
            }
                return result;
            }
        }

        //find list of common substrings between two strings
        public static HashSet<String> CommonSubstrings(string str1, string str2)
        {
            if (String.IsNullOrEmpty(str1) || String.IsNullOrEmpty(str2))
                return new HashSet<String>();
            HashSet<String> results = new HashSet<String>();
            List<int[]> num = new List<int[]>();
            String result = "";
            int maxlen = 0;
            int index = 0;
            for (int i = 0; i < str1.Length; i++)
            {
                num.Add(new int [str2.Length]);
                for (int j = 0; j < str2.Length; j++)
                {
                    if (str1[i] != str2[j])
                        num[i][j] = 0;
                    else
                    {
                        if ((i == 0) || (j == 0))
                        {
                            num[i][j] = 1;
                        }
                        else
                        {
                            num[i][j] = 1 + num[i - 1][j - 1];
                        }
                        if (num[i][j] > maxlen)
                        {
                            maxlen = num[i][j];
                            index = i;
                            if (maxlen >= 1)
                            {
                                while (maxlen > 0)
                                {
                                    for (int k = maxlen; k > 0; k--)
                                    {
                                        result = result + str1[index - k + 1];
                                    }
                                    results.Add(result);
                                    result = null;
                                    maxlen--;
                                }
                            }
                        }
                    }
                }
            }
            results.RemoveWhere(Hyphen);
            return results;
        }
    }
}
