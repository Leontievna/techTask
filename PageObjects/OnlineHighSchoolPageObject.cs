/*
Represents the MiaPrep Online High School page, includes a check if the page is open and perform actions on this page.
*/
using Allure.NUnit.Attributes;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace techTask;
[TestFixture]
public class OnlineHighSchoolPageObject(ChromeDriver driver) : BasePage(driver)
{
    string miaprepUrl = "https://miaprep.com/online-school/";
    By ApplyToMohoButton = By.XPath("//a[contains(@class, 'wp-block-button__link') and (text())='Apply to Our School']");

    [AllureStep("Apply invitation MiaPrep Online High School")]
    public PerentDataPageObject ApplyToMOHS()
    {
        Assert.That(driver.Url, Is.EqualTo(miaprepUrl));
        driver.FindElement(ApplyToMohoButton).Click();
        return new PerentDataPageObject(driver);
    } 
}

