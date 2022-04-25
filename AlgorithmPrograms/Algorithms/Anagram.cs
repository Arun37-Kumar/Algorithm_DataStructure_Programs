using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms.Algorithms
{
    class Anagram
    {
        public void isAnagram(String str1, String str2)
        {
            String s1 = str1.Replace("\\s", "");
            String s2 = str2.Replace("\\s", "");
            bool status = true;
            if (s1.Length != s2.Length)
            {
                status = false;
            }
            else
            {
                char[] ArrayS1 = s1.ToLower().ToCharArray();
                char[] ArrayS2 = s2.ToLower().ToCharArray();
                Array.Sort(ArrayS1);
                Array.Sort(ArrayS2);
                status = Array.Equals(ArrayS1, ArrayS2);
            }
            if (status)
            {
                Console.WriteLine(s1 + " and " + s2 + " are anagrams");
            }
            else
            {
                Console.WriteLine(s1 + " and " + s2 + " are not anagrams");

            }
        }
    }
}
