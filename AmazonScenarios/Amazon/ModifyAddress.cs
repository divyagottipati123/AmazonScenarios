using AmazonScenarios.Configuration;
using AmazonScenarios.DataDriven;
using AmazonScenarios.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonScenarios.Amazon
{
   public class ModifyAddress
    {
        AppConfigReader acr = new AppConfigReader();
        public void clickEdit()
        {
            ObjectRepository.Driver.FindElement(By.XPath(ExcelHelper.GetCellData(acr.GetXlpath(), "Details", 20, 1).ToString())).Click();
        }
        public void modifyAddressDetails()
        {
            Actions actions = new Actions(ObjectRepository.Driver);
            actions.Click(ObjectRepository.Driver.FindElement(By.XPath(ExcelHelper.GetCellData(acr.GetXlpath(), "Details", 11, 1).ToString())))
                .KeyDown(Keys.LeftControl)
                .SendKeys("a")
                .KeyUp(Keys.LeftControl)
                .SendKeys(Keys.Backspace)
                .SendKeys(ExcelHelper.GetCellData(acr.GetXlpath(), "Details", 31, 1).ToString())
                .Build()
                .Perform();

        }
        public void clickSavechages()
        {
            ObjectRepository.Driver.FindElement(By.XPath(ExcelHelper.GetCellData(acr.GetXlpath(), "Details", 21, 1).ToString())).Click();
        }
        public void ModifyResult()
        {
            Assert.IsNotNull(ObjectRepository.Driver.FindElement(By.XPath(ExcelHelper.GetCellData(acr.GetXlpath(), "Details", 22, 1).ToString())));
        }
    }
}
