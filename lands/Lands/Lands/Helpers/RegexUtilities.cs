namespace Lands.Helpers
{
    using System;
    using System.Text.RegularExpressions;

    public class RegexUtilities
    {
        public static bool IsValidEmail(string email)
        {
            var expresion = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
