using System;
using System.Collections.Generic;
using System.Text;

namespace BeachTwo
{
    public class Hotel 
    {

        //addt'l fields

        private double shoeSize;


        //addt'l property

        public double ShoeSize
        {
            get { return this.shoeSize; }
            set { this.shoeSize = value; }
        }

        //constructors

        public Hotel()
        {
            //default constructor
        }

        //method

        public string GetHotel(double size, int location)
        {
            if ((size == 10.5) && (location == 1))
            {
                return "and you'll be staying at the Marriott!";
            }
            else if ((size == 10.5) && (location == 2))
            {
                return "and you'll be staying at the Best Western!";
            }
            else if ((size == 10.5) && (location == 3))
            {
                return "and you'll be staying at the Travel Lodge Inn!";
            }

            else if ((size == 6.5) && (location == 1))
            {
                return "and you'll be staying at the Holiday Inn!";
            }
            else if ((size == 6.5) && (location == 2))
            {
                return "and you'll be staying at the Radisson!";
            }
            else if ((size == 6.5) && (location == 3))
            {
                return "and you'll be staying at the Hyatt!";
            }
            else return "and you'll be sleeping on the sand!";
        }

    }
}
