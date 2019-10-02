using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace ICT3101_Calculator.UnitTests
{
    [Binding]
    public class UsingCalculatorDivisionsSteps
    {
        private Calculator _calculator;
        private double _result;

        [Given(@"I have a calculator")]
        [Obsolete]
        public void GivenIHaveACalculator()
        {
            _calculator = new Calculator();
        }

        //Context Injection for SpecFLow division:
        public UsingCalculatorDivisionsSteps(Calculator calc)
        {
            this._calculator = calc;
        }


        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press divide")]
        [Obsolete]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressDivide(int p0, int p1)
        {
            _result = _calculator.Divide(p0, p1);
        }



        [Then(@"the division result should be Infinity on the screen")]
        [Obsolete]
        public void ThenTheDivisionResultShouldBeInfinityOnTheScreen()
        {
            Assert.That(_result, Is.EqualTo(double.PositiveInfinity));
        }

        [Then(@"the division result gives ""(.*)""")]
        [Obsolete]
        public void ThenTheDivisionResultGives(Decimal p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

        [Then(@"the division result gives me ""(.*)""")]
        [Obsolete]
        public void ThenTheDivisionResultGivesMe(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

        [Then(@"the division result is ""(.*)""")]
        [Obsolete]
        public void ThenTheDivisionResultIs(int p0)
        {
            Assert.That(_result, Is.EqualTo(1));

        }
    }
}
