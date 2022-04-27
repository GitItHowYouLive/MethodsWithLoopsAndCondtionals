using System;

namespace MethodsWithLoopsAndConditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //This block is commented out, but it's how the code would look if we were to strictly follow the directions for calling the methods explicitly.
            /*BadGambler();
            MultiplesOfThree();
            Equality();
            EvenOdder();
            Positivity();
            CanVote();
            DigitChecker();
            TimesTables();*/

            //Quick message to the user. Corny Jokes == Great Jokes.
            Console.WriteLine("Welcome to the methods lab!\nNot to be confused with other similar sounding laboratories...");

            //I declare and initialize the variable here as a quick and dirty way to enter the loop before we've actually received input.
            var selection = 1;

            //This loop is designed to run as long you enter a number from 1-8 at the selection screen. Any other number will exit, and any other input will likely currently lead to an error.
            //I'll update this to account for invalid input soon.
            while(selection > 0 && selection < 9)
            {
                //Quick description of each method and request for input.
                Console.WriteLine("\n\nPlease enter a number 1-8 to choose a method below. All other number will exit the program\n");
                Console.WriteLine("1 - Gambling Simulator");
                Console.WriteLine("2 - Multiplicity");
                Console.WriteLine("3 - Equality Check");
                Console.WriteLine("4 - Evens and Odds");
                Console.WriteLine("5 - Positivity");
                Console.WriteLine("6 - Voting Booth Experience");
                Console.WriteLine("7 - Screen Check");
                Console.WriteLine("8 - 3rd Grade Math Assistant\n");

                //Here we take input and assign it to the selection variable we declared earlier.
                selection = int.Parse(Console.ReadLine());

                //This is where the easiest fix for invalid input would be. TryParse is safer, but we'll need to handle it differently.
                //With TryParse the previous line would be: Int32.TryParse(Console.ReadLine(), out var selection)

                //This is the switch that runs the program. It looks at the selection variable we just set and runs the correct method.
                switch (selection)
                {
                    case 1:
                        BadGambler();
                        break;
                    case 2:
                        MultiplesOfThree();
                        break;
                    case 3:
                        Equality();
                        break;
                    case 4:
                        EvenOdder();
                        break;
                    case 5:
                        Positivity();
                        break;
                    case 6:
                        CanVote();
                        break;
                    case 7:
                        DigitChecker();
                        break;
                    case 8:
                        TimesTables();
                        break;
                    default:
                        Console.WriteLine("Thanks for stopping by!");
                        break;

                }
            }
        }

        static void BadGambler()
        {
            Console.WriteLine("Press any key to play slots.");

            //I used ReadKey instead of ReadLine here since we don't really need any input. ReadKey only looks at the next key press instead of waiting for the user to press enter.
            //Notice that we also don't store that key press anywhere. Again, not needed.
            Console.ReadKey();
            for (var i = 1000; i>=-1000; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("You have lost all of your chips.");
        }

        static void MultiplesOfThree()
        {
            Console.WriteLine("This method will simply print all multiples of any digit that are three digits or less.");
            Console.WriteLine("Please enter a one digit number:");

            //*See earlier note about Parse/TryParse
            //This is also another place where ReadKey could be useful since we're only looking for a one digit number.
            var multiple = int.Parse(Console.ReadLine());
            for (int i = multiple; i < 1000; i += multiple)
            {
                Console.WriteLine(i);
            }
        }

        static void Equality()
        {
            Console.WriteLine("Enter any two numbers, and I'll check whether they're equal for ya!");

            //*See earlier note about Parse/TryParse
            var left = int.Parse(Console.ReadLine());
            var right = int.Parse(Console.ReadLine());
            Console.WriteLine($"{left} and {right} " + (left==right?"are":"are not") + "equal");
        }

        static void EvenOdder()
        {
            Console.WriteLine("Sometimes, life can get you confused. Enter a number and we'll tell you whether it's odd or not.");

            //*See earlier note about Parse/TryParse
            //I used long here just in case the number is huge, but it works the same.
            var number = Int64.Parse(Console.ReadLine());
            Console.WriteLine(number % 2 == 0 ? "This number is even." : "This number is odd");
        }

        static void Positivity()
        {
            Console.WriteLine("Are you an Eyeore or a Tigger today? Enter a number and we'll determine its positivity.");

            //*See earlier note about Parse/TryParse
            //I used long here just in case the number is huge, but it works the same.
            var upDown = Int64.Parse(Console.ReadLine());
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

            //Here is an actual implementation of TryParse. Invalid inputs are treated as zero. Notice the difference between invalid input in these methods vs earlier ones.
            int.TryParse(Console.ReadLine(), out var age);

            Console.WriteLine(age>=18?"Please proceed to voting area.":"Sorry Charlie, ya ain't old enough!");
        }

        static void DigitChecker()
        {
            Console.WriteLine("I only like numbers that fit on my miniscreen. Please enter a number to check.");

            //Here is an actual implementation of TryParse. Invalid inputs are treated as zero. Notice the difference between invalid input in these methods vs earlier ones.
            int.TryParse(Console.ReadLine(), out var digit);
            Console.WriteLine($"{digit} " + (digit > -10&&digit < 10?"does":"does not") + " fit on my miniscreen.");
        }

        static void TimesTables()
        {
            Console.WriteLine("I love to help with math! Which times tables can I calculate for you?");

            //Here is an actual implementation of TryParse. Invalid inputs are treated as zero. Notice the difference between invalid input in these methods vs earlier ones.
            int.TryParse(Console.ReadLine(), out var bass);
            for (var i = 1; i <= 12 ; i++)
            {
                Console.WriteLine($"{bass} x {i} = {i*bass}");
            }
        }
    }
}
