using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

class Program
{
    static IWebDriver driver = new ChromeDriver();
    static IWebElement textBox;

    static void Main()
    {
        string url = "http://testing.todvachev.com/special-elements/text-input-field/";

        driver.Navigate().GoToUrl(url);

        textBox = driver.FindElement(By.Name("username"));

        textBox.SendKeys("Test text");

        Thread.Sleep(3000);

        //textBox.Clear(); //clears the input text in the text box

        Console.WriteLine(textBox.GetAttribute("value"));
        Console.WriteLine(textBox.GetAttribute("maxlength")); //gives the maximum number of characters the text box can take
        
        Thread.Sleep(3000);

        driver.Quit();
    }
}