using System;
using System.Collections.Generic;
using System.Text;

namespace GreyHoundApp.Data.DogClass
{
    public class GreatPyreneeClass : DogBaseClass
    {
        public GreatPyreneeClass()
        {
            breed_Type = DogGeneratorClass.GREAT_PYTENEES;
            breed = "Great Pyrenees";
            origin = "France, Spain";
            size = G_TYPE;
            steps = 6;
        }
    }
}
