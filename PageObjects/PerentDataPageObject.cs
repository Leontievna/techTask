/*
Represents the page with parent data form.
*/
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.WaitHelpers;

namespace techTask;

public class PerentDataPageObject(ChromeDriver driver) : BasePage(driver)
{
    public By skipFirstInfo = By.CssSelector("div.inlineBlock.nextAlign  button");
    public By nameFirstInput = By.XPath("//input[@complink=\"Name_First\"]");

    public By nameSecondInput = By.XPath("//input[@complink=\"Name_Last\"]");
    public By emailInput = By.XPath("//input[@id=\"Email-arialabel\"]");
    public By countryCodeList = By.ClassName("selected-flag");
    public By germanyNumber = By.XPath("//*[text()=\"Germany (Deutschland)\"]");
    public By inputFieldNumber = By.CssSelector("input#PhoneNumber");
    public By addAnotherParentDropdown = By.Id("select2-Dropdown-arialabel-container");
    public By noOptionInDropDown = By.XPath("//*[@role=\"treeitem\"][text()='No']");
    public By inputFieldStartDate = By.CssSelector("input#Date-date");
    public By nextPageButton = By.CssSelector("[page_link_name=\"Page\"] button");
    public By backPageButton = By.CssSelector("[page_no=\"2\"] button[elname=\"back\"]");
    string partialUrlApplicationForm = "miaplazahelp/form/MOHSInitialApplication";


    public ChildDataPageObject FillInForms(string firstName, string secondName, string number, string email, string dateStudyStart)
    {
        Assert.That(driver.Url, Does.Contain(partialUrlApplicationForm), $"URL has to contain '{partialUrlApplicationForm}'");
        driver.FindElements(skipFirstInfo).First().Click();
        driver.FindElement(nameFirstInput).SendKeys(firstName);
        driver.FindElement(nameSecondInput).SendKeys(secondName);
        driver.FindElement(countryCodeList).Click();
        driver.FindElement(germanyNumber).Click();
        driver.FindElement(inputFieldNumber).SendKeys(number);
        driver.FindElement(emailInput).SendKeys(email);
        driver.FindElement(inputFieldStartDate).SendKeys(dateStudyStart);
        Actions actions = new Actions(driver);
        IWebElement ddHiddenInput = driver.FindElement(addAnotherParentDropdown);
        wait.Until(ExpectedConditions.ElementToBeClickable(ddHiddenInput));
        actions.MoveToElement(ddHiddenInput).Click().Perform();
        IWebElement ddHiddenOption = driver.FindElement(noOptionInDropDown);
        actions.MoveToElement(ddHiddenOption).Click().Perform();
        //proceed to Student Information page
        driver.FindElement(nextPageButton).Click();
        return new ChildDataPageObject(driver);
    }
} 
