using System;


namespace PlacingOrder
{
    class PlacingOrder
    {
         
        static void Main(string[] args)
        {
                string a = "Please enter stock number: ";
                Console.WriteLine(DataEntry(a));
        }


         public static int DataEntry(string a)
        {
            int stock;
             try
             {
                 Console.Write(a);
                 stock = Convert.ToInt32(Console.ReadLine());
             }
             catch(Exception) //assigning exception obj to a var e.g. "ex" is optional, if u want to use that var. Just the name Exception also does fine.
             {
                 return 0; //code stops here coz "return" & next line is NOT executed
             }
             return stock;
        }
    }
}
