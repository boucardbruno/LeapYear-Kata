namespace KataLeapYear
{
    public static class IntegerExtention
    {
        public static bool IsDivisibleBy(this int year, int modulo)
        {
            return year % modulo == 0;
        }
    }
}