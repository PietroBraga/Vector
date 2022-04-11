using OpenQA.Selenium.Edge;

namespace VectorBase.Infrastructure.DriverFactory
{
    internal class EdgeDriverFactory : WebDriverAbstractFactory
    {
        private EdgeOptions options;
        protected override void CreateWebDriver()
        {
            this.driver = new EdgeDriver();
        }

        protected override void SetDriverOptions()
        {
            this.options = new EdgeOptions();
            this.options.AddArgument("--disable-notifications");
        }
    }
}
    