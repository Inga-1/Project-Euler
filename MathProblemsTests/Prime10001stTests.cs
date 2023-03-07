namespace MathProblems.UnitTests
{
    [TestFixture]
    internal class Prime10001stTests
    {
        [Test]
        public void IsPrime_2IsAPrimeNumber_ReturnsTrue()
        {
            var result = Prime10001.IsPrime(2);

            Assert.IsTrue(result);
        }

        [Test]
        public void IsPrime_4IsAPrimeNumber_ReturnsFalse()
        {
            var result = Prime10001.IsPrime(4);

            Assert.IsFalse(result);
        }

        [Test]
        public void IsPrime_NegativeNumberIsAPrimeNumber_ReturnsFalse()
        {
            var result = Prime10001.IsPrime(-3);

            Assert.IsFalse(result);
        }

        [Test]
        public void IsPrime_ZeroIsAPrimeNumber_ReturnsFalse()
        {
            var result = Prime10001.IsPrime(0);

            Assert.IsFalse(result);
        }

        [Test]
        public void PrimeFinder_10001stPrimeNumber_FindsTheCorrectNumber()
        {
            var number = 104743;

            var result = Prime10001.PrimeFinder();

            Assert.That(result, Is.EqualTo(number));
        }
    }
}
