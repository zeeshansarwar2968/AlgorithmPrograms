using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblems
{
    class BinarySearchWord
    {
        public static void Search(List<String> words)
        {
            //Initialize Local Variables to control the logical loop construct
            int midPoint, startPoint = 0;
            int endPoint = words.Count - 1;
            bool isFound = false;

            //Taking in input from the user
            Console.Write("Enter the word to be searched in the given list : ");
            string keyValue = Console.ReadLine();

            //Logical contruct where given input is compared to the available list
            while (startPoint <= endPoint)
            {
                //With every itereation of the loop we are checking the input with the elements of the array
                midPoint = (startPoint + endPoint) / 2;
                int result = keyValue.ToUpper().CompareTo(words[midPoint].ToUpper());
                if (result == 0)
                {
                    Console.WriteLine("Word is Present in the provided list");
                    isFound = true;
                    break;
                }
                else if (result > 0)
                {
                    startPoint = midPoint + 1;
                }
                else
                {
                    endPoint = midPoint - 1;
                }
            }
            //Finally if word is not found print not found
            if (!isFound)
            {
                Console.WriteLine("Word does not exist in provided list!");
            }
        }

        
    }
}
