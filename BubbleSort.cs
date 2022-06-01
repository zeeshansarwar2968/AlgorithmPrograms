using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblems
{
    internal class BubbleSort
    {
        public void BubbleSortAlgo()
        {
            //Initially we are asking the user to define the size of the array
            Console.Write("Please enter size of the array : ");
            int size = Convert.ToInt32(Console.ReadLine());

            //With the input from user we initialise an array array1
            int[] array1 = new int[size];

            //Now we take in values of the array from the user
            Console.WriteLine("Please enter the elements of array : ");
            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter Input : ");
                array1[i] = Convert.ToInt32(Console.ReadLine());
            }
            //flag bool variable is declared to skip loop iterations 
            bool flag = true;
            //The Bubble Sort works by iterating down an array to be sorted from the first element to the last,
            //comparing each pair of elements and switching their positions if necessary.
            //This process is repeated as many times as necessary, until the array is sorted.
            
            //Logical construct to sort the array
            for (int i = 0; (i < size && flag); i++)
            {
                //flag is false, where it will skip the iteration if the inner loop is false and condition is not executed
                flag = false;
                for(int j=0; j< size - 1; j++)
                {
                    //for the inner loop if the condition is true, the elements are swapped and flag is set true
                    if (array1[j+1] > array1[j])
                    {
                        int temp = array1[j];
                        array1[j] = array1[j+1];
                        array1[j+1] = temp;
                        flag = true;
                    }
                }
            }
            BubbleSort.PrintArray(array1);
        }
        //This method is to display all the elements in the array to console
        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

    }
}
