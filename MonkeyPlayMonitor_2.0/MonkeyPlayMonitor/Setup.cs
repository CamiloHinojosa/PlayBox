using System;
using System.Collections.Generic;

namespace PlayBoxMonitor
{
    [Serializable]
    public class Setup
    {
        public int NumberOfConsoles { get; set; }

        public int MaxNumberOFConsoles { get; set; }

        public List<int> AvailableNumberIDs { get; set; }

        public List<GameConsoleSetup> ConsolesSetup { get; set; }

        public string CLINReportName { get; set; }

        public Setup(int maxNumberOfConsoles = 10,int numberOfConsoles = 0,string clinReportName = " ")
        {
            NumberOfConsoles=numberOfConsoles;
            MaxNumberOFConsoles=maxNumberOfConsoles;
            CLINReportName=clinReportName;
            AvailableNumberIDs=new List<int> { };
            ConsolesSetup=new List<GameConsoleSetup> { };
        }

        public Setup Copy()
        {
            return (Setup)MemberwiseClone();
        }
    }
}