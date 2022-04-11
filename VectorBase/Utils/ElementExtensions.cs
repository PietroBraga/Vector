using OpenQA.Selenium;

namespace VectorBase.Utils
{
    public static class ElementExtensions
    {
        public static void JSClick(this IWebElement element, IWebDriver driver)
        {
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript("arguments[0].click();", element);
        }

        public static void SendText(this IWebElement element, string text)
        {
            element.Clear();
            element.SendKeys(text);
        }
    }
}
