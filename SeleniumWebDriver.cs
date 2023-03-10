using OpenQA.Selenium.Chrome;

namespace SeleniumWebDriverDemo
{
    public class SeleniumWebDriver
    {
        static void Main()
        {
            // create browser instance
            var driver = new ChromeDriver();

            //navigate to Wikipedia
            driver.Url = "https://www.wikipedia.org/";

            // Get browser title
            var pageTitle = driver.Title;

            Console.WriteLine("The page title is " + pageTitle);

            if(pageTitle == "Wikipedia")
            {
                Console.WriteLine("TEST PASS");
            }
            else
            {
                Console.WriteLine("TEST FAIL");
            }

            // close browser 
            driver.Quit();
        }
    }
}