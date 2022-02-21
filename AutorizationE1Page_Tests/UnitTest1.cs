using NUnit.Framework;
using OpenQA.Selenium;

namespace AutorizationE1Page_Tests
{
    public class Tests
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Navigate().GoToUrl("https://www.e1.ru/");
        }

        [Test]
        public void Test1()
        {


            Assert.Pass();
        }

        [TearDown]
        public void TearDown()
        {

        }

    }
}