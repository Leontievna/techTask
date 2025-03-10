/*
Represents the MiaPrep Online High School page, includes a check if the page is open and perform actions on this page.
*/
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Allure.NUnit.Attributes;

namespace techTask;

public class OnlineHighSchoolPageObject(ChromeDriver driver) : BasePage(driver)
{
    string miaprepUrl = "https://miaprep.com/online-school/";
    By ApplyToMohoButton = By.XPath("//a[contains(@class, 'wp-block-button__link') and (text())='Apply to Our School']");

    [AllureFeature("Apply invitation MiaPrep Online High School")]
    public PerentDataPageObject ApplyToMOHS()
    {
        Assert.That(driver.Url, Is.EqualTo(miaprepUrl));
        driver.FindElement(ApplyToMohoButton).Click();
        return new PerentDataPageObject(driver);
    } 
}

