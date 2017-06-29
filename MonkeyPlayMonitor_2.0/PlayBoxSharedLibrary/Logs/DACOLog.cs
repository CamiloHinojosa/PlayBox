using System;
using System.Collections.Generic;

namespace PlayBoxSharedLibrary
{
    [Serializable]
    public class DACOLog:Log
    {
        public List<COSELog> Sessions = new List<COSELog> { };

        public double TotalConsumption
        {
            get
            {
                double totalConsumption = 0;
                foreach(COSELog log in Sessions)
                    totalConsumption+=log.TotalConsumption;
                return totalConsumption;
            }
        }

        public TimeSpan TotalTime
        {
            get
            {
                TimeSpan totalTime = new TimeSpan(0);
                foreach(COSELog log in Sessions)
                    totalTime+=log.TotalTime;
                return totalTime;
            }
        }

        public DateTime StartTime
        {
            get
            {
                return Sessions[0].StartTime;
            }
        }

        public DateTime EndTime
        {
            get
            {
                return Sessions[Sessions.Count-1].EndTime;
            }
        }

        public DACOLog(uint id) : base(id)
        {
            Name="Daily Consumption Report";
            Type="DACOxL";
        }
    }
}