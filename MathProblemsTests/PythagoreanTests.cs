namespace MathProblems.UnitTests
{
    [TestFixture]
    internal class PythagoreanTests
    {
        [Test]
        public void IsPythagorean_TheNumbersArePythagorean_ReturnsTrue()
        {
            const int a = 3;
            const int b = 4;
            const int c = 5;

            var result = Pythagorean.IsPythagorean(a, b, c);
            
            Assert.IsTrue(result);
        }

        [Test]
        public void IsPythagorean_TheNumbersAreNotPythagorean_ReturnsFalse()
        {
            const int a = 2;
            const int b = 4;
            const int c = 5;

            var result = Pythagorean.IsPythagorean(a, b, c);

            Assert.IsFalse(result);
        }

        [Test]
        public void IsPythagorean_TheNumbersAreNotPythagoreanAndThereIsAZero_ReturnsFalse()
        {
            const int a = 0;
            const int b = 4;
            const int c = 5;

            var result = Pythagorean.IsPythagorean(a, b, c);

            Assert.IsFalse(result);
        }

        [Test]
        public void IsPythagorean_TheNumbersAreNotPythagoreanAndAreNegative_ReturnsFalse()
        {
            const int a = -3;
            const int b = 4;
            const int c = 5;

            var result = Pythagorean.IsPythagorean(a, b, c);

            Assert.IsFalse(result);
        }

        [Test]
        public void FindC_BothInputsAreValidForPythagorean_ReturnValidC()
        {
            const int a = 3;
            const int b = 4;

            var c = Pythagorean.FindC(a, b);

            Assert.That(c, Is.EqualTo(5));
        }

        [Test]
        public void FindC_BothInputsAreInvalid_ReturnInvalidC()
        {
            const int a = -3;
            const int b = -4;

            var c = Pythagorean.FindC(a, b);

            Assert.That(c, Is.EqualTo(-1));
        }

        [Test]
        public void Triplet_ReturnsTheCorrectResult()
        {
            const int product = 31875000;

            var result = Pythagorean.Triplet();

            Assert.That(result, Is.EqualTo(product));
        }
    }
}
