using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.)Binary Word Search\n2.)Permutation Combination\n3.)Merge Sort\n4.)Anagram strings\n5.)Bubble Sort");
            int a = Convert.ToInt32(Console.ReadLine());

            switch (a)
            {
                case 1:
                    {
                        // Binary Word Search
                        Algorithms.BinaryWordSearch bin = new Algorithms.BinaryWordSearch();
                        Algorithms.BubbleSort bubble = new Algorithms.BubbleSort();
                        string[] list = { "I" , "do", "practice","coding", "everyday" };
                        string search = "do";
                        int n = 4;
                        break;
                    }
                case 2:
                    {
                        // Permutation and Combination
                        Console.Write("Enter the string : ");
                        String inputString = Console.ReadLine();
                        String answer = "";
                        Console.Write("\nAll possible strings are : ");
                        Algorithms.PermutationOfString.permutation(inputString, answer);
                        break;
                    }
                case 3:
                    {
                        // Merge Sort
                        Algorithms.MergeSort sort = new Algorithms.MergeSort();
                        int[] arr = { 12, 32, 11, 10, 34, 45 };
                        Console.WriteLine("Elements before sort : ");
                        sort.display(arr, 6);
                        Console.WriteLine("Elements after sort : ");
                        sort.mergesort(arr, 0, 5);
                        sort.display(arr, 6);
                        break;
                    }
                case 4:
                    {
                        Algorithms.Anagram check = new Algorithms.Anagram();
                        check.isAnagram("Earth","Heart");
                        check.isAnagram("Hearth", "Hello");
                        check.isAnagram("aaa", "aaa");
                        break;
                    }
                case 5:
                    {
                        //Bubble Sort
                        Algorithms.BubbleSort bubble = new Algorithms.BubbleSort();
                        int[] list = { 12,23,43,54,11,23,78,09 };
                        Console.WriteLine("Before Bubble Sorting : ");
                        bubble.Display(list);
                        Console.WriteLine("After Bubble Sorting : ");
                        bubble.Sort(list);
                        bubble.Display(list);
                        break;
                    }
            }
            Console.ReadLine();
        }
    }
}
