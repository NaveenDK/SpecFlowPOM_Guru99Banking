


using Guru99.Drivers;
using Guru99.PageObjects;
using SpecFlowGuru99.PageObjects;



namespace Guru99.StepDefinitions
{
    [Binding]
    class LoginSteps
    {
        IWebDriver driver;


        private readonly ScenarioContext _scenarioContext;


        public LoginSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"User have navigated to Login page")]
        public void GivenUserHaveNavigatedToLoginPage()
        {
            driver = _scenarioContext.Get<SeleniumDriver>("SeleniumDriver").Setup();
            driver.Url = "https://demo.guru99.com/v4";
            Console.WriteLine("Page Loaded FUlly");
        }


        [When(@"User enters valid username and password & clicks login")]
        public void WhenUserEntersValidUsernameAndPasswordClicksLogin()
        {
            String userID = "mngr553017";
            Login login = new Login(driver);
            HomeObject home = login.validLogin(userID, "vasEqEh");
            home.waitForNextPageDisplay();
            Console.WriteLine("Page Loaded FUlly");

        }



        [Then(@"Successful LogIN message should display")]
        public void ThenSuccessfulLogINMessageShouldDisplay()
        {
            Console.WriteLine("Successful Login "); ;
        }

        [When(@"User enters invalid username and password & clicks login")]
        public void WhenUserEntersInvalidUsernameAndPasswordClicksLogin()
        {
            Login login = new Login(driver);
            login.validLogin("ddd", "ddd");

          
        }

        [Then(@"UnSuccessful LogIN message should display")]
        public void ThenUnSuccessfulLogINMessageShouldDisplay()
        {
            IAlert alert = driver.SwitchTo().Alert();
            String alertText = alert.Text;
            Assert.That("User or Password is not valid", Is.EqualTo(alertText));
        }




    }
}
