using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using Microsoft.Extensions.Configuration;
using SpecFlow.Tools.MsBuild.Generation;

namespace Session2
{
[Binding]
public class AmazonBooksFeatureSteps :IDisposable
{
    var cheapestBook = chromeDriver.FindElementByXPath("*[@id='search']/div[1]/div[2]/div/span[4]/div[1]/div[13]/div/span/div/div/div[2]/div[2]/div/div[1]/div/div/div[1]/h2/a/span");
        
    private ChromeDriver chromeDriver;
    public AmazonBooksFeatureSteps() => chromeDriver = new ChromeDriver();

    [When(@"I select the option “Books” in the dropdown next to the search text input criteria.")]
    public void WhenISelectTheOptionBooksInTheDropDownNextToTheSearchTextInputCriteria()
    {
        var searchDropdownBox = chromeDriver.FindElementById("searchDropdownBox");
        searchDropdownBox.Select("Books");
    }

    [Given(@"I navigate to “www.amazon.com”.")]
    public void GivenINavigateToWwwAmazonCom()
    {
        chromeDriver.Navigate().GoToUrl("https://www.amazon.com");
        Assert.IsTrue(chromeDriver.Title.ToLower().Contains("Amazon"));
    }

    [Then(@"I search for “Test automation”.")]
    public void ThenISearchForTestAutomation()
    {
     var searchInputBox = chromeDriver.FindElementById("twotabsearchtextbox");
     searchInputBox.SendKeys("Test automation");
     var searchButton = chromeDriver.FindElementById("nav-search-submit-text");
     searchButton.Click();     
    }

    [Then(@"I select the cheapest book of the page without using any sorting method available.")]
    public void ThenISelectTheCheapestBookOfThePageWithoutUsingAnySortingMethodAvailable()
    {
        var wait = new WebDriverWait(chromeDriver, TimeSpan.FromSecond(5));
        wait.Until(ExpectedConditions.ElementIsVisible(cheapestBook));
        cheapestBook.GetText();
        cheapestBook.Click();
    }

    [ When(@"I reach the detailed book page, I check if the name in the header is the same name of the book that I select previously.")]
    public void  WhenIReachTheDetailedBookPageICheckIfTheNameInTheHeaderIsTheSameNameOfTheBookThatISelectPreviously()
    {
        var bookTitle = chromeDriver.FindElementById("ebooksProductTitle");
        bookTitle.GetText();
        Assert.Equal(expected.cheapestBook, actual.bookTitle);
    }

 }
}