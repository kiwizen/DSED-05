using System;
using System.Collections.Generic;
using System.Text;

namespace GreyHoundApp.Data.DogClass
{
    public static class DogGeneratorClass
    {
        public const int BEAGLE = 0;
        public const int BULLDOG = 1;
        public const int GERMAN_SHEPHARD = 3;
        public const int GREAT_PYTENEES = 4;
        /// <summary>
        /// dog counter
        /// </summary>
        static private int _counter = 0;
        /// <summary>
        /// generate an unique ID for the dog object.
        /// </summary>
        /// <returns>return an integer</returns>
        public static int GenerateID() { return _counter++; }
    }
}
