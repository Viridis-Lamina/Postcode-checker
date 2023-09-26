using System;

namespace Postcodechecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Postcodes = { "MK4GHT", "SA64B2", "BD27GK", "BD81NE" , "RT38UY" , "GH4BJK" , "JK420B", "LO1A33" , "B105G4", 
                "ER2531"};

            Console.WriteLine("Please enter a post code");
            string code = Console.ReadLine();

            bool check = false;

            for (int i = 0; i < Postcodes.Length; i++)
            {
                if (code == Postcodes[i])
                    {
                    check = true; 
                    break;
            } 
                    }
            if (check == true)
            {
                Console.WriteLine("We deliver to this address!");
            }
            else
            {
                Console.WriteLine("Sorry we don't deliver to that address");
            }

        }
    }
}