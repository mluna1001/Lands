﻿namespace Lands.ViewModels
{
    using Domain;
    using Helpers;
    using Models;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public class MainViewModel : BaseViewModel
    {
        #region Attributes
        private UserLocal user;
        #endregion

        #region Properties
        public List<Land> LandsList
        {
            get;
            set;
        }

        //public string Token
        //{
        //    get;
        //    set;
        //}

        //public string TokenType
        //{
        //    get;
        //    set;
        //}

        public TokenResponse Token
        {
            get;
            set;
        }

        public ObservableCollection<MenuItemViewModel> Menus
        {
            get;
            set;
        }

        public UserLocal User
        {
            get { return this.user; }
            set { SetValue(ref this.user, value); }
        }

        #endregion

        #region ViewModels
        public LoginViewModel Login { get; set; }
        public LandsViewModel Lands { get; set; }
        public LandViewModel Land { get; set; }
        public RegisterViewModel Register { get; set; }
        public MyProfileViewModel MyProfile { get; set; }
        public ChangePasswordViewModel ChangePassword { get; set; }
        #endregion

        #region Constructors
        public MainViewModel()
        {
            instance = this;
            this.Login = new LoginViewModel();
            this.LoadMenu();
        }
        #endregion

        #region Singleton
        private static MainViewModel instance;

        public static MainViewModel GetInstance()
        {
            if (instance is null)
            {
                return new MainViewModel();
            }

            return instance;
        }
        #endregion

        #region Methods
        private void LoadMenu()
        {
            this.Menus = new ObservableCollection<MenuItemViewModel>();
            this.Menus.Add(new MenuItemViewModel
            {
                Icon= "ic_settings",
                Title=Languages.MyProfile,
                PageName="MyProfilePage"
            });
            this.Menus.Add(new MenuItemViewModel
            {
                Icon = "ic_insert_chart",
                Title = Languages.Statics,
                PageName = "StaticsPage"
            });
            this.Menus.Add(new MenuItemViewModel
            {
                Icon = "ic_exit_to_app",
                Title = Languages.Logout,
                PageName = "LoginPage"
            });
        }
        #endregion

    }
}
