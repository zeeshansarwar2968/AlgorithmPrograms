using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblems
{
    class Anagram
    {
        public static void FindAnagram()
        {
            //taking in input from the user
            Console.Write("Enter the First String : ");
            string string1 = Console.ReadLine();
            Console.WriteLine("Enter the Second String : ");
            string string2 = Console.ReadLine();

            //converting the string inputs from user into a char array using .ToCharArray()
            char[] charArray1 = string1.ToUpper().ToCharArray();
            char[] charArray2 = string2.ToUpper().ToCharArray();
            
            //Sorting both the arrays absed on the ASCII value of characters
            Array.Sort(charArray1);
            Array.Sort(charArray2);

            //Converting the sorted char array back into strings
            string newString1 = new string(charArray1);
            string newString2 = new string(charArray2);
            
            //Check for Anagram
            if (newString1 == newString2)
            {
                Console.WriteLine("The provided strings are anagrams!");

            }
            else
            {
                Console.WriteLine("The provided strings are not anagrams!");
            }
        }
    }
}
