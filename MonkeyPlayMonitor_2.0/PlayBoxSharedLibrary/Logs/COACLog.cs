using System;

namespace PlayBoxSharedLibrary
{
    [Serializable]
    public class COACLog:SEACLog
    {
        public string EventName { get; set; }
        public uint ExtraControls { get; set; }

        public COACLog(uint id)
        {
            Id=id;
            Name="Console Activity Log";
            Date=DateTime.Now;
            Type="COACxL";
        }

        public COACLog CreateCopy()
        {
            COACLog newLog = new COACLog(Id);
            newLog.Date=Date;
            newLog.EndTime=EndTime;
            newLog.EventName=EventName;
            newLog.ExtraControls=ExtraControls;
            newLog.Id=Id;
            newLog.Name=Name;
            newLog.StartTime=StartTime;
            newLog.TotalConsumption=TotalConsumption;
            newLog.TotalTime=TotalTime;
            newLog.Type=Type;
            return newLog;
        }
    }
}