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
                Console.WriteLine();

                choice = Console.ReadLine().Trim().ToLower();

                Console.WriteLine();

                if (choice == "a")
                {
                    Console.WriteLine();
                }
                else if (choice == "b")
                {
                    Console.WriteLine();
                }
                else if (choice == "c")
                {
                    Console.WriteLine();
                }
                else if (choice == "d")
                {
                    Console.WriteLine();
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

        }

        public static void Banking()
        {

        }

        public static void DoublesRoller()
        {


        }



    }
}
