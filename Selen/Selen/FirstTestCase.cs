using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Selen
{
    public class FirstTestCase
    {
        static void Main(string[] args)
        {
            string binaryLocation = "C:\\Users\\opilane\\source\\repos\\FFP\\FirefoxPortable\\App\\Firefox64\\Firefox.exe";

            FirefoxOptions options = new FirefoxOptions();
            options.BrowserExecutableLocation = binaryLocation;

            IWebDriver driver = new FirefoxDriver("C:\\Users\\opilane\\source\\repos\\Selen\\Selen\\drivers", options);
            driver.Url = "https://localhost:7105/";
        }
    }
}
