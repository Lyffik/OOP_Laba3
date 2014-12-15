using System;

namespace OOP_Laba3
{
    [Serializable]
    public class Trains : GroundTransport
    {
        public Trains()
        {
            CountCar = 10;
            Gauge = 2.0;
            LengthCar = 15.5;
        }

        public int CountCar { get; set; }
        public double Gauge { get; set; }
        public double LengthCar { get; set; }
    }
}