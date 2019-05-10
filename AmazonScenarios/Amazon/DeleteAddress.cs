using AmazonScenarios.Configuration;
using AmazonScenarios.DataDriven;
using AmazonScenarios.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonScenarios.Amazon
{
   public class DeleteAddress
    {
        AppConfigReader acr = new AppConfigReader();
        public void clickDelete()
        {
            ObjectRepository.Driver.FindElement(By.XPath(ExcelHelper.GetCellData(acr.GetXlpath(), "Details", 23, 1).ToString())).Click();
           
        }
        public void Confirmation()
        {
            var currentHandle = ObjectRepository.Driver.CurrentWindowHandle;
            PopupWindowFinder finder = new PopupWindowFinder(ObjectRepository.Driver);
            WebDriverWait customWait = new WebDriverWait(ObjectRepository.Driver, TimeSpan.FromMinutes(2));
            customWait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath(ExcelHelper.GetCellData(acr.GetXlpath(), "Details", 24, 1).ToString())));
            string popupWindowHandle = finder.Click(ObjectRepository.Driver.FindElement(By.XPath(ExcelHelper.GetCellData(acr.GetXlpath(), "Details", 24, 1).ToString())));
            ObjectRepository.Driver.SwitchTo().Window(popupWindowHandle);
            ObjectRepository.Driver.SwitchTo().Window(currentHandle);
            //ObjectRepository.Driver.FindElement(By.XPath(ExcelHelper.GetCellData(acr.GetXlpath(), "Details", 24, 1).ToString())).Click();
        }
        public void DeleteResult()
        {
           
            Assert.IsNotNull(ObjectRepository.Driver.FindElement(By.XPath(ExcelHelper.GetCellData(acr.GetXlpath(), "Details", 25, 1).ToString())));
        }

    }
}
