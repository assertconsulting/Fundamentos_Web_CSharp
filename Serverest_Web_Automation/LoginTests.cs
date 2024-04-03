using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace Serverest_Web_Automation
{
    public class LoginTests
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        [SetUp]
        public void Setup()
        {            
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");

            driver = new ChromeDriver(options);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);   

            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        [Test]
        public void RealizarAutenticacao_ComCredenciaisValidas_DeveRetornarSucesso()
        {
            //Arrange
            driver.Navigate().GoToUrl("https://front.serverest.dev/login");
         
            //Act
            driver.FindElement(By.Id("email")).SendKeys("automation@email.com");
            driver.FindElement(By.Id("password")).SendKeys("123456");            
            driver.FindElement(By.XPath("//*[@id=\"root\"]/div/div/form/button")).Click();

            //Assert
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"navbarTogglerDemo01\"]/form/button")));            
        }

        [TearDown]
        public void Teardown()
        {            
            driver.Quit();
        }
    }
}