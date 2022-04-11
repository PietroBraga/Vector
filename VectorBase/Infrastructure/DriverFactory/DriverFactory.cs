using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using VectorBase.Infrastructure.TestRunContext;

namespace VectorBase.Infrastructure.DriverFactory
{
    public static class DriverFactory
    {
        private static readonly TestContext testContext;

        private static IWebDriver? driver;

        private static WebDriverWait? wait;

        public static IWebDriver Driver => driver ??= CreateDriver();

        public static WebDriverWait Wait => wait ??= CreateWait();

        static DriverFactory()
        {
            testContext = Context.TestContext;
        }

        public static void QuitDriver()
        {
            if (driver != null) driver.Quit();
            driver = null;
        }

        private static IWebDriver CreateDriver()
        {
            var properties = testContext.Properties;

            var browser = properties["browser"].ToString();

            if (browser == "Chrome")
                return new ChromeDriverFactory().GetDriver();
            if (browser == "Edge")
                return new EdgeDriverFactory().GetDriver();
            if (string.IsNullOrEmpty(browser))
                throw new ArgumentNullException("Browser can't be null.");
            throw new ArgumentException(
                $"Invalid Browser name: {browser}. Expected to be \"Chrome\" or \"Edge\"");
        }

        private static WebDriverWait CreateWait()
        {
            return new WebDriverWait(Driver, TimeSpan.FromSeconds(90));
        }
    }
}