/*
Represents the page with student data form and checks of expected page.
*/
using Allure.NUnit.Attributes;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace techTask;
public class ChildDataPageObject(ChromeDriver driver) : BasePage(driver)
{ 
    public By backPageButton = By.CssSelector("[page_no=\"2\"] button[elname=\"back\"]");
    public By studentInfo = By.CssSelector("#Section2-li h2");

   [Test]
   [AllureStep("Check page with student data form and checks of expected page")]
    public void CheckChildFormPageIsOpen()
    {
        IWebElement infoAboutStudent = driver.FindElement(studentInfo);
        Assert.That(infoAboutStudent.Text, Does.Contain("Student")); 
        Assert.That(driver.FindElement(backPageButton).Enabled, "You are not at the page with a child form");
    }
}
