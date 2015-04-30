namespace KataLeapYear
{
    public class Year
    {
        public static bool IsLeap(int year)
        {
            return year.IsDivisibleBy(4) && !IsAtypicalCommonYear(year);
        }

        private static bool IsAtypicalCommonYear(int year)
        {
            return year.IsDivisibleBy(100) && !year.IsDivisibleBy(400);
        }
    }
}