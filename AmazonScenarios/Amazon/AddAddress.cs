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

namespace AmazonScenarios.Amazon
{
   public class AddAddress
    {
        AppConfigReader acr = new AppConfigReader();
        public void ClickYourorders()
        {
           
            ObjectRepository.Driver.FindElement(By.XPath(ExcelHelper.GetCellData(acr.GetXlpath(), "Details_new", 0, 1).ToString())).Click();
        }
        public void clickYourAddress()
        {
            ObjectRepository.Driver.FindElement(By.XPath(ExcelHelper.GetCellData(acr.GetXlpath(), "Details", 9, 1).ToString())).Click();
        }
        public void clickAddAddress()
        {
            ObjectRepository.Driver.FindElement(By.XPath(ExcelHelper.GetCellData(acr.GetXlpath(), "Details", 10, 1).ToString())).Click();
        }
        public void AddAddressDetails()
        {
            ObjectRepository.Driver.FindElement(By.XPath(ExcelHelper.GetCellData(acr.GetXlpath(), "Details", 11, 1).ToString())).SendKeys(ExcelHelper.GetCellData(acr.GetXlpath(), "Details", 26, 1).ToString());
            ObjectRepository.Driver.FindElement(By.XPath(ExcelHelper.GetCellData(acr.GetXlpath(), "Details", 12, 1).ToString())).SendKeys(ExcelHelper.GetCellData(acr.GetXlpath(), "Details", 27, 1).ToString());
            ObjectRepository.Driver.FindElement(By.XPath(ExcelHelper.GetCellData(acr.GetXlpath(), "Details", 13, 1).ToString())).SendKeys(ExcelHelper.GetCellData(acr.GetXlpath(), "Details", 28, 1).ToString());
            ObjectRepository.Driver.FindElement(By.XPath(ExcelHelper.GetCellData(acr.GetXlpath(), "Details", 14, 1).ToString())).SendKeys(ExcelHelper.GetCellData(acr.GetXlpath(), "Details", 29, 1).ToString());
            ObjectRepository.Driver.FindElement(By.XPath(ExcelHelper.GetCellData(acr.GetXlpath(), "Details", 15, 1).ToString())).SendKeys(ExcelHelper.GetCellData(acr.GetXlpath(), "Details", 30, 1).ToString());
            ObjectRepository.Driver.FindElement(By.XPath(ExcelHelper.GetCellData(acr.GetXlpath(), "Details", 16, 1).ToString())).Click();
            ObjectRepository.Driver.FindElement(By.XPath(ExcelHelper.GetCellData(acr.GetXlpath(), "Details", 17, 1).ToString())).Click();
        }
        public void clickAddAddressButton()
        {
            ObjectRepository.Driver.FindElement(By.XPath(ExcelHelper.GetCellData(acr.GetXlpath(), "Details", 18, 1).ToString())).Click();
            ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            ObjectRepository.Driver.FindElement(By.XPath(ExcelHelper.GetCellData(acr.GetXlpath(), "Details", 18, 1).ToString())).Click();


        }
        public void AddAddressResult()
        {
            Assert.IsNotNull(ObjectRepository.Driver.FindElement(By.XPath(ExcelHelper.GetCellData(acr.GetXlpath(), "Details", 19, 1).ToString())));
        }
    }
}
