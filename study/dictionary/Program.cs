using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Dictionary<string, long> PhoneBook = new Dictionary<string, long>();
            //PhoneBook.Add("shirin", 7025461009); //PhoneBook["shirin"] = 7025461009;
            //PhoneBook.Add("afsal", 9744495424); //PhoneBook["afsal"] = 9744495423;
            //PhoneBook.Add("mummy", 8086609498);

            //if (PhoneBook.ContainsKey("mummy"))    //for checking. phonbook il shirin ndo enn nokan.
            //{
            //    Console.WriteLine("mummy number is " + PhoneBook["mummy"]);
            //}
            //Console.ReadKey();

            string name;
            Dictionary<string, long> PhoneBook = new Dictionary<string, long>();
            Console.WriteLine("enter your choose name");
            name = Console.ReadLine();
            PhoneBook.Add("shirin", 7025461009); //PhoneBook["shirin"] = 7025461009;
            PhoneBook.Add("afsal", 9744495424); //PhoneBook["afsal"] = 9744495423;
            PhoneBook.Add("mummy", 8086609498);

            if (PhoneBook.ContainsKey(name))    //for checking. phonbook il shirin ndo enn nokan.
            {
                Console.WriteLine("number is " + PhoneBook[name]);
            }
            //Console.WriteLine(PhoneBook.Count); //for length of phnbook
            Console.ReadKey();

          //Dictionary<string, long> PhoneBook2 = new Dictionary<string, long>();
          //DataStructure<key, value> variable= new variable<key,value>();
          //*key is unique,not allow to null
          //*value allow to null(if enable null)
        }
    }        
}
