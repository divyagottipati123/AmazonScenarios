using AmazonScenarios.Configuration;
using AmazonScenarios.DataDriven;
using AmazonScenarios.Settings;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonScenarios.Amazon
{
   public class LogoutAndLoginBack
    {
        AppConfigReader acr = new AppConfigReader();
        public void PlaceCursor()
        {
            Actions actions = new Actions(ObjectRepository.Driver);
            actions.MoveToElement(ObjectRepository.Driver.FindElement(By.XPath(ExcelHelper.GetCellData(acr.GetXlpath(), "Details_new", 0, 1).ToString())))
            .Build()
            .Perform();

        
        }
        public void ClickSignout()
        {
            ObjectRepository.Driver.FindElement(By.XPath(ExcelHelper.GetCellData(acr.GetXlpath(), "Details", 38, 1).ToString())).Click();
        }
       
     
       
    }
}
