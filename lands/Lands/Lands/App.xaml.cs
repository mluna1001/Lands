namespace Lands
{
    using Helpers;
    using Views;
    using ViewModels;
    using Xamarin.Forms;

    public partial class App : Application
	{
        #region Properties
        // Usar en cualquier parte del código
        public static NavigationPage Navigator
        {
            get;
            internal set;
        } 
        #endregion

        #region Constructors
        public App ()
		{
			InitializeComponent();

            if (string.IsNullOrEmpty(Settings.Token))
            {
                MainPage = new NavigationPage(new LoginPage());
            }
            else
            {
                var mainViewModel = MainViewModel.GetInstance();
                mainViewModel.Token = Settings.Token;
                mainViewModel.TokenType = Settings.TokenType;
                MainPage = new MasterPage();
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
