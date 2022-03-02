using NUnit.Framework;
using OpenQA.Selenium;

namespace AutorizationE1Page_Tests
{
    public class Tests
    {
        private IWebDriver driver;

        private readonly By _signInButton = By.XPath("//span[text()='Войти']");
        private readonly By _otherWayToEnter = By.XPath("//span[text()='Другим способом']");
        private readonly By _loginInputText = By.XPath("//input[@name='username']");
        private readonly By _continueButton = By.XPath("//button[@data-name='ContinueAuthBtn']");

        private const string _login = "andrey872007@mail.ru";
        private const string _password = "";


        [SetUp]
        public void Setup()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Navigate().GoToUrl("https://www.cian.ru/");
            driver.Manage().Window.Maximize();


        }


        [Test]
        public void Test1()
        {
            var SignIn = driver.FindElement(_signInButton);
            SignIn.Click();
            System.Threading.Thread.Sleep(300);

            var OtherWayButton = driver.FindElement(_otherWayToEnter);
            OtherWayButton.Click();
            System.Threading.Thread.Sleep(200);

            var LoginInput=driver.FindElement(_loginInputText);
            LoginInput.SendKeys(_login);
            System.Threading.Thread.Sleep(200);

            var buttonContinueAuth=driver.FindElement(_continueButton); 
            buttonContinueAuth.Click();
            System.Threading.Thread.Sleep(200);


            //address address address
            //address address address


            Assert.Pass();
        }


        [TearDown]
        public void TearDown()
        {
            //driver.Close();
        }

    }
}