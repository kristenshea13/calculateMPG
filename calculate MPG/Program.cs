using System;

namespace calculate_MPG
{
    class Program
    {
        static void Main(string[] args)
        {
            //program that asks a user for the number of miles they have driven
            //and the amount of gas they've consumed (in gallons), and print their miles-per-gallon.
            Console.WriteLine("Determine your miles per gallon");

            Console.Write("How many miles have you driven? ");
            int milesInt = int.Parse(Console.ReadLine());

            Console.Write("How many gallons of gas have you used? ");
            int gallonsInt = int.Parse(Console.ReadLine());

            int milesperGallon = milesInt / gallonsInt;

            Console.WriteLine("Total miles per gallon: {0}", milesperGallon);

            Console.ReadLine();


        }


    }
}
