using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

class Program
{
    static IWebDriver driver = new ChromeDriver();
    static IWebElement checkBox;

    static void Main()
    {
        string url = "http://testing.todvachev.com/special-elements/check-button-test-3/";
        string option = "1";

        driver.Navigate().GoToUrl(url);

        checkBox = driver.FindElement(By.CssSelector("#post-33 > div > p:nth-child(8) > input[type=\"checkbox\"]:nth-child(" + option + ")"));

        //if(checkBox.GetAttribute("checked") == "true")
        //{
        //    Console.WriteLine("The checkbox is checked!");
        //}
        //else
        //{
        //    Console.WriteLine("The checkbox is NOT checked!");
        //}            

        Console.WriteLine(checkBox.GetAttribute("value"));//to get value of checkbox

        checkBox.Click();

        Thread.Sleep(5000);

        //option = "3";

        //checkBox = driver.FindElement(By.CssSelector("#post-33 > div > p:nth-child(8) > input[type=\"checkbox\"]:nth-child(" + option + ")"));

        //Console.WriteLine(checkBox.GetAttribute("value"));

        driver.Quit();
    }
}