using System;
using System.Collections.Generic;

namespace PlayBoxReporting
{
    [Serializable]
    public class Report
    {
        protected string fileName;
        protected string @pathName;
        protected string @fullFileName;
        protected uint id;
        protected string name;
        protected DateTime date;
        protected string type;

        public List<COSELog> Sessions = new List<COSELog> { };

        public string FormattedDate { get { return date.ToString().Replace('/','-').Replace(':','_'); } }

        public string FileName { get { return fileName; } }
        public string PathName { get { return pathName; } }
        public string FullFileName { get { return fullFileName; } }
        public uint Id { get { return id; } }
        public string Name { get { return name; } }
        public DateTime Date { get { return date; } }
        public string Type { get { return type; } }

        public Report(uint id,string @pathName)
        {
            this.id=id;
            this.pathName=pathName;
            name="Report";
            date=DateTime.Now;
            type="NOxR";
            fileName=type+id.ToString()+" ~ "+FormattedDate+".dat";
            fullFileName=pathName+@"\"+fileName;
        }
    }
}