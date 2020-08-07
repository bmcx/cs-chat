using Acr.UserDialogs;
using ChatClientMobile.Models.Chat;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace ChatClientMobile.ViewModels.Forms
{
    /// <summary>
    /// ViewModel for forgot password page.
    /// </summary>
    [Preserve(AllMembers = true)]
    public class FindFriendViewModel : LoginViewModel
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="ForgotPasswordViewModel" /> class.
        /// </summary>
        public FindFriendViewModel()
        {
            this.SignUpCommand = new Command(this.SignUpClicked);
            this.SendCommand = new Command(this.SendClicked);
        }

        #endregion

        #region Command

        /// <summary>
        /// Gets or sets the command that is executed when the Send button is clicked.
        /// </summary>
        public Command SendCommand { get; set; }

        /// <summary>
        /// Gets or sets the command that is executed when the Sign Up button is clicked.
        /// </summary>
        public Command SignUpCommand { get; set; }

        #endregion

        #region Methods
        private async void checkEmail()
        {
            try
            {
                var httpClient = new HttpClient();
                var recentChatPage = new Views.Chat.RecentChatPage();
                var payload = "{\"email\": \"" + this.Email + "\"" +
                    "}";
                var url = new Uri(App.BaseApiUrl + "/users/search");
                HttpContent c = new StringContent(payload, Encoding.UTF8, "application/json");
                HttpResponseMessage result = await httpClient.PostAsync(url, c);
                var users = JsonConvert.DeserializeObject<List<RestUserModel>>(result.Content.ReadAsStringAsync().Result);
                if (users.Count == 1)
                {

                    addChat(users[0].Id.ToString());
                    await Application.Current.MainPage.Navigation.PopAsync();
                }
                else
                {
                    var toastConfig = new ToastConfig("Email is invalid!");
                    toastConfig.SetDuration(3000);
                    toastConfig.SetBackgroundColor(System.Drawing.Color.FromArgb(242, 76, 101));
                    UserDialogs.Instance.Toast(toastConfig);
                }

            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }
        }
        private async void addChat(String friendId)
        {
            var httpClient = new HttpClient();
            var userid = Application.Current.Properties["userID"].ToString();
            var payload = "{\"ownerId\": " + userid + "," +
                "\"friendId\": " + friendId + "," +
                "\"lastMessage\": \"" + "New Conveersation" + "\"," +
                "\"lastMessageBy\": " + "0" + "," +
                "\"lastMessageType\": 1," +
                "\"lastMessageAt\": \"" + DateTime.UtcNow.ToString("o") + "\"" +
                "}";
            var url = new Uri(App.BaseApiUrl + "/chats");
            HttpContent c = new StringContent(payload, Encoding.UTF8, "application/json");
            HttpResponseMessage result = await httpClient.PostAsync(url, c);
            System.Diagnostics.Debug.WriteLine(result.Content.ReadAsStringAsync().Result);

        }
        /// <summary>
        /// Invoked when the Send button is clicked.
        /// </summary>
        /// <param name="obj">The Object</param>
        private void SendClicked(object obj)
        {
            checkEmail();
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

        #endregion
    }
}