using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using System.Data;
using System.Diagnostics;

namespace DAL
{
    static public class UrlBlocklist
    { 
        public static bool BlockAllWebsites(clsCore.enBrowser browser)
        {
            string valueName = "1";
            string valueData = "*";
            string keyPath;

            switch (browser)
            {
                case clsCore.enBrowser.Chrome:

                    keyPath = @"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome\URLBlocklist";
                    try
                    {
                        // Write the value to the Registry
                        Registry.SetValue(keyPath, valueName, valueData, RegistryValueKind.String);
                        return true;
                    }
                    catch (Exception ex)
                    {
                        clsCore.WriteExceptionInLogger(ex);
                        return false;
                    }

                case clsCore.enBrowser.Edge:
                    keyPath = @"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge\URLBlocklist";
                    try
                    {
                        // Write the value to the Registry
                        Registry.SetValue(keyPath, valueName, valueData, RegistryValueKind.String);
                        return true;
                    }
                    catch (Exception ex)
                    {
                        clsCore.WriteExceptionInLogger(ex);
                        return false;
                    }
                default:
                    return false;
            }    
        }
        public static bool UnblockAllWebsites(clsCore.enBrowser browser)
        {
            string keyPath = "";
            string valueName = "1";

            switch (browser)
            {
                case clsCore.enBrowser.Chrome:
                    keyPath =
                        @"SOFTWARE\Policies\Google\Chrome\URLBlocklist";
                    break;

                case clsCore.enBrowser.Edge:
                    keyPath =
                        @"SOFTWARE\Policies\Microsoft\Edge\URLBlocklist";
                    break;

                default:
                    return false;
            }

            try
            {
                using (RegistryKey baseKey =
                    RegistryKey.OpenBaseKey(
                        RegistryHive.LocalMachine,
                        RegistryView.Registry64))
                {
                    using (RegistryKey key =
                        baseKey.OpenSubKey(keyPath, true))
                    {
                        if (key == null)
                            return false;

                        key.DeleteValue(valueName, false);

                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                clsCore.WriteExceptionInLogger(ex);
                return false;
            }
        }
        public static bool BlockSpecificWebsite(clsCore.enBrowser browser,string url)
        {
            string valueName = LastNumberIndexKey(browser).ToString();
            string valueData = url;
            string keyPath;

            switch (browser)
            {
                case clsCore.enBrowser.Chrome:

                    keyPath = @"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome\URLBlocklist";
                    try
                    {
                        // Write the value to the Registry
                        Registry.SetValue(keyPath, valueName, valueData, RegistryValueKind.String);
                        return true;
                    }
                    catch (Exception ex)
                    {
                        clsCore.WriteExceptionInLogger(ex);
                        return false;
                    }

                case clsCore.enBrowser.Edge:
                    keyPath = @"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge\URLBlocklist";
                    try
                    {
                        // Write the value to the Registry
                        Registry.SetValue(keyPath, valueName, valueData, RegistryValueKind.String);
                        return true;
                    }
                    catch (Exception ex)
                    {
                        clsCore.WriteExceptionInLogger(ex);
                        return false;
                    }
                default:
                    return false;
            }
        }
        public static bool UnblockSpecificWebsite(clsCore.enBrowser browser, string fileName)
        {
            string keyPath = "";

            switch (browser)
            {
                case clsCore.enBrowser.Chrome:
                    keyPath = @"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome\URLBlocklist";
                    try
                    {
                        // Open the registry key in read/write mode with explicit registry view
                        using (RegistryKey baseKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
                        {
                            using (RegistryKey key = baseKey.OpenSubKey(keyPath, true))
                            {
                                if (key != null)
                                {
                                    // Delete the specified value
                                    key.DeleteValue(fileName);
                                    return true;
                                }
                                else
                                {
                                    return false;
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        clsCore.WriteExceptionInLogger(ex);
                        return false;
                    }

                case clsCore.enBrowser.Edge:
                    keyPath = @"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge\URLBlocklist";
                    try
                    {
                        // Open the registry key in read/write mode with explicit registry view
                        using (RegistryKey baseKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
                        {
                            using (RegistryKey key = baseKey.OpenSubKey(keyPath, true))
                            {
                                if (key != null)
                                {
                                    // Delete the specified value
                                    key.DeleteValue(fileName);
                                    return true;
                                }
                                else
                                {
                                    return false;
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        clsCore.WriteExceptionInLogger(ex);
                        return false;
                    }
                default:
                    return false;

            }
        }
        public static List<clsCore.BlockedWebsite> GetBlockedWebsites(clsCore.enBrowser browser)
        {
            string path = "";
            RegistryKey key;

            List<clsCore.BlockedWebsite> websites = new List<clsCore.BlockedWebsite>();

            switch (browser)
            {
                case clsCore.enBrowser.Chrome:
                    path = @"SOFTWARE\Policies\Google\Chrome\URLBlocklist";

                    key = Registry.LocalMachine.OpenSubKey(path);

                    if (key == null)
                        return websites;

                    foreach (string valueName in key.GetValueNames())
                    {
                        websites.Add(new clsCore.BlockedWebsite
                        {
                            ID = valueName,
                            Website = key.GetValue(valueName)?.ToString()
                        });
                    }

                    key.Close();
                    break;

                case clsCore.enBrowser.Edge:
                    path = @"SOFTWARE\Policies\Microsoft\Edge\URLBlocklist";

                    key = Registry.LocalMachine.OpenSubKey(path);

                    if (key == null)
                        return websites;

                    foreach (string valueName in key.GetValueNames())
                    {
                        websites.Add(new clsCore.BlockedWebsite
                        {
                            ID = valueName,
                            Website = key.GetValue(valueName)?.ToString()
                        });
                    }

                    key.Close();
                    break;

            }

            return websites;
        }
        public static int LastNumberIndexKey(clsCore.enBrowser browser,  int lastNumberIndex = 1)
        {
            string keyPath = "";

            switch (browser)
            {
                case clsCore.enBrowser.Chrome:
                    keyPath =
                        @"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Google\Chrome\URLBlocklist";
                    break;

                case clsCore.enBrowser.Edge:
                    keyPath =
                        @"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge\URLBlocklist";
                    break;
            }

            try
            {
                string valueName = lastNumberIndex.ToString();

                string value =Registry.GetValue(keyPath, valueName, null) as string;

                if (value != null)
                {
                    return LastNumberIndexKey(browser,lastNumberIndex + 1);
                }
                else
                {
                    return lastNumberIndex;
                }
            }
            catch (Exception ex)
            {
                clsCore.WriteExceptionInLogger(ex);
                return lastNumberIndex;
            }
        }

    }
}
