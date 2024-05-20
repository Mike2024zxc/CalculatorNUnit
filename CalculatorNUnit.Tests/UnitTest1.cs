using NUnit.Framework;
using System;

namespace CalculatorNUnit.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void AdditionalMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            int result = calculator.Additional(11, 6);
            Assert.That(result == 17);
        }

        [Test]
        public void SubtractionMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            int result = calculator.Subtraction(11, 6);
            Assert.That(result == 5);
        }

        [Test]
        public void MiltiplicationMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            int result = calculator.Miltiplication(11, 8);
            Assert.That(result == 88);
        }
        [Test]
        public void DivisionMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            int result = calculator.Division(12, 6);
            Assert.That(result == 2);
        }
        [Test]
        public void Division_MustThrowException()
        {
            
            var calculator = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calculator.Division(12, 0));
        }

    }

}