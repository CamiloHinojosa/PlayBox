using System;
using System.Collections.Generic;

namespace PlayBoxReporting
{
    [Serializable]
    public class COSEReport:Report
    {
        public uint consoleId;
        public string consoleName;

        public new List<COSELog> Sessions = new List<COSELog> { };

        public uint ConsoleId { get { return consoleId; } }
        public string ConsoleName { get { return consoleName; } }

        public COSEReport(uint id,string pathName,uint consoleId,string consoleName) : base(id,pathName)
        {
            name="Console Activity Report";
            type="COSExR";
            fileName=type+id.ToString()+" ~ "+consoleName+" ("+consoleId+").dat";
            fullFileName=pathName+@"\"+fileName;
            this.consoleId=consoleId;
            this.consoleName=consoleName;
        }
    }
}