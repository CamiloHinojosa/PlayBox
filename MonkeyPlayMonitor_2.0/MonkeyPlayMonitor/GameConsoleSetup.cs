using System;

namespace PlayBoxMonitor
{
    [Serializable]
    public class GameConsoleSetup
    {
        public string Name { get; set; }

        public string ColorID { get; set; }

        public int NumberID { get; set; }

        public bool EditEnabled { get; set; }

        public GameConsoleProperties Properties { get; set; }

        public GameConsoleReportProperties ReportProperties { get; set; }

        public GameConsoleClientInformation ClientData { get; set; }

        public GameConsoleSetup(string Name = "Game Console",string ColorID = "#505055",int NumberID = 0,bool EditEnabled = false)
        {
            this.Name=Name;
            this.ColorID=ColorID;
            this.NumberID=NumberID;
            this.EditEnabled=EditEnabled;
            Properties=new GameConsoleProperties();
            ReportProperties=new GameConsoleReportProperties();
            ClientData=new GameConsoleClientInformation();
        }

        public void CopySettings(GameConsoleSetup outputSettings)//via output
        {
            try
            {
                outputSettings.Name=Name;
                outputSettings.ColorID=ColorID;
                outputSettings.NumberID=NumberID;
                outputSettings.EditEnabled=EditEnabled;
                outputSettings.ClientData=ClientData.Copy();
            } catch(Exception e)
            { MessageLogManager.LogMessage("PBM  - CS ::::> Error copy failed: "+e.Message); }
        }
    }
}