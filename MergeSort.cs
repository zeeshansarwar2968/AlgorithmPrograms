using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblems
{
    class MergeSort
    {
        public void Merge_Sort()
        {
            //Taking in the size of the arry from the user
            Console.Write("Please enter size of the array : ");
            int size = Convert.ToInt32(Console.ReadLine());

            //creating an array of size defined by the user
            int[] array = new int[size];
            Console.WriteLine("Enter values for the elements of array : ");
            
            //Adding in the values to the array
            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter Value : ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            //Calling the sort method to implement sortng logic
            Sort(array, 0, size - 1);

            //Printing the sorted array
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        //Method to break the array into two parts recursively until just singular elements are left and then sort them
        public static int Sort(int[] array, int firstIndexValue, int lastIndexValue)
        {
            if (lastIndexValue > firstIndexValue)
            {
                //finding mid point of array to divide it
                int mid = (firstIndexValue + lastIndexValue) / 2;

                //Calling sort method for both halves
                Sort(array, firstIndexValue, mid);
                Sort(array, mid + 1, lastIndexValue);

                //Calling merge method to sort the array
                Merge(array, firstIndexValue, mid, lastIndexValue);
            }
            return -1;
        }

        //Merge Method is defined/created to sort the values in order from two children arrays
        public static void Merge(int[] array, int firstIndexValue, int mid, int lastIndexValue)
        {
            int size1 = mid - firstIndexValue + 1;
            int size2 = lastIndexValue - mid;

            //creating two array from the initial stateful array
            int[] firstArray = new int[size1];
            int[] secondArray = new int[size2];
            //Assigning values to the firstArray and secondArray 
            for (int i = 0; i < size1; i++)
            {
                firstArray[i] = array[firstIndexValue + i];
            }
            for (int i = 0; i < size2; i++)
            {
                secondArray[i] = array[mid + 1 + i];
            }
            //looping through arrays and rearranging them in order
            int x = 0, y = 0;
            int k = firstIndexValue;
            while (x < size1 && y < size2)
            {
                if (firstArray[x] > secondArray[y])
                {
                    array[k] = secondArray[y];
                    y++;
                }
                else
                {
                    array[k] = firstArray[x];
                    x++;
                }
                k++;
            }

            //Copying the remainder values
            while (x < size1)
            {
                array[k] = firstArray[x];
                x++;
                k++;
            }
            //Copying the remainder values
            while (y < size2)
            {
                array[k] = secondArray[y];
                y++;
                k++;
            }
        }

    }
}
