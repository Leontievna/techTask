/*
Represents the home page, includes methods to open the page and navigate to other pages.
*/
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Allure.NUnit.Attributes;
using SeleniumExtras.WaitHelpers;

namespace techTask;

public class HomePageObject(ChromeDriver driver) : BasePage(driver)
{
    string mainUrl = "https://miacademy.co/#/";
    private By LinkMiaPrepHighSchool = By.XPath("//*[@class=\"mia-announcementText\"]//a");

    [AllureStep("Navigate to MiaPrep Online High School through the link on banner")]    
    public OnlineHighSchoolPageObject OpenHomePage()
    {
        driver.Navigate().GoToUrl(mainUrl);
        //navigate to MiaPrep Online High School through the link on banner
        wait.Until(ExpectedConditions.ElementToBeClickable(LinkMiaPrepHighSchool)).Click();
        return new OnlineHighSchoolPageObject(driver);
    }
}
