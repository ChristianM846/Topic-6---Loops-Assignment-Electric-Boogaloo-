namespace Topic_6___Loops_Assignment__Electric_Boogaloo_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice = "";

            while (choice != "d")
            {
                Console.WriteLine("Hellow user, welcome to the menu. Please select which program you would like to run:");
                Console.WriteLine();
                Console.WriteLine("a - Prompter");
                Console.WriteLine("b - Simple Banking Machine");
                Console.WriteLine("c - Doubles Roller");
                Console.WriteLine("d - Quit");

                choice = Console.ReadLine().Trim().ToLower();

                Console.WriteLine();

                if (choice == "a")
                {
                    Console.WriteLine();
                    Prompter();
                }
                else if (choice == "b")
                {
                    Console.WriteLine();
                    Banking();
                }
                else if (choice == "c")
                {
                    Console.WriteLine();
                    DoublesRoller();
                }
                else if (choice == "d")
                {
                    Console.WriteLine("You have chosen to quit, goodbye");
                }
                else
                {
                    Console.WriteLine("Inlavid choice, press ENTER to continue");
                    Console.ReadLine();
                }


            }
        }

        public static void Prompter()
        {
            int min, max, betweenNum;

            Console.WriteLine("You have chosen the prompter program.");
            Console.WriteLine("Give me an integer, this will be the minimum vlaue:");

            while (!Int32.TryParse(Console.ReadLine().Trim(), out min))
            {
                Console.WriteLine("That is not a valid input. Please input an integer to use as the minimum value.");
            }

            Console.WriteLine($"The minimum value is {min}, now give me the maximum value:");

            while (!Int32.TryParse(Console.ReadLine().Trim(), out max))
            {
                Console.WriteLine("That is not a valid input. Please input an integer to use as the minimum value.");
            }

        }

        public static void Banking()
        {

        }

        public static void DoublesRoller()
        {


        }



    }
}
