using System;
using System.Collections.Generic;
using System.Text;

namespace GreyHoundApp.Data.DogClass
{
    public class BeagleClass : DogBaseClass
    {
        public BeagleClass()
        {
            breed_Type = DogGeneratorClass.BEAGLE;
            breed = "Beagle";
            origin = "United Kingdom";
            size = S_TYPE;
            steps = 3;
        }
    }
}
