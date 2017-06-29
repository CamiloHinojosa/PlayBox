namespace PlayBox
{
    internal static class SettingsConvertionTools
    {

        public static string DeParseCurrency(int currency)
        {
            switch(currency)
            {
                case 0:
                    return "$";

                case 1:
                    return "€";

                case 2:
                    return "Bs.";

                default:
                    return "$";
            }
        }

        public static int ParseCurrency(string currency)
        {
            switch(currency)
            {
                case "$":
                    return 0;

                case "€":
                    return 1;

                case "Bs.":
                    return 2;

                default:
                    return 0;
            }
        }

        public static int ParseTimeDivisorTimeToIndex(int timeDivisor)
        {
            switch(timeDivisor)
            {
                case 3600:
                    return 2;

                case 60:
                    return 1;

                case 1:
                    return 0;

                default:
                    return 0;
            }
        }

        public static int DeParseTimeDivisorIndexToTime(int selectedIndex)
        {
            switch(selectedIndex)
            {
                case 2:
                    return 3600;

                case 1:
                    return 60;

                case 0:
                    return 1;

                default:
                    return 1;
            }
        }
    }
}