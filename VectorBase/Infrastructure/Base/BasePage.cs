using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorBase.Infrastructure.Base
{
    public class BasePage<TMap, TValidations> 
        where TMap : BaseElementMap
    {
        protected IWebDriver driver;
        protected IWait<IWebDriver> wait;
        public TMap map;

        public BasePage(IWebDriver driver, TMap map)
        {
            this.driver = driver;
            this.map = map;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
        }

        public string? Url { get; set; }
       
        public virtual void Open(string part = "")
        {
            this.driver.Navigate().GoToUrl(this.Url + part);
        }
    }
}
