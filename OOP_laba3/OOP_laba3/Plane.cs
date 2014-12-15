using System;
using System.Collections.Generic;

namespace OOP_Laba3
{
    [Serializable]
    public class Plane : Airplane
    {
        public Plane()
        {
            Motor = new List<Motor>();
            Celling = 2000;
            FlightRange = 3500;
        }

        public List<Motor> Motor { get; set; }
        public int Celling { get; set; }
        public int FlightRange { get; set; }
    }
}