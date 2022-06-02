using System;

namespace AlgorithmProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t\t Algorithm Problems");
            Console.WriteLine("\t\t---------------------------------------------------------------------");
            Console.WriteLine("1 :: Insertion Sort Algorithm Implementation");
            Console.WriteLine("2 :: Bubble Sort Algorithm Implementation");
            Console.WriteLine("3 :: Merge Sort Algorithm Implementation");
            Console.WriteLine("4 :: Binary Search the Word from Word List");
            Console.WriteLine("5 :: Anagram Problem");

            Console.WriteLine("\t\t---------------------------------------------------------------------");

            bool flag = true;
            while (flag)
            {
                Console.WriteLine("");
                Console.Write("Please Enter from the options above to start execution : ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 0:
                        flag = false;
                        Console.WriteLine("Exit");
                        break;
                    case 1:
                        Console.WriteLine();
                        InsertionSort insertionSort = new InsertionSort();
                        insertionSort.InsertionSortAlgo();
                        break;
                    case 2:
                        Console.WriteLine();
                        BubbleSort bubbleSort = new BubbleSort();
                        bubbleSort.BubbleSortAlgo();
                        break;
                    case 3:
                        Console.WriteLine();
                        MergeSort mergeSort = new MergeSort();
                        mergeSort.Merge_Sort();
                        break;
                    case 4:
                        Console.WriteLine();
                        string text1 = "Welcome to Algorithm Programs Problem Statement";
                        List<string> words = new List<string>(text1.Split());
                        words.Sort();
                        //BinarySearchWord searchWord = new BinarySearchWord();
                        BinarySearchWord.Search(words);
                        break;
                    case 5:
                        Console.WriteLine();
                        Anagram.FindAnagram();
                        break;
                    default:
                        break;
                }

            }
            

            
        }
    }
}