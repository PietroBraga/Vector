using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorBase.Infrastructure.DriverFactory
{
    public abstract class WebDriverAbstractFactory
    {
        protected IWebDriver driver;

        public WebDriverAbstractFactory()
        {
            this.SetDriverOptions();
            this.CreateWebDriver();
            this.SetTimeouts();
            this.MaximizeWindow();
        }

        internal IWebDriver GetDriver()
        {
            return this.driver;
        }

        protected abstract void CreateWebDriver();

        protected abstract void SetDriverOptions();

        private void MaximizeWindow()
        {
            this.driver.Manage().Window.Maximize();
        }

        private void SetTimeouts()
        {
            this.driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(15);
            this.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
        }
    }
}
