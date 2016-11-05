using System;
using System.Text;

namespace App_XamarinCrossPlatformNative
{
    public class TranslatePhone
    {
        public TranslatePhone()
        {
                    
        }
        public static string ToNumberOrTranslate(string _strCode)
        {
            if (string.IsNullOrWhiteSpace(_strCode))
            {
                return null;
            }
            _strCode = _strCode.ToLower();
            StringBuilder strBTemp = new StringBuilder();
            strBTemp.Clear();
            foreach (var ch in _strCode)
            {
                if (-1!=" -1234567980".LastIndexOf(ch))
                {
                    strBTemp.Append(ch);
                }
                else
                {
                    var chTemp=ch;
                    if (-1!="abc".IndexOf(ch))
                    {
                        strBTemp.Append(1);
                    }
                    else
                    if (-1 != "def".IndexOf(ch))
                    {
                        strBTemp.Append(2);
                    }
                    else
                    if (-1 != "ghi".IndexOf(ch))
                    {
                        strBTemp.Append(3);
                    }
                    else
                    if (-1 != "jkl".IndexOf(ch))
                    {
                        strBTemp.Append(4);
                    }
                    else
                    if (-1 != "mno".IndexOf(ch))
                    {
                        strBTemp.Append(5);
                    }
                    else
                    if (-1 != "pqr".IndexOf(ch))
                    {
                        strBTemp.Append(6);
                    }
                    else
                    if (-1 != "stu".IndexOf(ch))
                    {
                        strBTemp.Append(7);
                    }
                    else
                    if (-1 != "vwx".IndexOf(ch))
                    {
                        strBTemp.Append(8);
                    }
                    else
                    if (-1 != "yz".IndexOf(ch))
                    {
                        strBTemp.Append(9);
                    }
                }
            }
            return strBTemp.ToString();
        }
    }
}

