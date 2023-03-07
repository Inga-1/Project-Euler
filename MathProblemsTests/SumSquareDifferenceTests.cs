namespace MathProblems.UnitTests
{
    [TestFixture]
    internal class SumSquareDifferenceTests
    {
        [Test]
        public void SumOfSquaresGeneric_CalculatingSumOfSquaresTillNumber10_ReturnsTheCorrectResult()
        {
            var sum = 385;

            var result = SumSquareDifference.SumOfSquaresGeneric(10);

            Assert.AreEqual(sum, result);
        }

        [Test]
        public void SquaresOfSumGeneric_CalculatingSquareOfSumsTillNumber10_ReturnsTheCorrectResult()
        {
            var sum = 3025;

            var result = SumSquareDifference.SquareOfSumsGeneric(10);

            Assert.AreEqual(sum, result);
        }

        [Test]
        public void SumSquareDiffGeneric_CalculatingSumSquareDiffTillNumber10_ReturnsTheCorrectResult()
        {
            var sum = 2640;

            var result = SumSquareDifference.SumSquareDiffGeneric(10);

            Assert.AreEqual(sum, result);
        }

        [Test]
        public void SumOfSquares_CalculatingSumOfSquaresTillNumber100_ReturnsTheCorrectResult()
        {
            var sum = 338350;

            var result = SumSquareDifference.SumOfSquaresGeneric(100);

            Assert.AreEqual(sum, result);
        }

        [Test]
        public void SquaresOfSum_CalculatingSquareOfSumsTillNumber100_ReturnsTheCorrectResult()
        {
            var sum = 25502500;

            var result = SumSquareDifference.SquareOfSumsGeneric(100);

            Assert.AreEqual(sum, result);
        }

        [Test]
        public void SumSquareDiff_CalculatingSumSquareDiffTillNumber100_ReturnsTheCorrectResult()
        {
            var sum = 25502500 - 338350;

            var result = MathProblems.SumSquareDifference.SumSquareDiffGeneric(100);

            Assert.AreEqual(sum, result);
        }
    }
}
