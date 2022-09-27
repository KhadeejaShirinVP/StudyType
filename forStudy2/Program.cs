using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //writeLine Method Print the value and move the ursor to the next line.
            Console.WriteLine("Hello");
            // Write Method Print the value and estay in the same line.
            Console.Write("Greeting a Day ");
            Console.WriteLine("Divya");
            Console.WriteLine("Bye");
            //Readkey is used to read a single character from the keyboard, and return that character.
            Console.ReadKey();


            string place = "kerala";
            Console.WriteLine(place);
            Console.WriteLine("Welcome to " + place);
            Console.ReadKey();


            //Giving one message to the user
            Console.WriteLine("Enter your Pet name");
            //ReadLine method reads a string value from the keyboard.
            string pet = Console.ReadLine();
            //printing the entered string in the console.
            Console.WriteLine($"So cute {pet}");
            Console.ReadKey();


            //giving a message to user for enter two numbers.
            Console.WriteLine("Enetr two Numbers");
            //converting first string to integer
            int num1 = Convert.ToInt32(Console.ReadLine());
            //converting second string to integer
            int num2 = Convert.ToInt32(Console.ReadLine());
            // the result is Assigned in sum.
            int sum = num1 + num2;
            // 3 types of reult.
            Console.WriteLine("The Sum is: " + sum);
            Console.WriteLine($"The Sum is: {sum}");
            Console.WriteLine($"The Sum is: {num1 + num2}");
            Console.ReadKey();

            //*properties of console*//
            //to sets backgroundColour
            Console.BackgroundColor = ConsoleColor.Black;
            //to sets Foreground Colour
            Console.ForegroundColor = ConsoleColor.Red;
            //to sets the title to diplay in the console.
            Console.Title = "Methods of Console";
            Console.WriteLine("Title: Methods of Console");
            Console.WriteLine("BackgroundColor: Black");
            Console.WriteLine("ForegroundColor: Red");
            //It will make Beep Sound
            Console.Beep();
            Console.ReadKey();


            //**if else
            int number1;
            //giving a message to user for enter a number
            Console.WriteLine("Enter a Number: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            if (number1 > 15)
                Console.WriteLine($"{number1} is greater than 15 ");  //This Statement belongs to IF Block
            else
                Console.WriteLine($"{number1} is less than 15");   //This Statement belongs to ELSE Block
            Console.ReadKey();


            //**ladder if-else
            int b = 40;
            if (b == 10)
                Console.WriteLine("b is 10");
            else if (b == 15)
                Console.WriteLine("b is 15");
            else if (b == 20)
                Console.WriteLine("b is 40");
            else
                Console.WriteLine("b is not available");
            Console.ReadKey();

            //**switch
            string str = "C#";
            Console.WriteLine("Control Flow Statements");
            Console.WriteLine("enter any control flow statement");
            str = Console.ReadLine();
            switch (str)
            {
                case "if":
                case "if-else":
                case "switch":
                    Console.WriteLine("It's a selection statements");
                    break;
                case "for":
                case "while":
                case "do-whie":
                    Console.WriteLine("It's a iteration statements");
                    break;
                case "goto":
                case "break":
                case "continue":
                    Console.WriteLine("It's a jump statements");
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
            Console.ReadKey();


            //*while loop
            int j = 0;
            while (j <= 5)
            {
                Console.WriteLine("Value of j:" + j);
                j++;
            }
            Console.ReadKey();

            //**do while
            int a = 1;
            do
            {
                Console.Write($"{a} ");
                a++;
            } while (a <= 5);
            Console.ReadKey();


            //**for loop
            for (int m = 1; m <= 5; m++) //Outer For Loop
            {
                Console.WriteLine($"numbers are : {m}");
                for (int n = 1; n <= 10; n++) //Inner For Loop
                Console.Write($"{n}");
                Console.WriteLine();
            }
            Console.ReadKey();




        }
    }
}
