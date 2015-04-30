using NFluent;
using NUnit.Framework;

namespace KataLeapYear
{
    public class LeapYearTests
    {
        [Test]
        public void Should_return_true_when_year_is_normal_leap_year()
        {
            Check.That(Year.IsLeap(1996)).IsTrue();
        }
        [Test]
        public void Should_return_false_when_year_is_common_year()
        {
            Check.That(Year.IsLeap(2001)).IsFalse();
        }
        [Test]
        public void Should_return_false_when_year_is_atypical_common_year()
        {
            Check.That(Year.IsLeap(1900)).IsFalse();
        }
        [Test]
        public void Should_return_true_when_year_is_non_common_leap_year()
        {
            Check.That(Year.IsLeap(2000)).IsTrue();
        }
    }
}
