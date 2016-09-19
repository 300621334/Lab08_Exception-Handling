using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("enter a number >> ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(a);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.StackTrace); //where excep originally started & then passed on thru the whole stack
                
                
                //throw ex; //Attemp to re-throw like this will destroy StackTrace & cause err!! http://stackoverflow.com/questions/881473/why-catch-and-rethrow-an-exception-in-c
            }
        }
    }
}
