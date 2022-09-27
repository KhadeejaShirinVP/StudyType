using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForStudy
{
    internal class Program
    {
        //**types of variable.
        static int e=33; //*Static Variable
        int f=4567; //*Non-Static or Instance Variable
        //static void Main(string[] args)
        //{
        //    int z; //*Static Variable
        //}
        //*//Constant Variable
        const float PI = 3.14f;

        //*//Readonly Variable   
        readonly int z; 
        //Constructor
        public Program(int a)
        {
            //Initializing non-static variable
            f = a;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("enter a decimal value");
            double num1 = Convert.ToDouble(Console.ReadLine());
            // Explicit type casting
            int num2 = (int)num1;
            Console.WriteLine("original double value : "+ num1);
            Console.WriteLine("Converted int value : "+ num2);
            Console.ReadKey();

            int IntNum1 = 450;
            byte ByteNum1 = (byte)IntNum1; // Explicit Type Casting
            // Printing the Original Value and Converted Value
            Console.WriteLine($"Original Value:{IntNum1} \nand Converted Value:{ByteNum1}");
            Console.ReadKey();

            //Converting string to Integer
            string word = "100";
            int num =Convert.ToInt32(word);
            Console.ReadKey();

            string word1 = "198";
            //Converting string to Integer
            int number = Convert.ToInt32(word1);  
            double d = 567.98;
            //Converting double to Integer
            int number1 = Convert.ToInt32(d);  
            float f = 23.516F;
            //Converting float to string
            string word2 = Convert.ToString(f);

            //**Arithemetic Operators
            int Rst;
            int Num4=9, Num5=2;
            // additional operator
            Rst = (Num4 + Num5);
            //subtraction operator
            Rst = (Num4 - Num5);
            //multiplication operator
            Rst = (Num4 * Num5);
            //divion operator
            Rst = (Num4 / Num5);
            // Modulo Operation
            Rst = (Num4 % Num5);

            //**Assignment Operators
            // Initialize variable x using Simple Assignment Operator "="
            int x = 20;
            x += 10;  //It means x = x + 10 i.e. 20 + 10 = 30
            x -= 5;  //It means x = x - 5 i.e. 20 - 5 = 15
            x *= 5; //It means x = x * 5  i.e. 20 * 5 = 100
            x /= 5; //It means x = x / 5 i.e. 20 / 5 = 4
            x %= 5; //It means x = x % 5 i.e. 20 % 5 = 0


            //**Relational Operators.
            bool rst;
            int k = 5, y = 10;
            // Equal to Operator
            rst = (k == y);
            // Greater than Operator
            rst = (k > y);
            // Less than Operator
            rst = (k < y);          
            // Greater than Equal to Operator
            rst = (k >= y);          
            // Less than Equal to Operator
            rst = (k <= y);           
            // Not Equal To Operator
            rst = (k != y);


            bool m = true, n = false, o;
            //Logical AND operator
            o = m && n;
            //Logical OR operator
            o = m || n;
            //Logical NOT operator
            o = !m;


            //**beark
            for(int i = 0; i <= 10; i++)
            {
                if(i == 5)
                    break;
                Console.WriteLine(i);
            }Console.ReadKey();


            //**continue
            for(int s = 0; s <= 10; s++)
            {
                if (s == 5)
                    continue;
                Console.WriteLine(s);
            }Console.ReadKey();



            //**go to
            int p = 2;
        EVEN:
            Console.Write($"{p} ");
            p += 2;
            if (p <= 30)
                goto EVEN;
            Console.ReadKey();
        }
    }
}
