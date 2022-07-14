using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch01._Arrays_and_Strings
{
    public class Q1_1_IsUnique
    {
        // The complexity of this immplementation is O(N + (N-1) + (N-2) + ... + 2 + 1)
        // Which is O(N(N+1)/2) which is O(N^2)
        public bool IsUniqueIneffecient(string str)
        {
            if (string.IsNullOrEmpty(str))  
            {
                throw new ArgumentException($"'{nameof(str)}' cannot be null or empty.", nameof(str));
            }

            for (int i = 0; i < str.Length; i++)
            {
                for (int j = i + 1; j < str.Length; j++)
                {
                    if (str[i] == str[j]) { return false; }
                }
            }

            return true;
        }
    }
}
