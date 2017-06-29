using System;

namespace PlayBoxMonitor
{
    [Serializable]
    public class Settings
    {
        private string logsPath = "Monitor Logs";

        private string errorLogName = "Error Log.txt";

        private string activityLogName = "Activity Log.txt";

        public double MoviePrive { get; set; }

        public double MovieMinimumConsumption { get; set; }

        public int MovieTimeInterval { get; set; }

        public int MoviePerDivisor { get; set; }

        public int MovieLapsConsumption { get; set; }

        public double Price { get; set; }

        public double ExtraControlPrice { get; set; }

        public double MinimumConsumption { get; set; }

        public int MinimumTime { get; set; }

        public int TimeInterval { get; set; }

        public int TimeDivisor { get; set; }

        public int PerDivisor { get; set; }

        public string Currency { get; set; }

        public bool LapsConsumption { get; set; }

        public string LogsPath { get { return logsPath; } }

        public string ErrorLogName { get { return errorLogName; } }

        public string AvtivityLogName { get { return activityLogName; } }

        public Settings(double price = 0.01,double extraControlprice = 0,int timeInterval = 1000,int timeDivisor = 1,int perDivisor = 1,string currency = "$",double minimumConsumption = 1.00,int minimumTime = 1)
        {
            Price=price;
            ExtraControlPrice=extraControlprice;
            TimeInterval=timeInterval;
            TimeDivisor=timeDivisor;
            PerDivisor=perDivisor;
            Currency=currency;
            MinimumConsumption=minimumConsumption;
            MinimumTime=minimumTime;
        }

        public Settings Copy()
        {
            return (Settings)MemberwiseClone();
        }
    }
}