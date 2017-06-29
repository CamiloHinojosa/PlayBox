using System;
using System.Collections.Generic;

namespace PlayBoxSharedLibrary
{
    [Serializable]
    public class MOCOLog:Log
    {
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

        public List<COSELog> Sessions
        {
            get
            {
                List<COSELog> sessions = new List<COSELog> { };
                foreach(KeyValuePair<string,DACOLog> log in DACOLogs)
                    sessions.AddRange(log.Value.Sessions);
                return sessions;
            }
        }

        public Dictionary<string,DACOLog> DACOLogs = new Dictionary<string,DACOLog> { };

        public MOCOLog(uint id) : base(id)
        {
            Name="Monthly Consumption Report";
            Type="MOCOxL";
        }
    }
}