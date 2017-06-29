using System;

namespace PlayBox
{
    [Serializable]
    public class ConsoleProperties
    {
        public bool PrePaid { get; set; }

        public int PrePaidTime { get; set; }

        public int TimeElapsed { get; set; }

        public double TotalConsumption { get; set; }

        public string DisplayConsumption { get { return TotalConsumption.ToString("00.00"); } }

        public string DisplayTime { get { return TimeSpan.FromSeconds(TimeElapsed).ToString(); } }

        public uint ConsumptionType { get; set; }

        public uint Status { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public ConsoleProperties(bool PrePaid = false,int PrePaidTime = 0,int TimeElapsed = 0,double TotalConsumption = 0, uint ConsumptionType=0,double LastTotalConsumption = 0,uint Status = 0)
        {
            this.PrePaid=PrePaid;
            this.PrePaidTime=PrePaidTime;
            this.TimeElapsed=TimeElapsed;
            this.TotalConsumption=TotalConsumption;
            this.ConsumptionType = ConsumptionType;
            this.Status=Status;
        }

        public void CopyFrom(ConsoleProperties inputSettings)
        {
            try
            {
                EndTime=inputSettings.EndTime;
                PrePaid=inputSettings.PrePaid;
                PrePaidTime=inputSettings.PrePaidTime;
                StartTime=inputSettings.StartTime;
                Status=inputSettings.Status;
                TimeElapsed=inputSettings.TimeElapsed;
                TotalConsumption=inputSettings.TotalConsumption;
            } catch(Exception e)
            { MessageLogManager.LogMessage("PBM  - CP ::::> Error copy failed: "+e.Message); }
        }
    }
}