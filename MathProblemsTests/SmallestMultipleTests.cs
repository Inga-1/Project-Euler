using System.Reflection.PortableExecutable;

namespace MathProblems.UnitTests
{
    [TestFixture]
    internal class SmallestMultipleTests
    {
        [Test]
        public void Smallest_TheCorrectResultIsDisplayed()
        {
            //arrange 
            var smallestMultiple = 232792560;

            //act 
            var result = SmallestMultiple.Smallest();

            //assert
            Assert.That(result, Is.EqualTo(smallestMultiple));
        }
    }
}
