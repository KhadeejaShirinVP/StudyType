using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace NewStudy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string input= "aabbccddaagghhij";
            //string output = "";
            //int count = 0;
            //for (int i = 0; i < input.Length; i++)
            //{
            //    char c = input[i];
            //    if(i== 0)
            //    {
            //        output = output + c;
            //        count++;
            //    }
            //    for(int j = 0; j < i; j++)
            //    {
            //        if(c == input[j])
            //        {
            //            count++;
            //        }
            //    }
            //    if (count == 0)
            //    {
            //        output= output + c;
            //    }
            //    else
            //    {
            //        count =0;
            //    }

            //}
            //Console.WriteLine(output);


            //another way
            string input = "aabbccddaagghhij";
            string output = "";
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (!output.Contains(input[i]))
                {
                    output = output + input[i];
                }
            }
            Console.WriteLine(output);
        }

    }
}
