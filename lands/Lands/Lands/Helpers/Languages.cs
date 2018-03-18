namespace Lands.Helpers
{
    using Xamarin.Forms;
    using Interfaces;
    using Resources;

    public static class Languages
    {
        static Languages()
        {
            var ci = DependencyService.Get<ILocalize>().GetCurrentCultureInfo();
            Resource.Culture = ci;
            DependencyService.Get<ILocalize>().SetLocale(ci);
        }

        public static string Accept
        {
            get { return Resource.Accept; }
        }

        public static string EmailValidation
        {
            get { return Resource.EmailValidation; }
        }

        public static string Error
        {
            get { return Resource.Error; }
        }

        public static string EmailPlaceholder
        {
            get { return Resource.EmailPlaceholder; }
        }

        public static string PasswordLabel
        {
            get { return Resource.PasswordLabel; }
        }

        public static string PasswordPlaceholder
        {
            get { return Resource.PasswordPlaceholder; }
        }

        public static string PasswordValidation
        {
            get { return Resource.PasswordValidation; }
        }

        public static string ForgotPassword
        {
            get { return Resource.ForgotPassword; }
        }

        public static string LoginButton
        {
            get { return Resource.LoginButton; }
        }

        public static string RegisterButton
        {
            get { return Resource.RegisterButton; }
        }

        public static string RememberMe
        {
            get { return Resource.RememberMe; }
        }

        public static string TokenValidation
        {
            get { return Resource.TokenValidation; }
        }

        public static string ConnectionValidation
        {
            get { return Resource.ConnectionValidation; }
        }

        public static string InternetValidation
        {
            get { return Resource.InternetValidation; }
        }
    }
}
