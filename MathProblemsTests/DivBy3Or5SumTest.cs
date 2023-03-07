namespace MathProblemsTests

{
    [TestFixture]
    public class Tests
    {
        
        [Test]
        public void DivisibleBy3_NumberISDivBy3_ReturnsTrue()
        {
            int number = 9;

            //act 

            var result = DivBy3or5.DivisibleBy3(number);

            //assert
            Assert.That(result, Is.EqualTo(true));
        }

        [Test]
        public void DivisibleBy5_NumberISDivBy5_ReturnsTrue()
        {
            int number = 10;

            //act 

            var result = DivBy3or5.DivisibleBy5(number);

            //assert
            Assert.That(result, Is.EqualTo(true));
        }

        [Test]
        public void DivisibleBy3Or5_NumberISDivBy3Or5_ReturnsTrue()
        {
            int number = 15;

            //act 

            var result = (DivBy3or5.DivisibleBy3(number) ||  DivBy3or5.DivisibleBy5(number));

            //assert
            Assert.That(result, Is.EqualTo(true));
        }

        [Test]
        public void DivisibleBy3Or5Sum_GenerateTheSum_ReturnsTheSumOfNumsDivBy3or5()
        {
            int number = 233168;

            //act 

            var result = DivBy3or5.DivisibleBy3Or5Sum();

            //assert
            Assert.That(result, Is.EqualTo(number));
        }
    }
}