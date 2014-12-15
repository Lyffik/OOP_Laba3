using System;
using System.Runtime.Serialization;

namespace OOP_Laba3
{
    [Serializable]
    public class Transport 
    {
        public Transport()
        {
            Name = "NoName";
            RegistrationNumber = "xxxx";
            PassengersCount = 3;
            MaxSpeed = 50;
            Weight = 1000;
        }

        public string Name { get; set; }
        public string RegistrationNumber { get; set; }
        public int PassengersCount { get; set; }
        public int MaxSpeed { get; set; }
        public int Weight { get; set; }

        
       
    }
}