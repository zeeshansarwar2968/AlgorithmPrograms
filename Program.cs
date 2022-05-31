using System;

namespace AlgorithmProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t\t Algorithm Problems");
            Console.WriteLine("\t\t---------------------------------------------------------------------");
            Console.WriteLine("1 :: Insertion Sort Implementation");
            Console.Write("Please Enter from the options above to start execution : ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 0:
                    Console.WriteLine("Exit");
                    break;
                case 1:
                    Console.WriteLine();
                    InsertionSort insertionSort = new InsertionSort();
                    insertionSort.InsertionSortAlgo();
                    break;
                default:
                    break;
            }
        }
    }
}