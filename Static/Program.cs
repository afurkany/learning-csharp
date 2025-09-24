namespace Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Player.score // we cannot access to score as it is not defined as public.
            Player player = new Player();
            player.SayHelloNonstatic(); // we need to create an instance of that class to call a non-static method.
            // Player.SayHelloNonStatic(); // we cannot call SayHelloNonStatic from the class directly as it is non-static.

            Player.SayHelloStatic(); // but we can call SayHelloStatic from the class as it is static.
        }

        class Player
        {
            // if we define static property, that means you are making that belong to the class itself as opposed to any instance of that class.
            // In other words, for example, score only exists on the class itself and does not exist as a separate copy for each individual object you create of that type.
            // Static fields are always same in all objects. Instead, non-static fields are specific for each object.
            static int score;

            public Player()
            {
                // this.score = 0; // this does not work when you define a static field and update it using "this". To use "this", you need to have a non-static field.
                Player.score = 0; // this works, as the score is called using the class name not its object.
            }

            public void SayHelloNonstatic()
            {
                // For example WriteLine method is also a static method. Therefore, we can call it directly from Console class like Console.WriteLine()
                Console.WriteLine("Hello from non-static method!");
            }

            // Inside of a static function, we can only access to the static fields.
            public static void SayHelloStatic()
            {
                Console.WriteLine("Hello from static method!");
            }
        }
    }
}
