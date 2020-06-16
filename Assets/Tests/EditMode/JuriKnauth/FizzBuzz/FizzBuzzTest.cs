using JuriKnauth.FizzBuzz;
using NUnit.Framework;

namespace Tests
{
    public class FizzBuzzTest
    {
        public class ReturnFizzBuzz
        {
            // Edit Mode
            [Test]
            public void FizzBuzz_ReturnFizzBuzz_Three_ReturnFizz()
            {
                //Arrange
                FizzBuzz fizzBuzz = new FizzBuzz(new BuzzWord[] {new BuzzWord(3, "Fizz")}, 100);

                //Act

                //Assert
                Assert.AreEqual("Fizz", fizzBuzz.ReturnFizzBuzz(3));
            }

            // Edit Mode
            [Test]
            public void FizzBuzz_ReturnFizzBuzz_Five_ReturnBuzz()
            {
                //Arrange
                FizzBuzz fizzBuzz = new FizzBuzz(new BuzzWord[] {new BuzzWord(5, "Buzz") }, 100);

                //Act

                //Assert
                Assert.AreEqual("Buzz", fizzBuzz.ReturnFizzBuzz(5));
            }

            // Edit Mode
            [Test]
            public void FizzBuzz_ReturnFizzBuzz_Fifteen_ReturnFizzBuzz()
            {
                //Arrange
                FizzBuzz fizzBuzz = new FizzBuzz(new BuzzWord[] { new BuzzWord(3, "Fizz"), new BuzzWord(5, "Buzz") }, 100);

                //Act

                //Assert
                Assert.AreEqual("FizzBuzz", fizzBuzz.ReturnFizzBuzz(15));
            }

            // Edit Mode
            [Test]
            public void FizzBuzz_ReturnFizzBuzz_Two_ReturnTwo()
            {
                //Arrange
                FizzBuzz fizzBuzz = new FizzBuzz(new BuzzWord[] { new BuzzWord(3, "Fizz"), new BuzzWord(5, "Buzz") }, 100);

                //Act

                //Assert
                Assert.AreEqual(2.ToString(), fizzBuzz.ReturnFizzBuzz(2));
            }
        }
    }
}