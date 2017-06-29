using System;
using System.Collections.Generic;

namespace PlayBoxSharedLibrary
{
    [Serializable]
    public class CLCOReport:Report
    {
        public Dictionary<uint,CLCOLog> Clients = new Dictionary<uint,CLCOLog> { };

        public CLCOReport(uint id,string pathName) : base(id,pathName)
        {
            name="Clients Consumption Report";
            type="CLCOxR";
            fileName=type+id.ToString()+".dat";
            fullFileName=pathName+@"\"+fileName;
        }
    }
}