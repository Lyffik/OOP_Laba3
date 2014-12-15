using System;
using System.Runtime.Serialization;

namespace OOP_Laba3
{
    [Serializable]
    public class AirTransport : Transport
    {
        public AirTransport()
        {
            MaxTakeoffWeight = 1000;
            AerodynamicEfficiency = 30.0;
        }

        public int MaxTakeoffWeight { get; set; }
        public double AerodynamicEfficiency { get; set; }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info != null)
            {
                GetObjectData(info,context);
                info.AddValue("Name", Name);
                info.AddValue("RegistrationNumber", RegistrationNumber);
                info.AddValue("PassengersCount", PassengersCount);
                info.AddValue("MaxSpeed", MaxSpeed);
                info.AddValue("Weight", Weight);
            }
        }
    }
}