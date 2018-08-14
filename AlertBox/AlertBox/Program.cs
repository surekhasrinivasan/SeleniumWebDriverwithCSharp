using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

class Program
{
    static IWebDriver driver = new ChromeDriver();
    static IAlert alert;
    static IWebElement image;

    static void Main()
    {
        string url = "http://testing.todvachev.com/special-elements/alert-box/";

        driver.Navigate().GoToUrl(url);

        alert = driver.SwitchTo().Alert();

        Console.WriteLine(alert.Text);

        alert.Accept();

        image = driver.FindElement(By.CssSelector("#post-119 > div > figure > img"));

        try
        {
            if (image.Displayed)
            {
                Console.WriteLine("The alert was successfully accepted and I can see the image");
            }
        }
        catch (NoSuchElementException)
        {
            Console.WriteLine("Sorry something went wrong!");
        }

        Thread.Sleep(3000);

        driver.Quit();
    }
}