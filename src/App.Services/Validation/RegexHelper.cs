using System;
using System.Text.RegularExpressions;

namespace App.Services.Validation
{
    public static class RegexHelper
    {
        private const string EMAIL_REGEX = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
        public static bool IsEmail(string text)
        {
            return Regex.IsMatch(text, EMAIL_REGEX);
        }
    }
}
