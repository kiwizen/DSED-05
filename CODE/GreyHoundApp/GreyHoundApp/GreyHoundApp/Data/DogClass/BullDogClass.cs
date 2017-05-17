using System;
using System.Collections.Generic;
using System.Text;

namespace GreyHoundApp.Data.DogClass
{
    public class BullDogClass : DogBaseClass
    {
        public BullDogClass()
        {
            breed_Type = DogGeneratorClass.BULLDOG;
            breed = "Bulldog";
            origin = "United Kingdom";
            size = M_TYPE;
            steps = 4;
        }
    }
}
