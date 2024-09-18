namespace Topic_6___Loops_Assignment__Electric_Boogaloo_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice = "";

            while (choice != "d")
            {
                Console.WriteLine("Hello user, welcome to the menu. Please select which program you would like to run:");
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
                    Console.WriteLine("You have chosen to quit, goodbye.");
                }
                else
                {
                    Console.WriteLine("Inlavid choice, press ENTER to continue");
                    Console.ReadLine();
                    Console.Clear();
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

            while (!Int32.TryParse(Console.ReadLine().Trim(), out max) || max < min)
            {
                Console.WriteLine($"That is not a valid input. Please input an integer that is equal to or greater than the minimum value of {min}");
            }

            Console.WriteLine($"The maximum value is {max}");
            Console.WriteLine($"Now, enter a number between {min} and {max} (inclusive)");

            while (!Int32.TryParse(Console.ReadLine().Trim(), out betweenNum) || betweenNum < min || betweenNum > max)
            {
                Console.WriteLine($"That is not a valid response. Please input an integer between {min} and {max}");
            }

            Console.WriteLine($"The chosen number between {min} and {max} is {betweenNum}");
            Console.WriteLine("Thank you for using the prompter program.");
            Console.WriteLine("Press ENTER to return to the menu");
            Console.ReadLine();
            Console.Clear();
        }

        public static void Banking()
        {
            string transactionName = "";
            double enterCash;
            double balance = 150;

            while (transactionName != "quit")
            {
                Console.WriteLine("Welcome to the Bank of Blorb");
                Console.WriteLine("Please input you desried transaction:");

                transactionName = Console.ReadLine().Trim().ToLower();
                Console.WriteLine();

                if (transactionName == "deposit")
                {
                    Console.WriteLine("Enter deposit amount:");

                    if (!Double.TryParse(Console.ReadLine().Trim(), out enterCash) || enterCash <= 0)
                    {
                        Console.WriteLine("Error! That is not a valid depsoit amount!");
                        Console.WriteLine("Tranaction canceled. The transaction fee has been applied to your account.");

                        balance -= 0.75;

                        Console.WriteLine($"Your balance is now {balance.ToString("C")}");
                    }
                    else
                    {
                        Console.WriteLine($"{enterCash.ToString("C")} has been added to your account.");

                        balance += enterCash - 0.75;

                        Console.WriteLine($"Your account balance (after transaction fee) is now {balance.ToString("C")}");
                    }
                }
                else if (transactionName == "withdrawal")
                {
                    Console.WriteLine("Enter amount you wish to withdrawal:");

                    if (!Double.TryParse(Console.ReadLine().Trim(), out enterCash) || enterCash <= 0)
                    {
                        Console.WriteLine("Error! That is not a valid depsoit amount!");
                        Console.WriteLine("Tranaction canceled. The transaction fee has been applied to your account.");

                        balance -= 0.75;

                        Console.WriteLine($"Your balance is now {balance.ToString("C")}");
                    }
                    else if (enterCash + 0.75 > balance)
                    {
                        Console.WriteLine("Error! Insufficient funds!");
                        Console.WriteLine("Tranaction canceled. The transaction fee has been applied to your account.");

                        balance -= 0.75;

                        Console.WriteLine($"Your balance is now {balance.ToString("C")}");
                    }
                    else
                    {
                        Console.WriteLine($"{enterCash.ToString("C")} has been withdrawn from your account.");

                        balance -= enterCash + 0.75;

                        Console.WriteLine($"Your account balance (after transaction fee) is now {balance.ToString("C")}");
                    }
                }
                else if (transactionName == "bill payment")
                {
                    Console.WriteLine("You currently have an outstanding bill to pay.");
                    Console.WriteLine("Enter payment amount:");

                    if (!Double.TryParse(Console.ReadLine().Trim(), out enterCash) || enterCash <= 0)
                    {
                        Console.WriteLine("Error! That is not a valid depsoit amount!");
                        Console.WriteLine("Tranaction canceled. The transaction fee has been applied to your account.");

                        balance -= 0.75;

                        Console.WriteLine($"Your balance is now {balance.ToString("C")}");
                    }
                    else if (enterCash + 0.75 > balance)
                    {
                        Console.WriteLine("Error! Insufficient funds!");
                        Console.WriteLine("Tranaction canceled. The transaction fee has been applied to your account.");

                        balance -= 0.75;

                        Console.WriteLine($"Your balance is now {balance.ToString("C")}");
                    }
                    else
                    {
                        Console.WriteLine($"{enterCash.ToString("C")} has been payed.");

                        balance -= enterCash + 0.75;

                        Console.WriteLine($"Your account balance (after transaction fee) is now {balance.ToString("C")}");
                    }
                }
                else if (transactionName == "account balance update" || transactionName == "acu")
                {
                    balance -= 0.75;
                    Console.WriteLine($"Your account balance (after transaction fee) is {balance.ToString("C")}");
                }
                else if (transactionName == "quit")
                {
                    Console.WriteLine("You have chosen to exit the Bank of Blorb terminal.");
                    Console.WriteLine("Goodbye.");
                }
                else
                {
                    Console.WriteLine("That is an invalid input. The transaction fee of $0.75 has been deducted from your account");
                    balance -= 0.75;
                    Console.WriteLine($"Your balance is now {balance.ToString("C")}");
                }
            }

            Console.WriteLine("Thank you for use the Banking program");
            Console.WriteLine("Press ENTER to return to the menu:");
            Console.ReadLine();
            Console.Clear();
        }

        public static void DoublesRoller()
        {
            Die die1 = new Die();
            Die die2 = new Die();
            int rolls = 0;

            Console.WriteLine("Let's roll some dice for doubles!");
            Console.WriteLine("Press ENTER to role two dice:");
            Console.ReadLine();

            do
            {
                rolls++;
                die1.RollDie();
                Console.WriteLine($"Die 1 = {die1}");
                die1.DrawRoll();
                Thread.Sleep(800);
                die2.RollDie();
                Console.WriteLine($"Die 2 = {die2}");
                die2.DrawRoll();
                Console.WriteLine();

                if (die1.Roll != die2.Roll)
                {
                    Console.WriteLine("Not doubles, let's try again.");
                    Console.WriteLine("Press ENTER to roll the dice again:");
                    Console.ReadLine();
                }
            } while (die1.Roll != die2.Roll);

            Console.WriteLine($"{die1} and {die2}, DOUBLES!");
            Console.WriteLine($"And it only took {rolls} tries.");
            Console.WriteLine();
            Console.WriteLine("Thank you for use the Doubles Roller program");
            Console.WriteLine("Press ENTER to return to the menu:");
            Console.ReadLine();
            Console.Clear();


        }



    }
}
