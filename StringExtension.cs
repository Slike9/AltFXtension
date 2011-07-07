using System;
using System.Globalization;
using System.Text;

namespace Ekra14.AltFXtension
{
    public static class StringExtension
    {
        public static string ToFormat(this string format, params object[] args)
        {
            return format != null ? string.Format(format, args) : null;
        }

        public static string ToFormat(this string format, CultureInfo cultureInfo, params object[] args)
        {
            return format != null ? string.Format(cultureInfo, format, args) : null;
        }
        
        public static string ToInvariantFormat(this string format, params object[] args)
        {
            return format.ToFormat(CultureInfo.InvariantCulture, args);
        }
        
        public static bool IsEmpty(this string str)
        {
            return string.IsNullOrEmpty(str);
        }

        public static bool IsNotEmpty(this string str)
        {
            return !string.IsNullOrEmpty(str);
        }
        
        public static byte[] GetBytes(this string str)
        {
            return GetBytes(str, Encoding.Default);
        }

        public static byte[] GetBytes(this string str, Encoding encoding)
        {
            if (str == null) throw new ArgumentNullException("str");
            if (encoding == null) throw new ArgumentNullException("encoding");

            return encoding.GetBytes(str);
        }
    }
}