using System;


namespace PlacingOrder
{
    class PlacingOrder
    {
        static void Main(string[] args)
        {
            int stock, quantity;
            try
            {
                Console.Write("Please enter stock number: ");
                stock = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter Quantity Order: ");
                quantity = Convert.ToInt32(Console.ReadLine());
            }
            catch(FormatException ex) //this "ex" is optional. If u r not using it then can omit it.
            {
                Console.WriteLine(ex.Message);
                //stock = 0;
                //quantity = 0;
            }
        }
    }
}
