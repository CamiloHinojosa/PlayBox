using System;

namespace PlayBoxReporting
{
    [Serializable]
    public class COACLog:Log
    {
        public string EventName { get; set; }
        public uint ExtraControls { get; set; }
    }
}