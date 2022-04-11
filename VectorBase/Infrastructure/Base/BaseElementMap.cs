using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorBase.Infrastructure.Base
{
    public class BaseElementMap
    {
        protected IWebDriver driver;

        protected IWait<IWebDriver> wait;

        public BaseElementMap(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
        }
    }
}
