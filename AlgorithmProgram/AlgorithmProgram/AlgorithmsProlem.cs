using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class StringPermutation
    {

        /**
        * permutation function
        * @param str string to
        * calculate permutation for
        * @param l starting index
        * @param r end index
        */
        public static void permute(String str, int l, int r)
        {
            if (l == r)
                Console.WriteLine(str);
            else
            {
                for (int i = l; i <= r; i++)
                {
                    str = swap(str, l, i); // str= "BAC"
                    permute(str, l + 1, r);
                }
            }
        }

        /**
         * Swap Characters at position
         * @param a string value
         * @param i position 1
         * @param j position 2
         * @return swapped string
         */
        public static String swap(String a, int i, int j)
        {
            char temp;
            char[] charArray = a.ToCharArray();   // { 'A','B','C'}
            temp = charArray[i];                  // temp = 'A'
            charArray[i] = charArray[j];          // {'B','B','C'}
            charArray[j] = temp;                  // {'B','A','C'}
            string s = new string(charArray);
            return s;
        }

    }

    public class BinarySearch
    {
        //public static void search()
        //{
        //    string str = "snjv is a boy";
        //    string[] arr = str.Split(' ');
        //    Array.Sort(arr);
        //    foreach (var word in arr)
        //    {
        //        System.Console.WriteLine(word);
        //    }
        //}

       public static int binarySearch(String[] arr, String str)
        {
            int low = 0, high = arr.Length - 1;
            while (low <= high)
            {
                int middle = (low + high) / 2;

                int res = str.CompareTo(arr[middle]);
                // Check if str is present at mid
                if (res == 0)
                    return middle;

                // If str greater, ignore left half
                if (res > 0)
                    low = middle + 1;

                // If str is smaller, ignore right half
                else
                    high = middle - 1;
            }

            return -1;
        }

        public static void sortStrings(String[] arr)
        {
            String temp;

            // Sorting strings using bubble sort
            for (int j = 0; j < arr.Length - 1; j++)
            {
                for (int i = j + 1; i < arr.Length; i++)
                {
                    if (arr[j].CompareTo(arr[i]) > 0)
                    {
                        temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
        }
    }

    // INSERTION SORT
    public class InsertionSort
    {
        public static void insertionSort(int[] array)
        {
            for(int i = 1; i < array.Length; i++)
            {
                int temp = array[i];
                int j = i - 1;
                while( j >= 0 && array[j] > temp)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = temp;
            }
        }
        // print inserted array
        public static void printInsertedArray(int[] array)
        {
            for(int i = 0; i < array.Length; ++i)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }

    //BUBBLE SORT
    public class BubbleSort
    {
        public static void bubbleSort(int[] array)
        {
            //int temp;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] >= array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;

                    }
                }
            }
        }
        /* Prints the array */
        public static void printArray(int[] arr)
        {
            // int n = arr.Length;
            for (int i = 0; i < arr.Length; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
    }

    // Prime Numbers in 0-1000 range
    public class PrimeNumber
    {
        public static void primeNumber()
        {
            Console.Write("Enter the number range between 0 - 1000 : " );
            int number = int.Parse(Console.ReadLine());
            bool flag = true;
            if(number <= 1000 && number > 0)
            {
                for (int i = 2; i <= number / 2; i++)
                {
                    if (number % i == 0)
                    {
                        Console.WriteLine($"{number} is a not prime number");
                        flag = false;
                        break;
                    }
                }
                if (flag == true)
                {
                    Console.WriteLine($"{number} is a prime number");
                }
            }
            else
            {
                Console.WriteLine("You Entered out of the range.");
            }
        }
    }
    // CHECK TWO STRINGS ARE ANAGRAMS OR NOT
    public class Anagrams
    {
        /* function to check whether two
        strings are anagram of each other */
        public static void areAnagram(string str1, string str2)
        {
                // Get lengths of both strings
                int n1 = str1.Length;
                int n2 = str2.Length;

                // If length of both strings is not
                // same, then they cannot be anagram
                
            char[] s1 = str1.ToCharArray();
            char[] s2 = str2.ToCharArray();
                // Sort both strings
                Array.Sort(s1);
                Array.Sort(s2);

            if(s1.SequenceEqual(s2))
            {
                Console.WriteLine("Both strings are anagrams.");
            }
            else
            {
                Console.WriteLine("Both Strings are not anagrams.");
            }
        }
    }
    public class MergeSort
    {
        public static string[] MergeSortProg(String[] a, int fIndex, int lIndex)
        {
            if (fIndex < lIndex)
            {
                int mid = (fIndex + lIndex) / 2;
                MergeSortProg(a, fIndex, mid);                        //first array
                MergeSortProg(a, mid + 1, lIndex);                  //second array
                merge(a, fIndex, mid, lIndex);                      //merging both the sorted arrays
            }
            return a;
        }
        public static void merge(String[] givenArr, int fIndex, int mid, int lIndex)
        {
            string[] tempArr = new string[givenArr.Length];
            int i = fIndex;                      //index for the first part of the array
            int j = mid + 1;                //for the second part of the array
            int k = fIndex;                     //index numtempArrer for the new array formed
            while (i <= mid && j <= lIndex)
            {
                if (givenArr[i].CompareTo(givenArr[j]) <= 0)                 //if second array has greater element than the first array element
                {
                    tempArr[k] = givenArr[i];                // tempArr[k] = {given[i]}
                    i++;
                }
                else                                         //if first array has greater element than the seconds array element
                {
                    tempArr[k] = givenArr[j];
                    j++;
                }
                k++;                                    //third array element index incemented
            }
            if (i > mid)                                //if first array has fully tempArreen copied tempArrut second hasn't
            {
                while (j <= lIndex)
                {
                    tempArr[k] = givenArr[j];
                    j++;
                    k++;
                }
            }
            else if (j > lIndex)                            //if second array has fully tempArreen copied tempArrut first hasn't
            {
                while (i <= mid)
                {
                    tempArr[k] = givenArr[i];
                    i++;
                    k++;
                }
            }
            for (int x = fIndex; x <= lIndex; x++)                 //coping data from tempArr array to the first array
            {
                givenArr[x] = tempArr[x];
            }
        }
    }
}
