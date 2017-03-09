using System.Text.RegularExpressions;

namespace ProMonitoringService_WPFClient
{
    public static class InputValidationHelper
    {
        public readonly static Regex PasswordValidator = new Regex(@".+");
        public readonly static Regex EmailValidator = new Regex(
            @"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?",
            RegexOptions.IgnoreCase); // IgnoreCase option is ON
        public readonly static Regex NameValidator = new Regex(@"[A-za-z0-9]+");
        public readonly static Regex DisplayNameValidator = new Regex(@"[A-za-z0-9\s]+");

        /// <summary>
        /// Expects: '00 (000) 0000000' or 00 000 0000000'. White spaces are not required.
        /// </summary>
        public readonly static Regex PhoneNumberValidator = new Regex(@"(\d{2})\s?(\d{3}|\(\d{3}\))\s?(\d{7})");
    }
}
