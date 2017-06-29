using System;

namespace PlayBox
{
    [Serializable]
    public class ConsoleReportProperties
    {
        public bool ConsoleSessionReportFlag { get; set; }

        public bool ClientInfoReportFlag { get; set; }

        public string ConsoleSessionReportName { get; set; }

        public string ClientInfoReportName { get; set; }

        public string ClientConcomptionReportName { get; set; }

        public uint COSExR_InputReportId { get; set; }

        public void CopyFrom(ConsoleReportProperties inputProperties)
        {
            ConsoleSessionReportFlag = inputProperties.ConsoleSessionReportFlag;
            ClientInfoReportFlag = inputProperties.ClientInfoReportFlag;
            ClientInfoReportName = inputProperties.ClientInfoReportName;
            ClientConcomptionReportName = inputProperties.ClientConcomptionReportName;
            ConsoleSessionReportName = inputProperties.ConsoleSessionReportName;
        }
    }
}