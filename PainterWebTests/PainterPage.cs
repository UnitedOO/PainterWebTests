using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace PainterWebTests
{
    public class PainterPage
    {
        private readonly IWebDriver driver;
        private readonly string url = @"file:///D:/ORT/ORT_all/PainterWEB/3/PainterWeb/index.html";

        public IWebElement this[string propertyName] => (IWebElement)this.GetType().GetProperty(propertyName).GetValue(this, null);

        public PainterPage(IWebDriver browser)
        {
            this.driver = browser;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//button[contains(@class, 'pluginBtn') and text()='Simple figure']")]
        public IWebElement SimpleFigureBtn { get; set; }

        [FindsBy(How = How.Id, Using = "mFile")]
        public IWebElement MFile { get; set; }

        [FindsBy(How = How.Id, Using = "mSave")]
        public IWebElement MSave { get; set; }

        [FindsBy(How = How.Id, Using = "mOpen")]
        public IWebElement MOpen { get; set; }

        [FindsBy(How = How.Id, Using = "mEdit")]
        public IWebElement MEdit { get; set; }

        [FindsBy(How = How.Id, Using = "mView")]
        public IWebElement MView { get; set; }

        [FindsBy(How = How.Id, Using = "mTab")]
        public IWebElement MTab { get; set; }

        [FindsBy(How = How.Id, Using = "mPages")]
        public IWebElement MPages { get; set; }

        [FindsBy(How = How.Id, Using = "mPlugins")]
        public IWebElement MPlugins { get; set; }

        [FindsBy(How = How.Id, Using = "mSettings")]
        public IWebElement MSettings { get; set; }

        [FindsBy(How = How.Id, Using = "mHelp")]
        public IWebElement MHelp { get; set; }

        [FindsBy(How = How.Id, Using = "tSave")]
        public IWebElement TSave { get; set; }

        [FindsBy(How = How.Id, Using = "tLoad")]
        public IWebElement TLoad { get; set; }

        [FindsBy(How = How.Id, Using = "tSaveCloud")]
        public IWebElement TSaveCloud { get; set; }

        [FindsBy(How = How.Id, Using = "tLoadCloud")]
        public IWebElement TLoadCloud { get; set; }

        [FindsBy(How = How.Id, Using = "tNew")]
        public IWebElement TNew { get; set; }

        [FindsBy(How = How.Id, Using = "tDel")]
        public IWebElement TDel { get; set; }

        [FindsBy(How = How.Id, Using = "tReN")]
        public IWebElement TReN { get; set; }

        public void Navigate()
        {
            this.driver.Navigate().GoToUrl(this.url);
        }
    }
}
