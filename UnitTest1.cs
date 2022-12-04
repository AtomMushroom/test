using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestFixture()]
    public class Test
    {
        private IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }
        [Test()]
        public void TestCase1()
        {
            driver.Navigate().GoToUrl("https://shahty.ru/");
            driver.FindElement(By.ClassName("menu_top_block")).Click(); //переход "Новости"
            Assert.IsTrue(driver.Url.Contains("https://shahty.ru/news/"), "Курва1");
        }
        [Test()]
        public void TestCase2()
        {
            driver.Navigate().GoToUrl("https://shahty.ru/");
            driver.FindElement(By.CssSelector("[href*='/news/news_30591.html']")).Click(); //ткнуть картинку
            Assert.IsTrue(driver.Url.Contains("https://shahty.ru/news/news_30591.html"), "Курва2");
        }
        [Test()]
        public void TestCase3()
        {
            driver.Navigate().GoToUrl("https://shahty.ru/");
            driver.FindElement(By.ClassName("ya-site-form__input-text")).SendKeys("гей");
            driver.FindElement(By.ClassName("ya-site-form__submit")).Click();
            driver.FindElement(By.ClassName("b-head__found"));
        }
    }
}