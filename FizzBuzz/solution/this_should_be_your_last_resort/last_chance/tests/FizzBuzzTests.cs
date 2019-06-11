using NUnit.Framework;
using FizzBuzz.Solution;
using System;

namespace FizzBuzz.Tests
{
    public class FizzBuzzTests
    {
        [Test]
        public void CalculatorReturnsANumber()
        {
            FizzBuzzCalculator fizzBuzz = new FizzBuzzCalculator();
            Assert.That(fizzBuzz.Calculate(1), Is.EqualTo("1"));
        }

        [Test]
        public void CalculatorReturnsFizzForThree()
        {
            FizzBuzzCalculator fizzBuzz = new FizzBuzzCalculator();
            Assert.That(fizzBuzz.Calculate(3), Is.EqualTo("Fizz"));
        }

        [Test]
        public void CalculatorReturnsBuzzForFive()
        {
            FizzBuzzCalculator fizzBuzz = new FizzBuzzCalculator();
            Assert.That(fizzBuzz.Calculate(5), Is.EqualTo("Buzz"));
        }
        
        [Test]
        public void CalculatorReturnsFizzBuzzForFifteen()
        {
            FizzBuzzCalculator fizzBuzz = new FizzBuzzCalculator();
            Assert.That(fizzBuzz.Calculate(15), Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void Print1To100()
        {
            FizzBuzzCalculator fizzBuzz = new FizzBuzzCalculator();

            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(fizzBuzz.Calculate(i));
            }
        }
    }
}