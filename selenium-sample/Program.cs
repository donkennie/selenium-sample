
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

public class Program
{
    public static void Main(string[] args)
    {
        new DriverManager().SetUpDriver(new ChromeConfig());

        IWebDriver driver = new ChromeDriver();
        driver.Manage().Window.Maximize();

        driver.Navigate().GoToUrl("https://github.com/");

        IWebElement searchBox = driver.FindElement(By.CssSelector(".search-input"));
        searchBox.Click();

        IWebElement searchInput = driver.FindElement(By.CssSelector("#query-builder-test"));
        searchInput.SendKeys("selenium");
        searchInput.SendKeys(Keys.Enter);

        driver.Quit();
    }

}