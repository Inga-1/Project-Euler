namespace MathProblems.UnitTests
{
    [TestFixture]
    internal class LargestProductInSeriesTests
    {

        [Test]
        public void LargestProductDigits_ReturnsTheAppropriateListOfFactors()
        {
            var digits = new List<long>
            {
                5,
                5,
                7,
                6,
                6,
                8,
                9,
                6,
                6,
                4,
                8,
                9,
                5
            };

            var result = LargestProductInSeries.LargestProductDigits();

            for (int i = 0; i < result.Count; i++)
            {
                Assert.That(result[i], Is.EqualTo(digits[i]));
            }
        }

        [Test]
        public void LargestProductResult_TheListOfDigitsIsValid_ReturnsTheCorrectNumber()
        {
            var product = 23514624000;
            var digits = new List<long>
            {
                5,
                5,
                7,
                6,
                6,
                8,
                9,
                6,
                6,
                4,
                8,
                9,
                5
            };

            var result = LargestProductInSeries.LargestProductResult(digits);

            Assert.That(result, Is.EqualTo(product));
        }
    }
}
