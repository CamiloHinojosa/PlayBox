using System;

namespace PlayBoxMonitor
{
    [Serializable]
    public class GameConsoleProperties
    {
        public bool PrePaid { get; set; }

        public int PrePaidTime { get; set; }

        public decimal ExtraControls { get; set; }

        public int TimeElapsed { get; set; }

        public int LastTimeElapsed { get; set; }

        public double TotalConsumption { get; set; }

        public double LastTotalConsumption { get; set; }

        public double TempConsumption { get; set; }

        public uint Status { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public GameConsoleProperties(bool PrePaid = false,int PrePaidTime = 0,decimal ExtraControls = 0,int TimeElapsed = 0,int LastTimeElapsed = 0,double TotalConsumption = 0,double LastTotalConsumption = 0,uint Status = 0)
        {
            this.PrePaid=PrePaid;
            this.PrePaidTime=PrePaidTime;
            this.ExtraControls=ExtraControls;
            this.TimeElapsed=TimeElapsed;
            this.LastTimeElapsed=LastTimeElapsed;
            this.TotalConsumption=TotalConsumption;
            this.LastTotalConsumption=LastTotalConsumption;
            this.Status=Status;
        }

        public void Copy(GameConsoleProperties inputSettings)//Via input
        {
            try
            {
                EndTime=inputSettings.EndTime;
                ExtraControls=inputSettings.ExtraControls;
                LastTimeElapsed=inputSettings.LastTimeElapsed;
                LastTotalConsumption=inputSettings.LastTotalConsumption;
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