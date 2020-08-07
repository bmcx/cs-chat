using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChatClientMobile
{
    public partial class App : Application
    {
        public static string BaseImageUrl { get; } = "https://cdn.syncfusion.com/essential-ui-kit-for-xamarin.forms/common/uikitimages/";
        public static string BaseApiUrl { get; } = "https://chatapi20200807163411.azurewebsites.net/api";
        //public static string BaseApiUrl { get; } = "http://10.0.2.2:5000/api";
        public App()
        {
            InitializeComponent();

            var homePage = new Views.Forms.LoginPage();
            var navPage = new NavigationPage(homePage);
            this.MainPage = navPage;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
