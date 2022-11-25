using AlgorithmPrograms;

namespace AlgorithmPrograms
{
    public class program
    {
        // Driver Code
        public static void Main()
        {
            //String str = "SAN";
            //int n = str.Length;
            ////  StringPermutation stringPermutation = new StringPermutation();
            //StringPermutation.permute(str, 0, n - 1);


            //// BinarySearch.search();
            //string[] arrName = { "won", "ide", "geeks", "practice", "contribute", "zebra" };

            ////Array.Sort(arrName);
            //BinarySearch.sortStrings(arrName);
            //int result = BinarySearch.binarySearch(arrName, "ide");
            //Console.WriteLine(result);

            //// Insertion Sort
            //int[] array = { 2, 4, 1, 7, 3 };
            //InsertionSort.insertionSort(array);
            //Console.WriteLine("Inserted Array ");
            //InsertionSort.printInsertedArray(array);

            //// Bubble sort
            //int[] arr = { 5, 1, 4, 2, 8 };
            //BubbleSort.bubbleSort(arr);
            //Console.WriteLine("Bubble Sorted array ");
            //BubbleSort.printArray(arr);

            //// Prime Number Range 0 - 1000
            //PrimeNumber.primeNumber();

            //// CHECK STRINGS ARE ANAGRAMS OR NOT
            //Console.WriteLine();
            //Console.Write("Enter first strings : ");
            //string str1 = Console.ReadLine();
            //Console.Write("Enter second strings : ");
            //string str2 = Console.ReadLine();
            //Anagrams.areAnagram(str1, str2);
            ////int result4 = Anagrams.areAnagram(str1, str2);

            //// MERGE SORT

            //String[] array1 = { "ABC", "LCD", "BLM", "ZBC" };
            //Console.WriteLine();
            //string[] newArray = MergeSort.MergeSortProg(array1, 0, array1.Length - 1);
            //Console.WriteLine("Merge sort :- ");
            //for (int i = 0; i < newArray.Length; i++)
            //{
            //    Console.Write(newArray[i] + " ");
            //}

            // UC10 - FIND GUESS NUMBER

            Console.WriteLine("Enter the max limit you want : ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($" the Guess Number from 0 to {num}  ");
            Console.ReadLine();
            FindNumber.guessNumber(num);
            //int pickedNum = Convert.ToInt32(Console.ReadLine());
           // FindNumber.solve(num, pickedNum);


        }
    }
}