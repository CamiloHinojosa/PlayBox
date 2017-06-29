using System;
using System.Collections.Generic;

namespace PlayBoxSharedLibrary
{
    [Serializable]
    public class COSEReport:Report
    {
        private uint consoleId;
        private string consoleName;

        public List<COSELog> Sessions = new List<COSELog> { };

        public uint ConsoleId { get { return consoleId; } }
        public string ConsoleName { get { return consoleName; } }

        public COSEReport(uint id,string pathName,uint consoleId,string consoleName) : base(id,pathName)
        {
            name="Console Session Report";
            type="COSExR";
            fileName=type+id.ToString()+" ~ "+consoleName+" ("+consoleId+").dat";
            fullFileName=pathName+@"\"+fileName;
            this.consoleId=consoleId;
            this.consoleName=consoleName;
        }
    }
}