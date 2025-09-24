namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 56;
            Player player = new Player();
            Player codeMonkeyPlayer = new Player();
            Player ironManPlayer = new Player();

            // Each instance is stored in different memory
            Console.WriteLine(player);
            Console.WriteLine(player.GetHashCode());
            Console.WriteLine(codeMonkeyPlayer.GetHashCode());
            Console.WriteLine(ironManPlayer.GetHashCode());

            // We can access to the methods of the instance but the method's access modifier must be public in this case
            codeMonkeyPlayer.SayHello();

            // Since name is defined as publiv, we can read or write it from here
            codeMonkeyPlayer.name = "Iron Man";
            codeMonkeyPlayer.SayHello();

            // Create an enemy instance
            Enemy enemy = new Enemy("Joker");

            // Let's create an enemy with default name
            // Note: new_enemy.name will not be the same with Joker!
            Enemy2 new_enemy = new Enemy2("Joker");
            Console.WriteLine(new_enemy.name);
        }

        // we can create a class inside Program class. It is valid but we cannot create a class inside a function
        class Player
        {
            public string name = "Code Monkey";

            // Constructor (a special function) of the class Player. Constructor name must be same with the class name.
            // When we say public, the above Player definitions can be run.
            public Player()
            {
                Console.WriteLine("Creating Player");
            }

            public void SayHello()
            {
                Console.WriteLine($"Hello {name}!");
            }
        }

        class Enemy
        {
            // We can define some parameters in the constructor
            public Enemy(string name)
            {
                Console.WriteLine($"Enemy with the name {name} created!");
            }
        }

        class Enemy2
        {
            public string name = "Batman!";

            // The name in the constructor is not same with the name above in the Enemy2 class even though they are both name.
            // The name in the constructor is local definition.
            // But we can update class name with the local one. Here, we will use "this" to do it which is similar usage of self in Python. 
            public Enemy2(string name)
            {
                Console.WriteLine($"Before update:");
                Console.WriteLine($"Enemy with the construnctor name: {name}");
                Console.WriteLine($"Enemy with the property name: {this.name}");

                this.name = name;
                Console.WriteLine($"After update:");
                Console.WriteLine($"Enemy with the name {this.name} created!");
            }
        }
    }
}
