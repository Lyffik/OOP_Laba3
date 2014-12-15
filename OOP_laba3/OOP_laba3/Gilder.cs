using System;

namespace OOP_Laba3
{
    [Serializable]
    public class Gilder : Airplane
    {
        public Gilder()
        {
            MinRateOfDecline = 0.8;
        }

        public double MinRateOfDecline { get; set; }
    }
}