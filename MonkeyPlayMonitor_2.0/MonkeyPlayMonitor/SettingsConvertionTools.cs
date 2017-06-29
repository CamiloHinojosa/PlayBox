namespace PlayBoxMonitor
{
    internal static class SettingsConvertionTools
    {
        public static string DeParseCurrency(int currency)
        {
            switch(currency)
            {
                case 0:
                    return "£";

                case 1:
                    return "¥";

                case 2:
                    return "€";

                case 3:
                    return "Bs.";

                case 4:
                    return "$";

                case 5:
                    return "¢";

                case 6:
                    return "c";

                default:
                    return "$";
            }
        }

        public static string ParseTimeDivisorToString(int timeDivisor)
        {
            switch(timeDivisor)
            {
                case 1:
                    return "Second(s)";

                case 60:
                    return "Minute(s)";

                case 3600:
                    return "Hour(s)";

                case 86400:
                    return "Day(s)";

                case 2592000:
                    return "Month(s)";

                default:
                    return "Second(s)";
            }
        }

        public static int ParseTimeDivisor(int timeDivisor)
        {
            switch(timeDivisor)
            {
                case 1:
                    return 4;

                case 60:
                    return 3;

                case 3600:
                    return 2;

                case 86400:
                    return 1;

                case 2592000:
                    return 0;

                default:
                    return 4;
            }
        }

        public static int ParseCurrency(string currency)
        {
            switch(currency)
            {
                case "£":
                    return 0;

                case "¥":
                    return 1;

                case "€":
                    return 2;

                case "Bs.":
                    return 3;

                case "$":
                    return 4;

                case "¢":
                    return 5;

                case "c":
                    return 6;

                default:
                    return 0;
            }
        }

        public static int DeParseTimeDivisor(int selectedIndex)
        {
            switch(selectedIndex)
            {
                case 4:
                    return 1;

                case 3:
                    return 60;

                case 2:
                    return 3600;

                case 1:
                    return 86400;

                case 0:
                    return 2592000;

                default:
                    return 1;
            }
        }
    }
}