using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler.BusinessLogicLibrary.Common
{
    /// <summary>
    ///  Helper class that may be used for several purposes from several sources
    /// </summary>
    public class Helper
    {
        /// <summary>
        /// Get registry key value
        /// </summary>
        /// <param name="sFolderPath">Folder path</param>
        /// <param name="sKeyName">Key name</param>
        /// <returns></returns>
        public static string GetRegistryKeyValue(string sFolderPath, string sKeyName)
        {
            string sValue = string.Empty;
            using (var hkeyLocalMachine = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
            using (var key = hkeyLocalMachine.OpenSubKey(sFolderPath))
            {
                if (key != null)
                {
                    sValue = key.GetValue(sKeyName).ToString();
                    key.Close();
                }
            }

            return sValue;
        }



    }
}
