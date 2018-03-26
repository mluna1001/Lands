﻿namespace Lands.Helpers
{
    using Plugin.Settings;
    using Plugin.Settings.Abstractions;

    public static class Settings
    {
        static ISettings AppSettings
        {
            get
            {
                return CrossSettings.Current;
            }
        }

        const string isRemembered = "IsRemembered";
        //const string tokenId = "Token";
        //const string tokenTypeId = "TokenType";

        static readonly string stringDefault = string.Empty;

        //public static string Token
        //{
        //    get
        //    {
        //        return AppSettings.GetValueOrDefault(tokenId, stringDefault);
        //    }
        //    set
        //    {
        //        AppSettings.AddOrUpdateValue(tokenId, value);
        //    }
        //}

        //public static string TokenType
        //{
        //    get
        //    {
        //        return AppSettings.GetValueOrDefault(tokenTypeId, stringDefault);
        //    }
        //    set
        //    {
        //        AppSettings.AddOrUpdateValue(tokenTypeId, value);
        //    }
        //}

        public static string IsRemembered
        {
            get
            {
                return AppSettings.GetValueOrDefault(isRemembered, stringDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue(isRemembered, value);
            }
        }
    }
}
