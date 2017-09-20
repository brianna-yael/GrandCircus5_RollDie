using System;

namespace labFive
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            while (run == true)
            {
                int min, max, i = 0;
                Random rando = new Random();
                Console.WriteLine("Welcome to the Grand Circus Casino!");
                run = RollDie();
                Console.WriteLine("Cool! How many sides should each die have?");
                int input = int.Parse(Console.ReadLine());
                min = 1;
                max = ++input;
                Console.WriteLine("Roll 1:");

                while (i < 2)
                {
                    Console.WriteLine(rando.Next(min, max));
                    i++;
                }
                run = Continue();
            }


        }

        public static bool RollDie()
        {
            Console.WriteLine("Roll the die? y/n");
            string answer1 = Console.ReadLine();
            answer1 = answer1.ToLower();
            bool next;
            if (answer1 == "y")
            {
                next = true;
            }
            else if (answer1 == "n")
            {
                next = false;
            }
            else
            {
                Console.WriteLine("I don't understand that, let's try again");
                next = RollDie();
            }

            return next;
        }

        public static bool Continue()
        {
            Console.WriteLine("Do you wish to Continue? y/n");
            string input = Console.ReadLine();
            input = input.ToLower();
            bool goOn;
            if (input == "y")
            {
                goOn = true;
            }
            else if (input == "n")
            {
                goOn = false;
            }
            else
            {
                Console.WriteLine("I don't understand that, let's try again");
                goOn = Continue();
            }

            return goOn;
        }
    }
}
