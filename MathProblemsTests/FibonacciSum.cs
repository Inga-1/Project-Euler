namespace MathProblems.UnitTests
{
    [TestFixture]
    public class FibonacciSum
    {
        [Test]
        public void SumOfEvenFibonacciTo4Million_CalculatesTheNumber_ReturnsTheCorrectValue()
        {
            var sum = 4613732;

            //act 
            var result = Fibonacci.SumOfEvenFibonacciTo4Million();

            //assert
            Assert.AreEqual(sum, result);

        }

    }
}
