using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Model
{
    public static class Extensions
    {
        public static string TrimAndReplace(this string stringValue, string value, string valueToReplace)
        {
            string retString = string.Empty;

            if (!string.IsNullOrEmpty(stringValue))
                retString = stringValue.Replace(value, valueToReplace).Trim();


            return retString;
        }
    }
}
