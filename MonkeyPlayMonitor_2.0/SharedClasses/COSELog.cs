using System;
using System.Collections.Generic;

namespace PlayBoxReporting
{
    [Serializable]
    public class COSELog:Log
    {
        public uint ClientId { get; set; }
        public List<COACLog> Logs = new List<COACLog> { };
    }
}