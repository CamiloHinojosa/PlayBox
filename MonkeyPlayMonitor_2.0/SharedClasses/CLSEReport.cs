using System;
using System.Collections.Generic;

namespace PlayBoxReporting
{
    [Serializable]
    public class CLSEReport:Report
    {
        public List<CLSELog> Clients = new List<CLSELog> { };

        public CLSEReport(uint id,string pathName) : base(id,pathName)
        {
            name="Client Sessions Report";
            type="CLSExR";
            fileName=type+id.ToString()+".dat";
            fullFileName=pathName+@"\"+fileName;
        }
    }
}