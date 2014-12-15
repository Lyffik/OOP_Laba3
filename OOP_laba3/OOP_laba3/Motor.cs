using System;

namespace OOP_Laba3
{
    [Serializable]
    public class Motor
    {
        public Motor()
        {
            Efficiency = 0.5;
            Torque = 250;
            Power = 150;
            Volume = 2.0;
            Fuel = 60.0;
        }

        public double Efficiency { get; set; }
        public int Torque { get; set; }
        public int Power { get; set; }
        public double Volume { get; set; }
        public int CountCylinders { get; set; }
        public double Fuel { get; set; }
    }
}