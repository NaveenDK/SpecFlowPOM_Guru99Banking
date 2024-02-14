using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace Guru99.Drivers
{
    public class SeleniumDriver
    {
        private IWebDriver driver;

        private readonly ScenarioContext _scenarioContext;

        public SeleniumDriver(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }


        public IWebDriver Setup()
        {


            var chromeOptions = new ChromeOptions();
            // This creates a new instance of Chrome, which will open a Chrome browser locally
            driver = new ChromeDriver(chromeOptions);

            // Set the driver in the scenario context so it can be accessed later
            _scenarioContext.Set(driver, "SeleniumDriver");

            driver.Manage().Window.Maximize();

            return driver;
        }

    }
}
