using OpenQA.Selenium.Chrome;

namespace VectorBase.Infrastructure.DriverFactory
{
    internal class ChromeDriverFactory : WebDriverAbstractFactory
    {
        private ChromeOptions options;

        protected override void CreateWebDriver()
        {
            this.driver = new ChromeDriver();
        }

        protected override void SetDriverOptions()
        {
            this.options = new ChromeOptions();
            this.options.AddArgument("--disable-notifications");
        }
    }
}