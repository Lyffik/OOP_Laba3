using System;

namespace OOP_Laba3
{
    [Serializable]
    public class Airplane : AirTransport
    {
        public Airplane()
        {
            Wingspan = 15.0;
            WingArea = 18.0;
        }

        public double Wingspan { get; set; }
        public double WingArea { get; set; }
    }
}