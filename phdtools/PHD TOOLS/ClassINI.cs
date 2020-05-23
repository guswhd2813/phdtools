using System;
using System.Runtime.InteropServices;
using System.Text;
using System.IO;

namespace PHD_TOOLS
{
    class ClassINI
    {   
        [DllImport("kernel32.dll")]
        private static extern int GetPrivateProfileString(string lpApplicationName, string lpKeyName, string lpDefault,
                                                                StringBuilder lpReturnedString, int nSize, string lpFileName);
        [DllImport("kernel32.dll")]
        private static extern int WritePrivateProfileString(string lpApplicationName, string lpKeyName, string lpString, string lpFileName);

        public string readINI(string strPath, string strSection, string strKey)
        {
            StringBuilder sbReturn = new StringBuilder(255);
            int nWorked = 0;

            try
            {
                if (strKey == String.Empty) return String.Empty;

                nWorked = GetPrivateProfileString(strSection, strKey, String.Empty, sbReturn, 255, strPath);
                if (nWorked == 0)
                {
                    return String.Empty;
                }
                else
                {
                    return deleteSpace(sbReturn.ToString()).Trim();
                }
            }
            catch 
            { 
                return String.Empty; 
            }
        }

        public string readINI(string strPath, string strSection, string strKey, string strDefaultValue)
        {
            StringBuilder sbReturn = new StringBuilder(256);
            int nWorked;

            try
            {
                if (strKey == String.Empty) return strDefaultValue;

                nWorked = GetPrivateProfileString(strSection, strKey, strDefaultValue, sbReturn, 255, strPath);
                if (nWorked == 0)
                {
                    return strDefaultValue;
                }
                else
                {
                    return deleteSpace(sbReturn.ToString()).Trim();
                }
            }
            catch
            {
                return strDefaultValue;
            }
        }

        public string readINI(string strPath, string strSection, string strKey, string strDefaultValue, int nLength)
        {
            StringBuilder sbReturn = new StringBuilder(nLength);
            int nWorked;
            try
            {
                if (strKey == String.Empty) return strDefaultValue;

                nWorked = GetPrivateProfileString(strSection, strKey, strDefaultValue, sbReturn, nLength, strPath);
                if (nWorked == 0)
                {
                    return strDefaultValue;
                }
                else
                {
                    return deleteSpace(sbReturn.ToString()).Trim();
                }
            }
            catch
            {
                return String.Empty;
            }
        }

        public bool writeINI(string strPath, string strSection, string strKey, string strValue)
        {
            int nWorked = 0;

            try
            {
                nWorked = WritePrivateProfileString(strSection, strKey, strValue, strPath);
                if (nWorked == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        private static string deleteSpace(string strData)
        {
            string strTemp = String.Empty;

            try
            {
                strTemp = strData.Trim();
                strTemp = strData.Replace("\n", String.Empty);
                strTemp = strData.Replace("\0", String.Empty);
                strTemp = strData.Replace("\t", String.Empty);
                return strTemp.Trim();
            }
            catch
            {
                return strData.Trim();
            }
        }
    }
}
