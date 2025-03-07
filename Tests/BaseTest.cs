using NUnit.Framework.Internal;
using OpenQA.Selenium.Chrome;


namespace techTask;

[TestFixture]
public class BaseTest
{
    public ChromeDriver driver;

    [SetUp]
    public void Setup()
    {
        var options = new ChromeOptions();
        options.AddArgument("--headless");
        options.AddArgument("--disable-gpu");
        options.AddArgument("--no-sandbox");
        options.AddArgument("--disable-dev-shm-usage");
        driver = new ChromeDriver(options);
        driver.Manage().Window.Maximize();
    }

    [TearDown]
    public void Close()
    {
        driver.Close();
    }
}