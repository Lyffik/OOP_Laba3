using System;
using System.Collections.Generic;

namespace OOP_Laba3
{
    [Serializable]
    public class Helicopter : AirTransport
    {
        public Helicopter()
        {
            Ceiling = 3500;
            DiameterBlades = 10;
            Motor = new List<Motor>();
            FlightRange = 10000;
        }

        public double Ceiling { get; set; }
        public double DiameterBlades { get; set; }
        public List<Motor> Motor { get; set; }
        public int FlightRange { get; set; }
    }
}