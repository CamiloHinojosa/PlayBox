using System;
using System.Collections.Generic;

namespace PlayBoxSharedLibrary
{
    [Serializable]
    public class COSELog:SEACLog
    {
        public uint ClientId { get; set; }
        public List<COACLog> Logs = new List<COACLog> { };

        public COSELog(uint id)
        {
            Id=id;
            Name="Console Session";
            Date=DateTime.Now;
            Type="COSExS";
        }
    }
}