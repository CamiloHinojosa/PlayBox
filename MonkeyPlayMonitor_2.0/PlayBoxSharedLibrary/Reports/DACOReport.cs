using System;
using System.Collections.Generic;

namespace PlayBoxSharedLibrary
{
    [Serializable]
    public class DACOReport:Report
    {
        public List<COSELog> Sessions = new List<COSELog> { };

        public DACOReport(uint id,string @pathName) : base(id,pathName)
        {
            name="Daily Consumption Report";
            type="DACOxR";
            date=DateTime.Now;
        }
    }
}