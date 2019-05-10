﻿using AmazonScenarios.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonScenarios.ComponentHelper
{
   public class NavigationHelper
    {
        public static void NavigateToUrl(String url)
        {
            ObjectRepository.Driver.Navigate().GoToUrl(url);

        }
    }
}
