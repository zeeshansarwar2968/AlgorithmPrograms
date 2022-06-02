using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblems
{
    internal class InsertionSort
    {
        //Algo: The array is virtually split into a sorted and an unsorted part.
        //Values from the unsorted part are picked and placed at the correct position in the sorted part.
        public void InsertionSortAlgo()
        {
            //Taking in value to define size of array 
            Console.Write("Please enter the size of array : ");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            //Initialisation of an array
            string[] words = new string[size];

            //Taking in array elements from the user
            Console.WriteLine("Please enter the string elements of array : ");
            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter Value : ");
                words[i] = Console.ReadLine();
            }

            //Looping through the array and comparing the values/elements
            for (int i = 1; i < words.Length; i++)
            {
                //element is initialised for each loop
                string key = words[i];
                //variable j is initialised to point to the earlier elemnt in the array 
                int j = i - 1;
                //running the loop for each condition where the previous value is greater,
                //the elements are flipped in the array to meet the condition
                while ((j >= 0) && (words[j].CompareTo(key) > 0))
                {
                    words[j + 1] = words[j];
                    j = j - 1;
                }
                //if the above loop is executed, then the next element is assigned the present element value
                words[j + 1] = key;
            }
            Console.WriteLine("Displaying the sorted Array : ");
            //Display the elements in the array
            for (int i = 0; i < words.Length; i++)
            {
                Console.Write(words[i] + " ");
            }
        }
    }
}
