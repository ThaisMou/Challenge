using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace Session2
{
    [Binding]
    public class AmazonBooksFeatureSteps
    {
        IWebDriver Browser;

        [BeforeScenario]
        public void Init()
        {
            this.Browser = new ChromeDriver();
        }

        public string CheapestBookTitle { get; set; }

        [Given(@"I navigate to ""(.*)""\.")]
        public void GivenINavigateTo_(string site)
        {
            site = "https://www.amazon.com";
            Browser.Navigate().GoToUrl(site);
            Browser.Title.Contains("Amazon");
        }
        
        [When(@"I select the option ""(.*)"" in the dropdown next to the search text input criteria\.")]
        public void WhenISelectTheOptionInTheDropdownNextToTheSearchTextInputCriteria_(string dropDownOption)
        {
            dropDownOption = ("Books");
            SelectElement searchDropdownBox = new SelectElement(Browser.FindElement(By.Id("searchDropdownBox")));
            searchDropdownBox.SelectByText(dropDownOption);
        }
        
        [Then(@"I search for ""(.*)""\.")]
        public void ThenISearchFor_(string searchKeyword)
        {
            searchKeyword = "Test automation";
            IWebElement searchInputBox = Browser.FindElement(By.Id("twotabsearchtextbox"));
            searchInputBox.SendKeys(searchKeyword);
            IWebElement searchButton = Browser.FindElement(By.Id("nav-search-submit-text"));
            searchButton.Click();
        }

        [Then(@"I select the cheapest book of the page without using any sorting method available\.")]
        public void ThenISelectTheCheapestBookOfThePageWithoutUsingAnySortingMethodAvailable_(string CheapestBookTitle)
        {
            IWebElement CheapestBook = Browser.FindElement(By.XPath("*[@id='search']/div[1]/div[2]/div/span[4]/div[1]/div[13]/div/span/div/div/div[2]/div[2]/div/div[1]/div/div/div[1]/h2/a/span"));
            CheapestBookTitle = CheapestBook.Text;
            CheapestBook.Click();
        }

        [When(@"I reach the detailed book page, I check if the name in the header is the same name of the book that I select previously\.")]
        public void WhenIReachTheDetailedBookPageICheckIfTheNameInTheHeaderIsTheSameNameOfTheBookThatISelectPreviously_(string bookTitleString)
        {        
            IWebElement bookTitle = Browser.FindElement(By.Id("ebooksProductTitle"));
            bookTitleString = bookTitle.Text;
            CheapestBookTitle.Equals(bookTitleString);
        }

        [AfterScenario]
        public void Close()
        {
            this.Browser.Close();
            this.Browser.Dispose();

        }
    }
}
