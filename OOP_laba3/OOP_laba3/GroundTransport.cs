using System;
using System.Collections.Generic;

namespace OOP_Laba3
{
    [Serializable]
    public class GroundTransport : Transport
    {
        public GroundTransport()
        {
            Motor = new List<Motor>();
            DiameterWheel = 18;
        }

        public List<Motor> Motor { get; set; }
        public int DiameterWheel { get; set; }
    }
}