using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace PainterWebTests
{
    [TestFixture(typeof(ChromeDriver))]
    public class NUnitPainterTest<TWebDriver> where TWebDriver : IWebDriver, new()
    {
        public static IWebDriver Driver { get; set; }
        public WebDriverWait Wait { get; set; }
        public PainterPage PainterPage { get; set; }

        [OneTimeSetUp]
        public void InitDriver()
        {
            Driver = new TWebDriver();
            PainterPage = new PainterPage(Driver);
            PainterPage.Navigate();
        }

        [OneTimeTearDown]
        public static void TearDown()
        {
            Driver.Quit();
        }

        [Test]
        [TestCase("MFile")]
        [TestCase("SimpleFigureBtn")]
        [TestCase("MEdit")]
        [TestCase("MView")]
        [TestCase("MTab")]
        [TestCase("MPages")]
        [TestCase("MPlugins")]
        [TestCase("MSettings")]
        [TestCase("MHelp")]
        [TestCase("TSave")]
        [TestCase("TLoad")]
        [TestCase("TSaveCloud")]
        [TestCase("TLoadCloud")]
        [TestCase("TNew")]
        [TestCase("TDel")]
        [TestCase("TReN")]
        public void MenuAndToolBarDisplayed(string webElement)
        {
            Assert.AreEqual(true, PainterPage[webElement].Displayed);
        }
    }
}
