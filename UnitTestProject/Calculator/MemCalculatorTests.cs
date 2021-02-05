using NUnit.Framework;

namespace UnitTestProject.Calculator
{
    [TestFixture]
    public class MemCalculatorTests
    {
        private static MemCalculator MakeCalc()
        {
            return new MemCalculator();
        }

        [Test]
        public void Sum_ByDefault_ReturnsZero()
        {
            var calc = MakeCalc();

            var sum = calc.Sum();

            Assert.That(sum, Is.EqualTo(0));
        }

        [Test]
        public void Add_WhenCalled_ChangesSum()
        {
            var calc = MakeCalc();

            calc.Add(1);
            var sum = calc.Sum();

            Assert.That(sum, Is.EqualTo(1));
        }
    }
}