using System;

namespace PlayBoxMonitor
{
    [Serializable]
    public class GameConsoleReportProperties
    {
        public bool COSExR_Flag { get; set; }

        public string COSExR_Name { get; set; }

        public uint COSExR_Id { get; set; }

        public bool CLINxR_Flag { get; set; }

        public string CLINxR_Name { get; set; }

        public string CLCOxR_Name { get; set; }

        //Input Report Properties DROP EVENT

        public uint COSExR_InputReportId { get; set; }

        public void Copy(GameConsoleReportProperties inputProperties)
        {
            CLINxR_Flag=inputProperties.CLINxR_Flag;
            CLINxR_Name=inputProperties.CLINxR_Name;
            CLCOxR_Name=inputProperties.CLCOxR_Name;
            COSExR_Flag=inputProperties.COSExR_Flag;
            COSExR_Id=inputProperties.COSExR_Id;
            COSExR_Name=inputProperties.COSExR_Name;
        }
    }
}