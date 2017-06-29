using System;
using System.Collections.Generic;

namespace PlayBoxSharedLibrary
{
    [Serializable]
    public class CLCOLog:Log
    {
        public string ClientName { get; set; }

        public uint SessionCount { get { return (uint)Sessions.Count; } }

        public double TotalConsumption
        {
            get
            {
                double total = 0;
                foreach(COSELog session in Sessions)
                    total+=session.TotalConsumption;
                return total;
            } 
        }

        public TimeSpan TotalTime
        {
            get
            {
                TimeSpan total=new TimeSpan(0);
                foreach(COSELog session in Sessions)
                    total+=session.TotalTime;
                return total;
            }
                
        }

        public List<COSELog> Sessions = new List<COSELog> { };

        public CLCOLog(uint id,string clientName,uint sessionCount,double totalConsumption,TimeSpan totalTime)
        {
            Id=id;
            ClientName=clientName;
            Name="Client Consumption Log";
            Type="CLCOxL";
            Date=DateTime.Now;
        }
    }
}