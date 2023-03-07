namespace MathProblems.UnitTests
{
    [TestFixture]
    internal class LargestPrimeFactorTest
    {
        [Test]
        public void PrimeFactorization_Factorizing13195_ReturnsListOfFactors()
        {
            var factors = new List<int>
            {
                5,
                7, 
                13, 
                29
            };

            //act 
            var result = LargestPrimeFactor.PrimeFactorization(13195);

            //assert
            for (int i = 0; i < factors.Count; i++)
            {
                Assert.That(factors[i], Is.EqualTo(result[i]));
            }
        }

        [Test]

        public void PrimeFactorization_Factorizing600851475143_ReturnsListOfFactors()
        {
            var factors = new List<int>
            {
                71,
                839,
                1471, 
                6857
            };

            //act 

            var result = LargestPrimeFactor.PrimeFactorization(600851475143);

            //assert
            for (int i = 0; i < factors.Count; i++)
            {
                Assert.That(factors[i], Is.EqualTo(result[i]));
            }

        }

        [Test]

        public void LargestPrime_FindsLargestPrimeFactor_ReturnsTheCorrectResult()
        {
            var number = 6857;

            var result = LargestPrimeFactor.LargestPrime();

            Assert.That(result, Is.EqualTo(number));
        }

    }
}
