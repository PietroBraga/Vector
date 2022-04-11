using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorBase.Infrastructure.Base;
using VectorBase.Infrastructure.TestRunContext;
using VectorBase.Utils;

namespace VectorBase.Pages.MainPage
{
    public class MainPage : BasePage<MainPageElementMap, MainPageValidations>
    {
        private MainPageValidations validations;
        public MainPageValidations Validations => validations ??= new MainPageValidations(driver, map);

        public MainPage(IWebDriver driver) : base(driver, new MainPageElementMap(driver))
        {
            this.Url = Context.TestContext.Properties["applicationUrl"].ToString();
        }

        public MainPage GoToLoginFrame()
        {
            var actions = new Actions(driver);
            actions.MoveToElement(map.UserTrigger)
                .Build()
                .Perform();

            map.LogInLink.Click();
            driver.SwitchTo().Frame("disneyid-iframe");

            return this;
        }

        public MainPage OpenSignUpFrame()
        {
            map.SignUpButton.Click();

            return this;
        }

        public void SendFirstName(string text)
        {
            wait.Until(d => map.FirstNameInput.Displayed && map.FirstNameInput.Enabled);
            map.FirstNameInput.SendText(text);
        }

        public void SendLastName(string text)
        {
            map.LastNameInput.SendText(text); 
        }

        public void SendEmailAdress(string email)
        {
            map.EmailAddressInput.SendText(email);
        }

        public void SendPassword(string text)
        {
            map.PasswordInput.SendText(text);
        }

        public void SendLoginEmail(string email)
        {
            map.LoginEmailInput.SendText(email);
        }

        public void SendLoginPassword(string password)
        {
            map.LoginPasswordInput.SendText(password); 
        }

        public void SubmitSignUpForm()
        {
            Thread.Sleep(1500);
            map.SubmitSignUpButton.Submit();
        }

        public void GoToMyFavoritesPanel()
        {
            var actions = new Actions(driver);
            actions.MoveToElement(map.UserTrigger)
                .Build()
                .Perform();

            map.AddFavoritesButton.Click();
        }

        public void ClickOnASuggestedSport()
        {
            driver.SwitchTo().Frame("favorites-manager-iframe");
            var suggestedSoport = map.SuggestedSports.FirstOrDefault();
            if (suggestedSoport != null)
            {
                suggestedSoport.FindElement(By.XPath(".//button")).Click();
            }
        }

        public void ClickOnLoginButton()
        {
            map.LoginButton.Click();
        }

        public void Search(string searchTerm)
        {
            map.SearchButton.Click();
            map.SearchBar.SendText(searchTerm);
            map.SearchBar.SendKeys(Keys.Enter);
        }
    }
}
 