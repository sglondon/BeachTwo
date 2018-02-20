using System;
using System.Collections.Generic;
using System.Text;

namespace BeachTwo
{
    public abstract class TravelTwo
    {
        //invisible fields

        //properties

        public string EyeColor { get; set; }
        public string BeachName { get; set; }


        //abstract methods

        public abstract int SetEyeValue(string color);
        public abstract string GetBeachLoc(int loc);

    }





}
