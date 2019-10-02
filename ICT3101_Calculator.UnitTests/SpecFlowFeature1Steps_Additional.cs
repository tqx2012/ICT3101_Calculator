using System;
using TechTalk.SpecFlow;

namespace ICT3101_Calculator.UnitTests
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        [Then(@"the result should be ""(.*)"" on the screen")]
        [Obsolete]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
