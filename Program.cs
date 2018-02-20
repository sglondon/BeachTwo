using System;

namespace BeachTwo
{
    class Program
    {
        static void Main(string[] args)
        {

            //instantiate travelLoc
            TravelLocTwo loc1 = new TravelLocTwo();
            Hotel loc2 = new Hotel();

            //loc1.GetBeachLoc(loc1.SetEyeValue(color));
            //get user input


            Console.WriteLine("Please enter your eye color"); 
            string color = Console.ReadLine().ToLower();            
            int location = loc1.SetEyeValue(color);
            string vacSpot = loc1.GetBeachLoc(location);           
            
            Console.WriteLine("What is your shoe size?");
            double size = Convert.ToDouble(Console.ReadLine());
            
            string hotel =   loc2.GetHotel(size, location);
            Console.WriteLine("You'll be vacationing at " + vacSpot + " " + hotel);

        }


    }
}
