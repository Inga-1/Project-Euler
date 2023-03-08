using System.Reflection.PortableExecutable;

namespace MathProblems.UnitTests
{
    [TestFixture]
    internal class PythagoreanTests
    {
        [Test]
        public void IsPythagorean_TheNumbersArePythagorean_ReturnsTrue()
        {
            var a = 3;
            var b = 4;
            var c = 5;

            var result = Pythagorean.IsPythagorean(a, b, c);
            
            Assert.IsTrue(result);
        }

        [Test]
        public void IsPythagorean_TheNumbersAreNotPythagorean_ReturnsFalse()
        {
            var a = 2;
            var b = 4;
            var c = 5;

            var result = Pythagorean.IsPythagorean(a, b, c);

            Assert.IsFalse(result);
        }

        [Test]
        public void IsPythagorean_TheNumbersAreNotPythagoreanAndThereIsAZero_ReturnsFalse()
        {
            var a = 0;
            var b = 4;
            var c = 5;

            var result = Pythagorean.IsPythagorean(a, b, c);

            Assert.IsFalse(result);
        }

        [Test]
        public void IsPythagorean_TheNumbersAreNotPythagoreanAndAreNegative_ReturnsFalse()
        {
            var a = -3;
            var b = 4;
            var c = 5;

            var result = Pythagorean.IsPythagorean(a, b, c);

            Assert.IsFalse(result);
        }

        [Test]
        public void FindC_BothInputsAreValidForPythagorean_ReturnValidC()
        {
            var a = 3;
            var b = 4;

            var c = Pythagorean.FindC(a, b);

            Assert.That(c, Is.EqualTo(5));
        }

        [Test]
        public void FindC_BothInputsAreInvalid_ReturnInvalidC()
        {
            var a = -3;
            var b = -4;

            var c = Pythagorean.FindC(a, b);

            Assert.That(c, Is.EqualTo(-1));
        }

        [Test]
        public void Triplet_ReturnsTheCorrectResult()
        {
            var product = 31875000;

            var result = Pythagorean.Triplet();

            Assert.That(result, Is.EqualTo(product));
        }
    }
}
