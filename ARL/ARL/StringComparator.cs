using System;
using System.Collections.Generic;

namespace ARL
{
    public class StringComparator : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            if (x == null)
            {
                return (y == null ? 0 : -1);
            }
            else
            {
                if (y == null)
                {
                    return 1;
                }
                else
                {
                    int retval = y.Length.CompareTo(x.Length);

                    if (retval != 0)
                    {
                        return retval;
                    }
                    else
                    {
                        return y.CompareTo(x);
                    }
                }
            }
        }
    }

}

