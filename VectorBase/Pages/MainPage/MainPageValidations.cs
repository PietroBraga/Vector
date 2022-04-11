using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using VectorBase.Infrastructure.Base;

namespace VectorBase.Pages.MainPage
{
    public class MainPageValidations
    {
        private readonly IWebDriver driver;
        private MainPageElementMap map;
        private WebDriverWait wait;
        public MainPageValidations(IWebDriver driver, MainPageElementMap map)
        {
            this.driver = driver;
            this.map = map;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        public void GreenCheckIconIsDisplayed()
        {
            wait.Until(d => d.FindElement(By.ClassName("success-check")).Displayed).Should().BeTrue();
        }

        public void WelcomeMessageContains(string text)
        {
            var element = driver.FindElement(By.XPath("//li[@class = 'display-user']"));
            var message = element.GetAttribute("innerText");
            message.Should().Contain(text);
        }

        public void LogOutButtonExists()
        {
            map.LogOutButton.Should().NotBeNull();            
        }

        public void SearchPageIsDisplayed()
        {
            wait.Until(d => d.Url.Contains("search"));
            driver.Title.Should().Contain("ESPN Search");
        }

        public void MySportsListIsNotEmpty()
        {
            List<string> mySportsNames = new List<string>();
            foreach (var item in map.MySports)
            {
                mySportsNames.Add(item.GetAttribute("innerText"));
            }

            mySportsNames.Should().NotContain("You haven't added any favorites to My Sports");
            mySportsNames.FirstOrDefault().Should().Contain("UNFOLLOW");
        }
    }
}