using Acr.UserDialogs;
using ChatClientMobile.Models.Chat;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace ChatClientMobile.ViewModels.Forms
{
    /// <summary>
    /// ViewModel for login page.
    /// </summary>
    [Preserve(AllMembers = true)]
    public class LoginPageViewModel : LoginViewModel
    {
        #region Fields

        private string password;
        private bool loading = false;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance for the <see cref="LoginPageViewModel" /> class.
        /// </summary>
        public LoginPageViewModel()
        {
            this.LoginCommand = new Command(this.LoginClicked);
            this.SignUpCommand = new Command(this.SignUpClicked);
            this.ForgotPasswordCommand = new Command(this.ForgotPasswordClicked);
            Application.Current.Properties["userEmail"] = "";
            Application.Current.Properties["userID"] = "";
            Application.Current.Properties["userImage"] = "";
            Application.Current.Properties["userFullName"] = "";
            Application.Current.Properties["userPhone"] = "";
        }

        #endregion

        #region property

        /// <summary>
        /// Gets or sets the property that is bound with an entry that gets the password from user in the login page.
        /// </summary>
        public string Password
        {
            get
            {
                return this.password;
            }

            set
            {
                if (this.password == value)
                {
                    return;
                }

                this.password = value;
                this.NotifyPropertyChanged();
            }
        }

        #endregion

        #region Command

        /// <summary>
        /// Gets or sets the command that is executed when the Log In button is clicked.
        /// </summary>
        public Command LoginCommand { get; set; }

        /// <summary>
        /// Gets or sets the command that is executed when the Sign Up button is clicked.
        /// </summary>
        public Command SignUpCommand { get; set; }

        /// <summary>
        /// Gets or sets the command that is executed when the Forgot Password button is clicked.
        /// </summary>
        public Command ForgotPasswordCommand { get; set; }

        #endregion

        #region methods

        /// <summary>
        /// Invoked when the Log In button is clicked.
        /// </summary>
        /// <param name="obj">The Object</param>
        private async void LoginClicked(object obj)
        {


            var current = Connectivity.NetworkAccess;

            if (current == NetworkAccess.Internet)
            {
                var toastConfig = new ToastConfig("Please wait...");
                toastConfig.SetDuration(3000);
                toastConfig.SetBackgroundColor(System.Drawing.Color.FromArgb(12, 131, 193));
                if (!loading)
                {
                    loading = true;
                    UserDialogs.Instance.Toast(toastConfig);
                    checkCreds();
                }
                else
                {
                    UserDialogs.Instance.Toast(toastConfig);
                }

            }
            else
            {
                var toastConfig = new ToastConfig("Please check your internet connection!");
                toastConfig.SetDuration(3000);
                toastConfig.SetBackgroundColor(System.Drawing.Color.FromArgb(242, 76, 101));
                UserDialogs.Instance.Toast(toastConfig);
            }


        }
        private async void checkCreds()
        {

            try
            {
                var httpClient = new HttpClient();

                var payload = "{\"email\": \"" + this.Email + "\"," +
                    "\"password\": \"" + this.password + "\"" +
                    "}";
                var url = new Uri(App.BaseApiUrl + "/users/login");
                HttpContent c = new StringContent(payload, Encoding.UTF8, "application/json");
                HttpResponseMessage result = await httpClient.PostAsync(url, c);
                System.Diagnostics.Debug.WriteLine(result.Content.ReadAsStringAsync().Result);
                var users = JsonConvert.DeserializeObject<List<RestUserModel>>(result.Content.ReadAsStringAsync().Result);
                loading = false;
                if (users.Count == 1)
                {
                    Application.Current.Properties["userEmail"] = users[0].Email;
                    Application.Current.Properties["userID"] = users[0].Id;
                    Application.Current.Properties["userImage"] = users[0].Image;
                    Application.Current.Properties["userFullName"] = users[0].FirstName + " " + users[0].LastName;
                    Application.Current.Properties["userPhone"] = users[0].Phone;

                    await Application.Current.SavePropertiesAsync();
                    await Task.Delay(2000);
                    var recentChatPage = new Views.Chat.RecentChatPage();
                    await Application.Current.MainPage.Navigation.PushAsync(recentChatPage);
                }
                else
                {
                    var toastConfig = new ToastConfig("Email or Password is invalid!");
                    toastConfig.SetDuration(3000);
                    toastConfig.SetBackgroundColor(System.Drawing.Color.FromArgb(242, 76, 101));
                    UserDialogs.Instance.Toast(toastConfig);
                }

            }
            catch (Exception e)
            {
                loading = false;
                System.Diagnostics.Debug.WriteLine("E: " + e);
            }


        }

        /// <summary>
        /// Invoked when the Sign Up button is clicked.
        /// </summary>
        /// <param name="obj">The Object</param>
        private async void SignUpClicked(object obj)
        {
            var signUpPage = new Views.Forms.SignUpPage();
            await Application.Current.MainPage.Navigation.PushAsync(signUpPage);
        }

        /// <summary>
        /// Invoked when the Forgot Password button is clicked.
        /// </summary>
        /// <param name="obj">The Object</param>
        private async void ForgotPasswordClicked(object obj)
        {
            var label = obj as Label;
            label.BackgroundColor = Color.FromHex("#50FFFFFF");
            await Task.Delay(100);
            label.BackgroundColor = Color.Transparent;
            var forgotPasswordPage = new Views.Forms.ForgotPasswordPage();
            await Application.Current.MainPage.Navigation.PushAsync(forgotPasswordPage);
        }
        #endregion

    }
}