using System;
using System.Collections.Generic;
using System.Text;

namespace GreyHoundApp.Data.PunterClass
{
    public static class PunterGeneratorClass
    {
        /// <summary>
        /// punter counter
        /// </summary>
        static private int _counter = 0;
        /// <summary>
        /// generate an unique ID for the punter object.
        /// </summary>
        /// <returns>return an integer</returns>
        public static int GenerateID() { return _counter++; }
    }
}
