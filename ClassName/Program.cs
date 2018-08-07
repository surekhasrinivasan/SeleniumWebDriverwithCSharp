using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

class Program
{
    static void Main()
    {
        string url = "http://testing.todorvachev.com/selectors/class-name/";
        string className = "testClass";

        IWebDriver driver = new ChromeDriver();

        driver.Navigate().GoToUrl(url);

        IWebElement element = driver.FindElement(By.ClassName(className));

        if (element.Displayed)
        {
            GreenMessage("Yes, I can see the element");
        }
        else
        {
            RedMessage("No, I cannot see the element");
        }

        Console.WriteLine(element.Text);

        driver.Quit();
    }

    private static void GreenMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }

    private static void RedMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }
}

