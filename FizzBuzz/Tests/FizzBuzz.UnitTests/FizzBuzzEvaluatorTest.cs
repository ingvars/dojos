using NUnit.Framework;

namespace FizzBuzz.UnitTests
{
    [TestFixture]
    public class FizzBuzzEvaluatorTest
    {
        [Test]
        public void EvaluateNumber_NumberIsNotDivisibleByThreeOrFive_NumberAsStringIsReturned()
        {
            var evaluator = new FizzBuzzEvaluator();
            Assert.AreEqual("2", evaluator.EvaluateNumber(2));
        }

        [Test]
        public void EvaluateNumber_NumberIsThree_FizzIsReturned()
        {
            var evaluator = new FizzBuzzEvaluator();
            Assert.AreEqual("Fizz", evaluator.EvaluateNumber(3));
        }

        [Test]
        public void EvaluateNumber_NumberIsDivisibleByThree_FizzIsReturned()
        {
            var evaluator = new FizzBuzzEvaluator();
            Assert.AreEqual("Fizz", evaluator.EvaluateNumber(6));
        }

        [Test]
        public void EvaluateNumber_NumberIsDivisibleByFive_BuzzIsReturned()
        {
            var evaluator = new FizzBuzzEvaluator();
            Assert.AreEqual("Buzz", evaluator.EvaluateNumber(10));
        }

        [Test]
        public void EvaluateNumber_NumberIsDivisibleByThreeAndFive_FizzBuzzIsReturned()
        {
            var evaluator = new FizzBuzzEvaluator();
            Assert.AreEqual("FizzBuzz", evaluator.EvaluateNumber(15));
        }
    }
}
