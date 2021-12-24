using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium
{
    class UnitTest1
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver();
        }

        

        [Test]
        public void Test1()
        {
            driver.Url = "https://www.duckduckgo.com";
            IWebElement searchbar = driver.FindElement(By.Name("q"));
            IWebElement searchbutton = driver.FindElement(By.Id("search_button_homepage"));
            searchbar.SendKeys("LambdaTest");
            searchbar.Submit();
            Assert.Pass();
        }
        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }


    }
}
