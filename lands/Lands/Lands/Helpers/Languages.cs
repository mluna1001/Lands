﻿namespace Lands.Helpers
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

        public static string Search
        {
            get { return Resource.Search; }
        }

        public static string Information
        {
            get { return Resource.Information; }
        }

        public static string Currencies
        {
            get { return Resource.Currencies; }
        }

        public static string Borders
        {
            get { return Resource.Borders; }
        }

        public static string Translations
        {
            get { return Resource.Translations; }
        }

        public static string LanguagesTitle
        {
            get { return Resource.LanguagesTitle; }
        }

        public static string Capital
        {
            get { return Resource.Capital; }
        }

        public static string Population { get { return Resource.Population; } }
        public static string Area { get { return Resource.Area; } }
        public static string AlphaCode2 { get { return Resource.AlphaCode2; } }
        public static string AlphaCode3 { get { return Resource.AlphaCode3; } }
        public static string Region { get { return Resource.Region; } }
        public static string Subregion { get { return Resource.Subregion; } }
        public static string Denomination { get { return Resource.Denomination; } }
        public static string GINI { get { return Resource.GINI; } }
        public static string NativeName { get { return Resource.NativeName; } }
        public static string NumericCode { get { return Resource.NumericCode; } }
        public static string CIOC { get { return Resource.CIOC; } }

        public static string German { get { return Resource.German; } }
        public static string Spanish { get { return Resource.Spanish; } }
        public static string French { get { return Resource.French; } }
        public static string Japanese { get { return Resource.Japanese; } }
        public static string Italian { get { return Resource.Italian; } }
        public static string Brazilian { get { return Resource.Brazilian; } }
        public static string Portuguese { get { return Resource.Portuguese; } }
        public static string Dutch { get { return Resource.Dutch; } }
        public static string Croatian { get { return Resource.Croatian; } }
        public static string Persian { get { return Resource.Persian; } }

        public static string Menu { get { return Resource.Menu; } }

        public static string MyProfile { get { return Resource.MyProfile; } }
        public static string Statics { get { return Resource.Statics; } }
        public static string Logout { get { return Resource.Logout; } }

        public static string RegisterTitle
        {
            get { return Resource.RegisterTitle; }
        }

        public static string ChangeImage
        {
            get { return Resource.ChangeImage; }
        }

        public static string FirstNameLabel
        {
            get { return Resource.FirstNameLabel; }
        }

        public static string FirstNamePlaceHolder
        {
            get { return Resource.FirstNamePlaceHolder; }
        }

        public static string FirstNameValidation
        {
            get { return Resource.FirstNameValidation; }
        }

        public static string LastNameLabel
        {
            get { return Resource.LastNameLabel; }
        }

        public static string LastNamePlaceHolder
        {
            get { return Resource.LastNamePlaceHolder; }
        }

        public static string LastNameValidation
        {
            get { return Resource.LastNameValidation; }
        }

        public static string PhoneLabel
        {
            get { return Resource.PhoneLabel; }
        }

        public static string PhonePlaceHolder
        {
            get { return Resource.PhonePlaceHolder; }
        }

        public static string PhoneValidation
        {
            get { return Resource.PhoneValidation; }
        }

        public static string ConfirmLabel
        {
            get { return Resource.ConfirmLabel; }
        }

        public static string ConfirmPlaceHolder
        {
            get { return Resource.ConfirmPlaceHolder; }
        }

        public static string ConfirmValidation
        {
            get { return Resource.ConfirmValidation; }
        }

        public static string EmailValidation2
        {
            get { return Resource.EmailValidation2; }
        }

        public static string PasswordValidation2
        {
            get { return Resource.PasswordValidation2; }
        }

        public static string ConfirmValidation2
        {
            get { return Resource.ConfirmValidation2; }
        }

        public static string UserRegisteredMessage
        {
            get { return Resource.UserRegisteredMessage; }
        }

        public static string SourceImageQuestion
        {
            get { return Resource.SourceImageQuestion; }
        }

        public static string Cancel
        {
            get { return Resource.Cancel; }
        }

        public static string FromGallery
        {
            get { return Resource.FromGallery; }
        }

        public static string FromCamera
        {
            get { return Resource.FromCamera; }
        }

        public static string Save
        {
            get { return Resource.Save; }
        }

        public static string ChangePassword
        {
            get { return Resource.ChangePassword; }
        }

        public static string CurrentPassword
        {
            get { return Resource.CurrentPassword; }
        }

        public static string CurrentPasswordPlaceHolder
        {
            get { return Resource.CurrentPasswordPlaceHolder; }
        }

        public static string NewPassword
        {
            get { return Resource.NewPassword; }
        }

        public static string NewPasswordPlaceHolder
        {
            get { return Resource.NewPasswordPlaceHolder; }
        }

        public static string ConnectionError1
        {
            get { return Resource.ConnectionError1; }
        }

        public static string ConnectionError2
        {
            get { return Resource.ConnectionError2; }
        }

        public static string LoginError
        {
            get { return Resource.LoginError; }
        }

        public static string ChagePasswordConfirm
        {
            get { return Resource.ChagePasswordConfirm; }
        }

        public static string IncorrectPassword
        {
            get { return Resource.IncorrectPassword; }
        }

        public static string PasswordError
        {
            get { return Resource.PasswordError; }
        }

        public static string ErrorChangingPassword
        {
            get { return Resource.ErrorChangingPassword; }
        }
    }
}
