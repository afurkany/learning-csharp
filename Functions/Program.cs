namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            SayHello();
            Console.WriteLine(AddNumbers(2, 3));
        }

        static void SayHello()
        {
            string playerFirstName = "Furkan";
            string playerSurname = "Yildiz";

            Console.WriteLine("Hello");
            Console.WriteLine($"Hello {playerSurname}, {playerFirstName}. Welcome!");
        }

        static int AddNumbers(int x, int y)
        {
            return x + y;
        }
    }
}
