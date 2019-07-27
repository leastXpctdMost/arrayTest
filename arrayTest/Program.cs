using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayTest
{

    public class Palindrome
    {
        public static bool IsPalindrome(string word)
        {
            string lower = word.ToLower();
            char[] charArray = lower.ToCharArray();
            Array.Reverse(charArray);
            string newString = new String(charArray);
            bool isPalin = false;
            if (lower == newString)
            {
                isPalin = true;
            }
            return isPalin;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome("Hannah"));
            Console.ReadKey();

        }
    }
}
