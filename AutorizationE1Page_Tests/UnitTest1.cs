using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;

namespace AutorizationE1Page_Tests
{
    public class Tests
    {
        private IWebDriver driver;

        private readonly By _signInButton = By.XPath("//span[text()='Войти']");
        private readonly By _otherWayToEnter = By.XPath("//span[text()='Другим способом']");
        private readonly By _loginInputText = By.XPath("//input[@name='username']");
        private readonly By _continueButton = By.XPath("//button[@data-name='ContinueAuthBtn']");
        private readonly By _labelForCheckBoxesToContinue = By.XPath("//label[@class='_25d45facb5--checkbox--Y2Njc _25d45facb5--checkbox--Iw_6q _25d45facb5--container--QqIhH']");
        private readonly By _approveTheConditions = By.XPath("//span[@class='_25d45facb5--box--FHmxp _25d45facb5--box--LJe53']");
        private readonly By _ContinueAccordingAgreement_Button = By.XPath("//button[@data-name='ContinueBtn']");
        private readonly By _RegisterPassword_TextBox = By.XPath("//input[@name='password']");
        private readonly By _EnterBtn = By.XPath("//button[@data-name='ContinueAuthBtn']");

        private readonly By _Auth_InputPasswordTextBox = By.XPath("//input[@name='password']");
        private readonly By _userLogin = By.XPath("//a[@class='_25d45facb5--full-name--K5jY5']");


        private const string _login = "andrey872007@mail.ru";
        private const string _password = "jFjVjgV3qqgd";
        private const string _expectedUserLogin = "ID 88359356";



        [SetUp]
        public void Setup()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Navigate().GoToUrl("https://www.cian.ru/");
            driver.Manage().Window.Maximize();

        }


        [Test]
        public void Registration()
        {
            var SignIn = driver.FindElement(_signInButton);
            SignIn.Click();
            Thread.Sleep(100);

            var OtherWayButton = driver.FindElement(_otherWayToEnter);
            OtherWayButton.Click();
            Thread.Sleep(100);

            var LoginInput=driver.FindElement(_loginInputText);
            LoginInput.SendKeys(_login);
            Thread.Sleep(100);

            var buttonContinueAuth = driver.FindElement(_continueButton);
            buttonContinueAuth.Click();
            Thread.Sleep(300);

            var _checkBox_IAgree = driver.FindElement(_approveTheConditions);
            _checkBox_IAgree.Click();            
            Thread.Sleep(100);

            var _btn_ContinueWithAgreement = driver.FindElement(_ContinueAccordingAgreement_Button);
            _btn_ContinueWithAgreement.Click();
            Thread.Sleep(100);

            var _inputNewPass = driver.FindElement(_RegisterPassword_TextBox);
            _inputNewPass.SendKeys(_password);

            var _buttonContinueToRegister = driver.FindElement(_EnterBtn);
            _buttonContinueToRegister.Click();
            Thread.Sleep(100);
        }

        [Test]
        public void Autentithication()
        {
            var SignIn = driver.FindElement(_signInButton);
            SignIn.Click();
            Thread.Sleep(100);

            var OtherWayButton = driver.FindElement(_otherWayToEnter);
            OtherWayButton.Click();
            Thread.Sleep(100);

            var LoginInput = driver.FindElement(_loginInputText);
            LoginInput.SendKeys(_login);
            Thread.Sleep(200);

            var buttonContinueAuth = driver.FindElement(_continueButton);
            buttonContinueAuth.Click();
            Thread.Sleep(200);

            var PassAuthInput=driver.FindElement(_Auth_InputPasswordTextBox);
            PassAuthInput.SendKeys(_password);
            Thread.Sleep(1000);

            var _buttonContinueToAuth = driver.FindElement(_EnterBtn);
            _buttonContinueToAuth.Click();
            Thread.Sleep(5400);

            var _actualLogin = driver.FindElement(_userLogin).Text;
            Assert.AreEqual(_expectedUserLogin, _actualLogin, "Login is wrong, check the details.");
        }


        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }




    }
}