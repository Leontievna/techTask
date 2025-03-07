/*
Base class initializes the WebDriver and handles element waiting.
*/
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;

namespace techTask;
public class BasePage
{
    protected ChromeDriver driver;
    protected WebDriverWait wait;


    public BasePage(ChromeDriver driver)
    {
        this.driver = driver;
        wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
    }
}

