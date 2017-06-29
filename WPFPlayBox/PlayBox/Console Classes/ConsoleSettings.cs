using System;

namespace PlayBox
{
    [Serializable]
    public class ConsoleSettings
    {
        public string Name { get; set; }

        public string ColorID { get; set; }

        public int NumberID { get; set; }

        public bool EditEnabled { get; set; }

        public ConsoleProperties Properties { get; set; }

        public ConsoleSettings(string Name = "Game Console",string ColorID = "#505055",int NumberID = 0,bool EditEnabled = false)
        {
            this.Name=Name;
            this.ColorID=ColorID;
            this.NumberID=NumberID;
            this.EditEnabled=EditEnabled;
            Properties=new ConsoleProperties();
        }

        public void CopySettings(ConsoleSettings outputSettings)//via output
        {
            try
            {
                outputSettings.Name=Name;
                outputSettings.ColorID=ColorID;
                outputSettings.NumberID=NumberID;
                outputSettings.EditEnabled=EditEnabled;
            } catch(Exception e)
            { MessageLogManager.LogMessage(""); }
        }
    }
}