namespace MathProblems.UnitTests
{
    [TestFixture]
    internal class PalindromeTests
    {
        [Test]
        public void IsReverse_StringsAreMutuallyReverse_returnsTrue()
        {
            var word = "9009";

            var result = Palindrome.IsReverse(word);

            Assert.That(result, Is.EqualTo(word));

        }

        [Test]
        public void IsPalindrome_ReturnsTheCorrectMaxPalindrome()
        {
            var number = 906609;

            var result = Palindrome.IsPalindrome();

            Assert.That(result, Is.EqualTo(number));
        }
    }
}
