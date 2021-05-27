using NUnit.Framework;
using RaindropsLibrary;

namespace RaindropTests
{
    public class RaindropTests
    {
        private readonly Raindrops _rdLibrary = new Raindrops();

        [TestCase(-33)]
        [TestCase(-3)]
        [TestCase(6)]
        [TestCase(12)]
        public void GivenThatTheNumberHasAFactorOf3_ThenReturnPling(int number)
        {
            var result = _rdLibrary.PlingPlangPlong(number);
            Assert.That(result, Is.EqualTo("Pling"));
        }


        [TestCase(-50)]
        [TestCase(-5)]
        [TestCase(10)]
        [TestCase(20)]
        public void GivenThatTheNumberHasAFactorOf5_ThenReturnPlang(int number)
        {
            var result = _rdLibrary.PlingPlangPlong(number);
            Assert.That(result, Is.EqualTo("Plang"));
        }

        [TestCase(-49)]
        [TestCase(-7)]
        [TestCase(14)]
        [TestCase(28)]
        public void GivenThatTheNumberHasAFactorOf7_ThenReturnPlong(int number)
        {
            var result = _rdLibrary.PlingPlangPlong(number);
            Assert.That(result, Is.EqualTo("Plong"));
        }

        [TestCase(-30)]
        [TestCase(-15)]
        [TestCase(15)]
        [TestCase(60)]
        public void GivenThatTheNumberHasAFactorOf3And5_ThenReturnPlingPlang(int number)
        {
            var result = _rdLibrary.PlingPlangPlong(number);
            Assert.That(result, Is.EqualTo("PlingPlang"));
        }

        [TestCase(-42)]
        [TestCase(-21)]
        [TestCase(63)]
        [TestCase(84)]
        public void GivenThatTheNumberHasAFactorOf3And7_ThenReturnPlingPlong(int number)
        {
            var result = _rdLibrary.PlingPlangPlong(number);
            Assert.That(result, Is.EqualTo("PlingPlong"));
        }

        [TestCase(-70)]
        [TestCase(-35)]
        [TestCase(35)]
        [TestCase(105)]
        public void GivenThatTheNumberHasAFactorOf5And7_ThenReturnPlangPlong(int number)
        {
            var result = _rdLibrary.PlingPlangPlong(number);
            Assert.That(result, Is.EqualTo("PlangPlong"));
        }

        [TestCase(-210)]
        [TestCase(-105)]
        [TestCase(105)]
        [TestCase(210)]
        public void GivenThatTheNumberHasAFactorOf3And5And7_ThenReturnPlingPlangPlong(int number)
        {
            var result = _rdLibrary.PlingPlangPlong(number);
            Assert.That(result, Is.EqualTo("PlingPlangPlong"));
        }

        [TestCase(-49)]
        [TestCase(-7)]
        [TestCase(14)]
        [TestCase(28)]
        public void GivenThatTheNumberDoesNotHaveAFactorOf3Or5Or7_ThenReturnTheNumber(int number)
        {
            var result = _rdLibrary.PlingPlangPlong(number);
            Assert.That(result, Is.EqualTo(number.ToString()));
        }

        [Test]
        public void GivenThatTheNumberIs0_ThenReturnPlingPlangPlong()
        {
            var result = _rdLibrary.PlingPlangPlong(0);
            Assert.That(result, Is.EqualTo("PlingPlangPlong"));
        }

    }
}

