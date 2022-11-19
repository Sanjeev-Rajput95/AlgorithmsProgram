using AlgorithmPrograms;

namespace AlgorithmPrograms
{
    public class program
    {
        // Driver Code
        public static void Main()
        {
            String str = "SAN";
            int n = str.Length;
            //  StringPermutation stringPermutation = new StringPermutation();
            StringPermutation.permute(str, 0, n - 1);


            // BinarySearch.search();
            string[] arrName = { "won", "ide", "geeks", "practice", "contribute", "zebra" };
            //Array.Sort(arrName);
            BinarySearch.sortStrings(arrName);
            int result = BinarySearch.binarySearch(arrName, "ide");
            Console.WriteLine(result);

            // Insertion Sort
            int[] array = { 2, 4, 1, 7, 3 };
            InsertionSort.insertionSort(array);
            Console.WriteLine("Inserted Array ");
            InsertionSort.printInsertedArray(array);
        }
    }
}