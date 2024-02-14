using Guru99.Drivers;
using OpenQA.Selenium;

using TechTalk.SpecFlow;

namespace Guru99.Hooks
{
    [Binding]
    public sealed class HookInitialization
    {

        private readonly ScenarioContext _scenarioContext;

        //public HookInitialization(ScenarioContext scenarioContext)
        //{
        //    _scenarioContext = scenarioContext;
        //}

        public HookInitialization(ScenarioContext scenarioContext) => _scenarioContext = scenarioContext;

        [BeforeScenario]
        public void BeforeScenarioWithTag()
        {

            SeleniumDriver seleniumDriver = new SeleniumDriver(_scenarioContext);
            _scenarioContext.Set(seleniumDriver, "SeleniumDriver");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario
            _scenarioContext.Get<IWebDriver>("SeleniumDriver").Quit();

        }


    }
}
