using System;

namespace MethodsWithLoopsAndConditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BadGambler();
            MultiplesOfThree();
            Equality();
            EvenOdder();
            Positivity();
            CanVote();
            DigitChecker();
            TimesTables();
        }

        static void BadGambler()
        {
            Console.WriteLine("Press any key to play slots.");
            Console.ReadKey();
            for (int i = 1000; i>=-1000; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("You have lost all of your chips.");
        }

        static void MultiplesOfThree()
        {
            Console.WriteLine("This method will simply print all multiples of any digit that are three digits or less.");
            Console.WriteLine("Please enter a one digit number:");

            int multiple = Int32.Parse(Console.ReadLine());
            for (int i = multiple; i < 1000; i += multiple)
            {
                Console.WriteLine(i);
            }
        }

        static void Equality()
        {
            Console.WriteLine("Enter any two digits, and I'll check whether they're equal for ya!");
            int left = Int32.Parse(Console.ReadLine());
            int right = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"{left} and {right} " + (left==right?"are":"are not") + "equal");
        }

        static void EvenOdder()
        {
            Console.WriteLine("Sometimes, life can get you confused. Enter a number and we'll tell you whether it's odd or not.");
            long number = Int64.Parse(Console.ReadLine());
            Console.WriteLine(number % 2 == 0 ? "This number is even." : "This number is odd");
        }

        static void Positivity()
        {
            Console.WriteLine("Are you an Eyeore or a Tigger today? Enter a number and we'll determine its positivity.");
            long upDown = Int64.Parse(Console.ReadLine());
            if (upDown == 0)
            {
                Console.WriteLine("Zero defies definition");
            } 
            else if (upDown >0)
            {
                Console.WriteLine("This number is definitely positive.");
            }
            else
            {
                Console.WriteLine("This number is unfortunately negative.");
            }
        }

        static void CanVote()
        {
            Console.WriteLine("Welcome to the voting station. Please enter your age.");
            Int32.TryParse(Console.ReadLine(), out int age);

            Console.WriteLine(age>=18?"Please proceed to voting area.":"Sorry Charlie, ya ain't old enough!");
        }

        static void DigitChecker()
        {
            Console.WriteLine("I only like numbers that fit on my miniscreen. Please enter a number to check.");
            Int32.TryParse(Console.ReadLine(), out int digit);
            Console.WriteLine($"{digit} " + (digit > -10&&digit < 10?"does":"does not") + " fit on my miniscreen.");
        }

        static void TimesTables()
        {
            Console.WriteLine("I love to help with math! Which times tables can I calculate for you?");
            Int32.TryParse(Console.ReadLine(), out int bass);
            for (int i = 1; i <= 12 ; i++)
            {
                Console.WriteLine($"{bass} x {i} = {i*bass}");
            }
        }
    }
}
