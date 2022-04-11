using System;
using TechTalk.SpecFlow;
using VectorBase.Infrastructure.DriverFactory;
using VectorBase.Pages.MainPage;

namespace VectorTests.Steps
{
    [Binding]
    public class MainPageSteps
    {
        private MainPage page;

        public MainPageSteps()
        {
            this.page = new MainPage(DriverFactory.Driver);
        }

        [Given(@"I navigate to the application page")]
        public void GivenINavigateToTheApplicationPage()
        {
            page.Open();
        }

        [Given(@"I navigate to the Sign Up page")]
        public void GivenINavigateToTheSignUpPage()
        {
            page.GoToLoginFrame()
                .OpenSignUpFrame();
        }

        [Given(@"I use ""([^""]*)"" as Fist Name")]
        public void GivenIUseAsFistName(string text)
        {
            page.SendFirstName(text);
        }

        [Given(@"I use ""([^""]*)"" as Last Name")]
        public void GivenIUseAsLastName(string text)
        {
            page.SendLastName(text);
        }

        [Given(@"I use an aleatory email")]
        public void GivenIUseAnAleatoryEmail()
        {
            var email = $"pietro.braga.{DateTime.Now.Millisecond}@mailinator.com";
            page.SendEmailAdress(email);
        }

        [Given(@"I use a strong password")]
        public void GivenIUseAStrongPassword()
        {
            page.SendPassword("V3cT0RT3sT");
        }

        [Given(@"I navigate to the Login Page")]
        public void GivenINavigateToTheLoginPage()
        {
            page.GoToLoginFrame();
        }

        [Given(@"I use ""([^""]*)"" as login email")]
        public void GivenIUseAsLoginEmail(string email)
        {
            page.SendLoginEmail(email);
        }

        [Given(@"I use ""([^""]*)"" as login password")]
        public void GivenIUseAsLoginPassword(string password)
        {
            page.SendLoginPassword(password);   
        }

        [Given(@"I open My Favorites Panel")]
        public void GivenIOpenMyFavoritesPanel()
        {
            page.GoToMyFavoritesPanel();
        }

        [When(@"I click to follow any Suggested Sport")]
        public void WhenIClickToFollowAnySuggestedSport()
        {
            page.ClickOnASuggestedSport();
        }

        [When(@"I click on Log In Button")]
        public void WhenIClickOnLogInButton()
        {
            page.ClickOnLoginButton();
        }


        [When(@"I submit the Signup Form")]
        public void WhenISubmitTheSignupForm()
        {
            page.SubmitSignUpForm();
        }

        [When(@"I search for ""([^""]*)""")]
        public void WhenISearchFor(string searchTerm)
        {
            page.Search(searchTerm);
        }

        [Then(@"the search page is displayed")]
        public void ThenTheSearchPageIsDisplayed()
        {
            page.Validations.SearchPageIsDisplayed();
        }

        [Then(@"a green check icon should be displayed")]
        public void ThenAGreenCheckIconShouldBeDisplayed()
        {
            page.Validations.GreenCheckIconIsDisplayed();
        }

        [Then(@"a the Welcome Message should contains ""([^""]*)""")]
        public void ThenATheWelcomeMessageShouldContains(string text)
        {
            page.Validations.WelcomeMessageContains(text);
        }

        [Then(@"a Log Out button exists")]
        public void ThenALogOutButtonExists()
        {
            page.Validations.LogOutButtonExists();
        }

        [Then(@"My Sports List is not empty and should contails a Unfollow button")]
        public void ThenMySportsListIsNotEmpty()
        {
            page.Validations.MySportsListIsNotEmpty();
        }

    }
}