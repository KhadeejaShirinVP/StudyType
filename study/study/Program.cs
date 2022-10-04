using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers=new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);

            //numbers.Remove(2);-- for remove,here 2 is value.
           // Console.WriteLine(numbers.ElementAt(1));--here 1 is index


            //List<int> numbers2=new List<int>();
            //numbers2.Add(4);
            //numbers2.Add(5);
            //numbers2.Add(6);
            //numbers.AddRange(numbers2); //for concatinaion
            //Console.WriteLine(numbers.Count);
            //Console.ReadKey();

            //List<int> numbers = new List<int>();
            //numbers.Add(1);
            //numbers.Add(2);
            //numbers.Add(3);

            int[] array = new int[] { 10, 20, 30 };
            numbers.AddRange(array);   // concatinating array
            //Console.WriteLine(numbers.Count);
            //Console.ReadKey();
            Console.WriteLine(numbers.ElementAt(3));
            Console.ReadKey();

           
        }
    }
}
