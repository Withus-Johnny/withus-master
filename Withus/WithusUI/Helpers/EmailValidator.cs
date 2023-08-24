﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WithusUI.Helpers
{
    public static class EmailValidator
    {
        public static string[] _allowedDomains = { "naver.com", "daum.net",
            "gmail.com", "yahoo.com", "hanmail.net", "nate.com" };

        private static string GetDomainPattern()
        {
            return string.Join("|", _allowedDomains.Select(domain => Regex.Escape(domain)));
        }

        public static bool IsValidEmail(string email)
        {
            string domainPattern = GetDomainPattern();
            string emailPattern = $@"^[a-zA-Z0-9._%+-]+@({domainPattern})$";

            return Regex.IsMatch(email, emailPattern);
        }
    }
}
