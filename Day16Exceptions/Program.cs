using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Read a string, , and print its integer value;
//    if  cannot be converted to an integer, print Bad String.
namespace Day16Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();
            try
            {
                int num = Int32.Parse(S);

            }
            catch (FormatException)
            {

                Console.WriteLine("Bad String");
                Console.ReadLine();
            }

        }
    }
}
