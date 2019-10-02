using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace ICT3101_Calculator.UnitTests
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        private Calculator _calculator;
        private double _result;
        
        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press add")]
        [Obsolete]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressAdd(int p0, int p1)
        {
            _calculator = new Calculator();
            _result = _calculator.Add(p0, p1);
        }
        
        [Then(@"the result should be ""(.*)""")]
        [Obsolete]
        public void ThenTheResultShouldBe(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}
