namespace Lands.ViewModels
{
    using System;

    public class MainViewModel
    {
        #region ViewModels
        public LoginViewModel Login { get; set; }
        public LandsViewModel Lands { get; set; }
        #endregion

        #region Constructors
        public MainViewModel()
        {
            this.Login = new LoginViewModel();
            this.Lands = new LandsViewModel();
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
    }
}
