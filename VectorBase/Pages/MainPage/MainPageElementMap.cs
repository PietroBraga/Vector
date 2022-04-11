using OpenQA.Selenium;
using VectorBase.Infrastructure.Base;

namespace VectorBase.Pages.MainPage
{
    public class MainPageElementMap : BaseElementMap
    {
        public IWebElement UserTrigger => driver.FindElement(By.Id("global-user-trigger"));
        public IWebElement LogInLink => driver.FindElement(By.XPath("//ul[@class = 'account-management']//a[text() = 'Log In']"));
        public IWebElement SignUpButton => driver.FindElement(By.XPath("//a[text() = 'Sign Up']"));
        public IWebElement FirstNameInput => driver.FindElement(By.XPath("//input[@name = 'firstName']"));
        public IWebElement LastNameInput => driver.FindElement(By.XPath("//input[@name = 'lastName']"));
        public IWebElement EmailAddressInput => driver.FindElement(By.XPath("//input[@name = 'email']"));
        public IWebElement PasswordInput => driver.FindElement(By.XPath("//input[@name = 'newPassword']"));
        public IWebElement SubmitSignUpButton => driver.FindElement(By.XPath("//button[text() = 'Sign Up' and @type = 'submit']"));
        public IWebElement LogOutButton => driver.FindElement(By.XPath("//a[text() = 'Log Out']"));
        public IWebElement LoginEmailInput => driver.FindElement(By.XPath("//input[@type= 'email']"));
        public IWebElement LoginPasswordInput => driver.FindElement(By.XPath("//input[@type= 'password']"));
        public IWebElement LoginButton => driver.FindElement(By.XPath("//button[text() = 'Log In' and @type = 'submit']"));
        public IWebElement SearchButton => driver.FindElement(By.Id("global-search-trigger"));
        public IWebElement SearchBar => driver.FindElement(By.Id("global-search-input"));
        public IWebElement AddFavoritesButton => driver.FindElement(By.XPath("//a[text() = '+Add favorites']"));
        public List<IWebElement> SuggestedSports => driver.FindElements(By.XPath("//li[text() = 'Suggested Sports']/following-sibling::li")).ToList();
        public List<IWebElement> MySports => driver.FindElements(By.XPath("//li[text() = 'My Sports']//following-sibling::li")).ToList();

        public MainPageElementMap(IWebDriver driver) : base(driver)
        {
        }
    }
}