using System;
using System.Collections.Generic;

namespace PlayBox
{
    [Serializable]
    public class ProgramSetup
    {
        public List<ConsoleSettings> ConsolesSetup;

        public List<int> UsedIDs = new List<int> { };

        public int NumberOfConsoles { get { return ConsolesSetup.Count; } }

        public int AvailableID
        {
            get
            {
                int i=0;
                while(UsedIDs.Contains(i))
                    i++;
                UsedIDs.Add(i);
                return i;
            }
        }

        public ProgramSetup()
        {
            ConsolesSetup = new List<ConsoleSettings> { };
        }

        public ProgramSetup Copy()
        {
            return (ProgramSetup)MemberwiseClone();
        }
    }
}