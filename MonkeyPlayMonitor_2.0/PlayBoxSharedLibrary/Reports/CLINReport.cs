using System;
using System.Collections.Generic;

namespace PlayBoxSharedLibrary
{
    [Serializable]
    public class CLINReport:Report
    {
        public Dictionary<string,CLINLog> Clients = new Dictionary<string,CLINLog> { };

        public Dictionary<string,string> ClientKeys = new Dictionary<string,string> { };

        public string CLCOReportName { get; set; }

        public CLINReport(uint id,string pathName) : base(id,pathName)
        {
            name="Clients Information Report";
            type="CLINxR";
            fileName=type+id.ToString()+".dat";
            fullFileName=pathName+@"\"+fileName;
        }
    }
}