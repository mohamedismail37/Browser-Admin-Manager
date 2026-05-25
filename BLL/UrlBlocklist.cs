using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL
{
    public static class UrlBlocklist
    {
        public static bool BlockAllWebsites(clsCore.enBrowser browser)
        {
            return DAL.UrlBlocklist.BlockAllWebsites(browser);
        }

        public static bool UnblockAllWebsites(clsCore.enBrowser browser)
        {
            return DAL.UrlBlocklist.UnblockAllWebsites(browser);
        }

        public static bool BlockSpecificWebsite(clsCore.enBrowser browser,string url)
        {
            return DAL.UrlBlocklist.BlockSpecificWebsite(browser, url);
        }

        public static bool UnblockSpecificWebsite(clsCore.enBrowser browser, string fileName)
        {
            return DAL.UrlBlocklist.UnblockSpecificWebsite(browser, fileName);
        }

        public static List<clsCore.BlockedWebsite> GetBlockedWebsites(clsCore.enBrowser browser)
        {
            return DAL.UrlBlocklist.GetBlockedWebsites(browser);
        }


    }
}
