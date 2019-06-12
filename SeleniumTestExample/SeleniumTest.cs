using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Tests
{
    public class SeleniumExamples
    {
        [Test]
        public void OpenBrowserNavigateWaitClick()
        {
            //Create a new instance of Chrome
            IWebDriver driver = new ChromeDriver();
            //Navigate to the test URL
            driver.Navigate().GoToUrl("https://automationintesting.online");

            //Wait for the popup overlay to appear on the screen
            WebDriverWait waitForPopup = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            waitForPopup.Until(d => d.FindElement(By.CssSelector(".popup-content")).Displayed);

            //Find the next button and click it
            driver.FindElement(By.Id("next")).Click();

            driver.Quit();
        }
    }
}