using System;

namespace OOP_Laba3
{
    [Serializable]
    public class Car : GroundTransport
    {
        public Car()
        {
            DoorsCount = 4;
            Wheelbase = 2;
        }

        public int DoorsCount { get; set; }
        public double Wheelbase { get; set; }
    }
}