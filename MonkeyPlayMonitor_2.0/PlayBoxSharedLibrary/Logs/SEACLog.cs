using System;

namespace PlayBoxSharedLibrary
{
    [Serializable]
    public class SEACLog:Log
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public TimeSpan TotalTime { get; set; }
        public double TotalConsumption { get; set; }
    }
}