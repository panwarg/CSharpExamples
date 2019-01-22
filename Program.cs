using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Palin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Palindrome());

            var l = Console.ReadLine();
        }

        private static bool Palindrome()
        {
            var input = "ABCBAHELLOHOWRACECARAREYOUILOVEUEVOLIIAMAIDOINGGOOD";
            var allPals = new List<string>();
            var longestPal = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {                
                for(int j = input.Length - i; j > 0; j--)
                {
                    var str = input.Substring(i, j -1);
                    if (IsPalin(str))
                    {
                        allPals.Add(str);
                        if (str.Length > longestPal.Length)
                        {
                            longestPal = str;
                        }
                    }
                        
                }
            }

            return longestPal != string.Empty;
        }

        private static bool IsPalin(string input)
        {
            if (input.Length < 2) return false;
            for (int i = 0; i < input.Length - i; i++)
            {
                if (input[i] != input[input.Length - i - 1])
                    return false;
            }

            return true;
        }
    }
}
