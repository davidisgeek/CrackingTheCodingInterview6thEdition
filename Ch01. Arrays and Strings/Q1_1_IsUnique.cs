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
        // Which is O(N(N+1)/2) which is O(N^2) being N the size of the string
        public bool IsUniqueIneffecient(string str)
        {
            // Really cool consideration. If we consider the string to be ASCII (which is a character set of 256 characters
            // then a string size more than 256 guarantees that the string has at least one character repeated
            // If the character set is unicode the string size would be bigger to start considering repetitions
            if (str.Length > 256)
            {
                return false;
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

        // Sorting a string is O(N logN) therefore this implementation is linearithmic
        public bool IsUniqueSorted(string str)
        {
            if (str.Length > 256)
            {
                return false;
            }

            string sortedString = String.Concat(str.OrderBy(c => c));

            for (int i = 0; i < sortedString.Length -1; i++)
            {
                if (sortedString[i] == sortedString[i + 1]) return false;
            }

            return true;
        }

        // The complexity of this implementation is O(N) being N the size of the string.
        // The space complexity is O(1)
        public bool IsUniqueHashArray(string str)
        {
            if (str.Length > 256)
            {
                return false;
            }

            bool[] char_set = new bool[256];
            for (int i = 0; i < str.Length; i++)
            {
                if (char_set[str[i]])
                    return false;

                char_set[str[i]] = true;
            }

            return true;
        }

        // The complexity of this implementation is O(N) being N the size of the string
        public bool IsUniqueHashSet(string str)
        {
            if (str.Length > 256)
            {
                return false;
            }

            HashSet<char> chars = new HashSet<char>();

            for (int i = 0; i < str.Length; i++)
            {
                if (chars.Add(str[i]) == false) return false;
            }

            return true;
        }

        // For simplicity we assume that we are only using lowercase a-z characters in the string
        // The idea is to have a Bit Flag Vector. Therefore if a was in the string the vector will reflect
        // 0000...0001. If a and c were in the string: 0000...0101
        // It is important to note that the & and | operator is bitwise integral numeric types and char type
        // The runtime complexity is still 0(N) but the space factor has been reduced
        public bool IsUniqueBitVector(string str)
        {
            if (str.Length > 256)
            {
                return false;
            }

            var checker = 0;
            for (var i = 0; i < str.Length; i++)
            {
                var val = str[i] - 'a';

                var test = 1 << val;

                if ((checker & (1 << val)) > 0)
                {
                    return false;
                }
                checker |= (1 << val);
            }

            return true;
        }
    }
}
