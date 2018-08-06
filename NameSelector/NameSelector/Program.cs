using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class Program
{
    static void Main()
    {
        IWebDriver driver = new ChromeDriver();

        driver.Navigate().GoToUrl("http://testing.todorvachev.com/selectors/name/");

        IWebElement element = driver.FindElement(By.Name("myName"));

        if (element.Displayed)
        {
            System.Console.WriteLine("Yes I can see the element!!");
            //GreenMessage("Yes I can see the element!!");
        }
        else
        {
            System.Console.WriteLine("No I cannot see the element!!");
            //RedMessage("No I cannot see the element!!");
        }

        driver.Quit();
    }

    //    private static void RedMessage(string message)
    //    {
    //        Console.ForegroundColor = ConsoleColor.Red;
    //        Console.WriteLine(message);
    //        Console.ForegroundColor = ConsoleColor.White;
    //    }

    //    private static void GreenMessage(string message)
    //    {
    //        Console.ForegroundColor = ConsoleColor.Green;
    //        Console.WriteLine(message);
    //        Console.ForegroundColor = ConsoleColor.White;
    //    }
}

