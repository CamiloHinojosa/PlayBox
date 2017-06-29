using System;

namespace PlayBoxReporting
{
    [Serializable]
    public class CLSELog:Log
    {
        public uint SessionId { get; set; }
        public string ConsoleName { get; set; }
        public uint ConsoleId { get; set; }
    }
}