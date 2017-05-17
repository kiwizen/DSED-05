using System;
using System.Collections.Generic;
using System.Text;

namespace GreyHoundApp.Data.DogClass
{
    public class GermanShepherdClass : DogBaseClass
    {
        public GermanShepherdClass()
        {
            breed_Type = DogGeneratorClass.GERMAN_SHEPHARD;
            breed = "German Shepherd";
            origin = "Germany";
            size = M_TYPE;
            steps = 5;
        }
    }
}
