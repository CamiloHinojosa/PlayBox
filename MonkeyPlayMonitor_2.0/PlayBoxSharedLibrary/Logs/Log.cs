using System;

namespace PlayBoxSharedLibrary
{
    [Serializable]
    public class Log
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Type { get; set; }

        public Log(uint id)
        {
            Id=id;
            Date=DateTime.Now;
        }

        public Log()
        { }

        public string FormattedDate()
        {
            return Date.ToString().Replace('/','-').Replace(':','_');
        }
    }
}