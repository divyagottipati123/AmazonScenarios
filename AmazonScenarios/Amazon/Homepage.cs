using AmazonScenarios.ComponentHelper;
using AmazonScenarios.Configuration;
using AmazonScenarios.DataDriven;
using AmazonScenarios.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonScenarios
{
    
  public class Homepage
    {
        #region Actions
        AppConfigReader acr = new AppConfigReader();
        public void IamAtHomePage()
        {
            NavigationHelper.NavigateToUrl(ExcelHelper.GetCellData(acr.GetXlpath(), "Details", 0, 1).ToString());
            ObjectRepository.Driver.Manage().Window.Maximize();
            ObjectRepository.Driver.Manage().Timeouts().ImplicitWait= TimeSpan.FromSeconds(10);
        }
        public void SignIn()
        {
            ObjectRepository.Driver.FindElement(By.XPath(ExcelHelper.GetCellData(acr.GetXlpath(), "Details", 1, 1).ToString())).Click();
        }
      public void EnterMobileNumber()
        {
            ObjectRepository.Driver.FindElement(By.XPath(ExcelHelper.GetCellData(acr.GetXlpath(), "Details", 2, 1).ToString())).SendKeys(ExcelHelper.GetCellData(acr.GetXlpath(), "Details", 6, 1).ToString());
        }
        public void Continue()
        {
            ObjectRepository.Driver.FindElement(By.XPath(ExcelHelper.GetCellData(acr.GetXlpath(), "Details", 3, 1).ToString())).Click();
        }
        public void EnterPassword()
        {
            ObjectRepository.Driver.FindElement(By.XPath(ExcelHelper.GetCellData(acr.GetXlpath(), "Details", 4, 1).ToString())).SendKeys(ExcelHelper.GetCellData(acr.GetXlpath(), "Details", 7, 1).ToString());
        }
        public void Login()
        {
            ObjectRepository.Driver.FindElement(By.XPath(ExcelHelper.GetCellData(acr.GetXlpath(), "Details", 5, 1).ToString())).Click();
        }
      
        public void Result()
        {
            Assert.IsNotNull(ObjectRepository.Driver.FindElement(By.XPath("/html")));
        }
       
#endregion

    }
}
