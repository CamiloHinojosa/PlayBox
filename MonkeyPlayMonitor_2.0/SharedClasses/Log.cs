using System;

namespace PlayBoxReporting
{
    [Serializable]
    public class Log
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Type { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public TimeSpan TotalTime { get; set; }
        public double TotalConsumption { get; set; }

        public string FormattedDate()
        {
            return Date.ToString().Replace('/','-').Replace(':','_');
        }
    }
}