using System;
using System.Collections.Generic;

namespace PlayBoxSharedLibrary
{
    [Serializable]
    public class YECOReport:Report
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

        public YECOReport(uint id,string @pathName) : base(id,pathName)
        {
            name="Yearly Consumption Report";
            type="YECOxR";
            fileName=type+id.ToString()+".dat";
            fullFileName=pathName+@"\"+fileName;
        }

        public List<COSELog> Sessions
        {
            get
            {
                List<COSELog> sessions = new List<COSELog> { };
                foreach(KeyValuePair<string,MOCOLog> log in MOCOLogs)
                    sessions.AddRange(log.Value.Sessions);
                return sessions;
            }
        }

        public Dictionary<string,MOCOLog> MOCOLogs = new Dictionary<string,MOCOLog> { };
    }
}