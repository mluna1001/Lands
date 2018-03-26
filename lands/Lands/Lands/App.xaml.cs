namespace Lands
{
    using Helpers;
    using Models;
    using Services;
    using Views;
    using ViewModels;
    using Xamarin.Forms;
    using System;

    public partial class App : Application
	{
        #region Properties
        // Usar en cualquier parte del código
        public static NavigationPage Navigator
        {
            get;
            internal set;
        }
        public static MasterPage Master { get; internal set; }
        #endregion

        #region Constructors
        public App ()
		{
			InitializeComponent();

            //if (string.IsNullOrEmpty(Settings.Token))
            if (!Settings.IsRemembered.Equals("true"))
            {
                MainPage = new NavigationPage(new LoginPage());
            }
            else
            {
                var dataService = new DataService();
                var user = dataService.First<UserLocal>(false);
                var token = dataService.First<TokenResponse>(false);

                if (token != null && token.Expires > DateTime.Now)
                {
                    var mainViewModel = MainViewModel.GetInstance();
                    mainViewModel.Token = token;
                    //mainViewModel.Token = Settings.Token;
                    //mainViewModel.TokenType = Settings.TokenType;
                    mainViewModel.User = user;
                    mainViewModel.Lands = new LandsViewModel();
                    MainPage = new MasterPage();
                    // Si no funciona la linea anterior, intentar esta otra
                    //Application.Current.MainPage = new MasterPage();
                }
                else
                {
                    MainPage = new NavigationPage(new LoginPage());
                }

            }
            //this.MainPage = new MasterPage();
		}
        #endregion

        #region Methods
        protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
        #endregion
    }
}
