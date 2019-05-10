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
   public class SearchProduct
    {
        AppConfigReader acr = new AppConfigReader();
        public void searchProduct()
        {
            ObjectRepository.Driver.FindElement(By.XPath(ExcelHelper.GetCellData(acr.GetXlpath(), "Details", 32, 1).ToString())).SendKeys(ExcelHelper.GetCellData(acr.GetXlpath(), "Details", 34, 1).ToString());
        }
        public void clickSearch()
        {
            ObjectRepository.Driver.FindElement(By.XPath(ExcelHelper.GetCellData(acr.GetXlpath(), "Details", 33, 1).ToString())).Click();
        }
        public void ClickOnProduct()
        {

            ObjectRepository.Driver.FindElement(By.XPath(ExcelHelper.GetCellData(acr.GetXlpath(), "Details", 35, 1).ToString())).Click();
        }
       
        public void Addtocart()
        {
            var currentWindow = ObjectRepository.Driver.CurrentWindowHandle;
            foreach (String winHandle in ObjectRepository.Driver.WindowHandles)
            {
                if (winHandle != currentWindow)
                {
                    ObjectRepository.Driver.SwitchTo().Window(winHandle);
                }
            }
            ObjectRepository.Driver.FindElement(By.XPath(ExcelHelper.GetCellData(acr.GetXlpath(), "Details", 39, 1).ToString())).Click();
        }
        public void ProceedToPay()
        {
            ObjectRepository.Driver.FindElement(By.XPath(ExcelHelper.GetCellData(acr.GetXlpath(), "Details", 46, 1).ToString())).Click();
            ObjectRepository.Driver.FindElement(By.XPath(ExcelHelper.GetCellData(acr.GetXlpath(), "Details", 36, 1).ToString())).Click();
        }
        public void PaymentPageResult()
        {
            Assert.IsNotNull(ObjectRepository.Driver.FindElement(By.XPath(ExcelHelper.GetCellData(acr.GetXlpath(), "Details", 37, 1).ToString())));
        }
       public void SearchShoes()
        {
            ObjectRepository.Driver.FindElement(By.XPath(ExcelHelper.GetCellData(acr.GetXlpath(), "Details", 32, 1).ToString())).SendKeys(ExcelHelper.GetCellData(acr.GetXlpath(), "Details", 41, 1).ToString());
        }
        public void selectShoes()
        {
            ObjectRepository.Driver.FindElement(By.XPath(ExcelHelper.GetCellData(acr.GetXlpath(), "Details", 42, 1).ToString())).Click();
        }
        public void Selectsize()
        {

            var currentWindow = ObjectRepository.Driver.CurrentWindowHandle;
            foreach (String winHandle in ObjectRepository.Driver.WindowHandles)
            {
                if (winHandle != currentWindow)
                {
                    ObjectRepository.Driver.SwitchTo().Window(winHandle);
                }
            }
            ObjectRepository.Driver.FindElement(By.XPath(ExcelHelper.GetCellData(acr.GetXlpath(), "Details", 43, 1).ToString())).Click();
        }
        public void ClickBuynow()
        {
            ObjectRepository.Driver.FindElement(By.XPath(ExcelHelper.GetCellData(acr.GetXlpath(), "Details", 44, 1).ToString())).Click();
        }
        public void NavigatetoPaymentResult()
        {
            Assert.IsNotNull(ObjectRepository.Driver.FindElement(By.XPath(ExcelHelper.GetCellData(acr.GetXlpath(), "Details", 45, 1).ToString())));
        }
    }
}
