namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*************
             * WHILE LOOP
             *************/
            int i = 0;
            while (i < 3)
            {
                // Console.Write writes the text side by side not in the next line.
                // But Console.WriteLine writes the text and continues with the next line.
                Console.WriteLine($"Loop {i++}");
            }

            /*****************
             * DO WHILE LOOP
             *****************/
            i = 5;
            do
            {
                Console.WriteLine("Run the do part at least one time. Then, check the condition.");
            } while (i < 3);


            /*************
             * FOR LOOP
             *************/
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine("For loop " + j);
            }

            // backward loop
            for (int j = 0; j > -3; j--)
            {
                Console.WriteLine("For loop " + j);
            }

            //// infinite loop
            //for (int j = 0; true; j++)
            //{
            //    Console.WriteLine("For loop " + j);
            //}

            // Example with Array:
            string[] nameArray = new string[] {
                "Code Monkey",
                "Iron Man",
                "Black Widow",
                "Spider-Man"
            };

            //string[] nameArray = {
            //    "Code Monkey",
            //    "Iron Man",
            //    "Black Widow",
            //    "Spider-Man"
            //};

            for (int k = 0; k < nameArray.Length; k++)
            {
                Console.WriteLine(nameArray[k]);
            }

            // Example with List:
            List<string> nameList = new List<string>() {
                "Code Monkey",
                "Iron Man",
                "Black Widow",
                "Spider-Man"
            };

            for (int k = 0; k < nameList.Count; k++)
            {
                Console.WriteLine(nameList[k]);
            }

            /*****************
             * FOR EACH LOOP
             *****************/
            foreach (string name in nameList)
            {
                Console.WriteLine($"for each loop: {name}");
            }
        }
    }
}