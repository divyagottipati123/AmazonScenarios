using AmazonScenarios.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonScenarios.Interface
{
    public interface IConfig
    {
        BrowserType GetBrowser();
        String GetWebsite();
        String GetXlpath();
    }
}
