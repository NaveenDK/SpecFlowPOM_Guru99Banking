using Guru99.Drivers;

namespace Guru99.Hooks
{
    [Binding]
    public sealed class HookInitialization
    {

        private readonly ScenarioContext _scenarioContext;

 

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
          
            _scenarioContext.Get<IWebDriver>("SeleniumDriver").Quit();

        }


    }
}
