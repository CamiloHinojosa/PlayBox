using System;

namespace PlayBox
{
    [Serializable]
    public class Settings
    {
        public double Price { get; set; }

        public double MinimumConsumption { get; set; }

        public int MinimumTime { get; set; }

        public int TimeInterval { get; set; }

        public int TimeDivisor { get; set; }

        public int PerDivisor { get; set; }

        public bool LapsConsumptionEnabled { get; set; }

        public bool MinimumConsumptionEnabled { get; set; }

        public Settings(double price = 0.01,double minimumConsumption = 1.00,int minimumTime = 1,double extraControlprice = 0,int timeInterval = 1000,int timeDivisor = 1,int perDivisor = 1,bool lapsConsumption = false,bool minimumConsumptionEnabled = false)
        {
            Price = price;
            MinimumConsumption = minimumConsumption;
            MinimumTime = minimumTime;
            TimeInterval = timeInterval;
            TimeDivisor = timeDivisor;
            PerDivisor = perDivisor;
            LapsConsumptionEnabled = lapsConsumption;
            MinimumConsumptionEnabled = minimumConsumptionEnabled;
        }
    }

    [Serializable]
    public class ProgramSettings
    {
        private string logsPath = "Monitor Logs";

        private string errorLogName = "Error Log.txt";

        private string activityLogName = "Activity Log.txt";

        public string LogsPath { get { return logsPath; } }

        public string ErrorLogName { get { return errorLogName; } }

        public string AvtivityLogName { get { return activityLogName; } }

        public Settings GameSettings { get; set; }

        public Settings VideoSettings { get; set; }

        public string Currency { get; set; }

        public ProgramSettings(string currency = "$")
        {
            GameSettings = new Settings();
            VideoSettings = new Settings();
            Currency = currency;
        }

        public ProgramSettings Copy()
        {
            return (ProgramSettings)MemberwiseClone();
        }
    }
}