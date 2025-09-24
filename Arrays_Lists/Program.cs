namespace Arrays_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArray = new int[5]; // defines an array with 5 elements of zeros
            int[] numbersArray2 = new int[3] { 56, 12, 3 }; // defines the array { 56, 12, 3 }
            int[] numbersArray3 = { 56, 12, 3 }; // same with numbersArray2

            Console.WriteLine("First element of numbersArray: " + numbersArray[0]);
            Console.WriteLine("Length of numbersArray2: " + numbersArray2.Length);
            Console.WriteLine("Second element of numbersArray3: " + numbersArray3[1]);

            // Important note: arrays have a fixed size but the Lists can grow or shrink. But you can also define a size limit for Lists.
            // Ex: List<int> numbersList = new List<int>(3); // 3 is the capacity of the list.

            List<int> numbersList = new List<int>();

            Console.WriteLine("Count of numbersLists: " + numbersList.Count);
            numbersList.Add(12);
            Console.WriteLine("Count of numbersLists: " + numbersList.Count);
            numbersList.Remove(12); // Also useful: numbersList.RemoveAt(0);
            Console.WriteLine("Count of numbersLists: " + numbersList.Count);
            numbersList.Insert(0, 1); // You cannot insert the second or higher elements before there is no element in the first index
            Console.WriteLine("First element of numbersLists: " + numbersList[0]);

            bool isAvailable = numbersList.Contains(89); // tests if the list contains an element
            Console.WriteLine(isAvailable);

            int idx = numbersList.IndexOf(89); // get the index of a specific element, returns -1 if not available in the list.
            Console.WriteLine(idx);

            // We can use for arrays -> System.Array.IndexOf(<list_variable>, <value>);
            int idx_ = System.Array.IndexOf(numbersArray2, 56); // does not work with lists.
            Console.WriteLine(idx_);
        }
    }
}
