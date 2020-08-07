using Acr.UserDialogs;
using System;
using System.Net.Http;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace ChatClientMobile.ViewModels.Forms
{
    /// <summary>
    /// ViewModel for sign-up page.
    /// </summary>
    [Preserve(AllMembers = true)]
    public class SignUpPageViewModel : LoginViewModel
    {
        #region Fields

        private string firstName;
        private string lastName;

        private string password;

        private string phone;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance for the <see cref="SignUpPageViewModel" /> class.
        /// </summary>
        public SignUpPageViewModel()
        {
            this.LoginCommand = new Command(this.LoginClicked);
            this.SignUpCommand = new Command(this.SignUpClicked);
        }

        #endregion

        #region Property

        /// <summary>
        /// Gets or sets the property that bounds with an entry that gets the name from user in the Sign Up page.
        /// </summary>
        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (this.firstName == value)
                {
                    return;
                }

                this.firstName = value;
                this.NotifyPropertyChanged();
            }
        }
        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (this.lastName == value)
                {
                    return;
                }

                this.lastName = value;
                this.NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the property that bounds with an entry that gets the password from users in the Sign Up page.
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

        /// <summary>
        /// Gets or sets the property that bounds with an entry that gets the password confirmation from users in the Sign Up page.
        /// </summary>
        public string Phone
        {
            get
            {
                return this.phone;
            }

            set
            {
                if (this.phone == value)
                {
                    return;
                }

                this.phone = value;
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

        #endregion

        #region Methods
        private async void addUser()
        {
            try
            {
                var httpClient = new HttpClient();

                var payload = "{\"firstName\": \"" + this.firstName + "\"," +
                    "\"lastName\": \"" + this.lastName + "\"," +
                    "\"email\": \"" + base.Email + "\"," +
                    "\"phone\":  \"" + this.phone + "\"," +
                    "\"image\":  \"https://avatar.oxro.io/avatar.jpg?name=" + this.firstName + "+" + this.lastName + "\"," +
                    "\"password\": \"" + this.password + "\"" +
                    "}";
                var url = new Uri(App.BaseApiUrl + "/users");
                HttpContent c = new StringContent(payload, Encoding.UTF8, "application/json");
                HttpResponseMessage result = await httpClient.PostAsync(url, c);
                System.Diagnostics.Debug.WriteLine(result.Content.ReadAsStringAsync().Result);
                await Application.Current.MainPage.Navigation.PopToRootAsync();
            }
            catch (Exception e)
            {

            }


        }
        /// <summary>
        /// Invoked when the Log in button is clicked.
        /// </summary>
        /// <param name="obj">The Object</param>
        private async void LoginClicked(object obj)
        {
            await Application.Current.MainPage.Navigation.PopToRootAsync();
        }

        /// <summary>
        /// Invoked when the Sign Up button is clicked.
        /// </summary>
        /// <param name="obj">The Object</param>
        private void SignUpClicked(object obj)
        {
            // Do something
            var toastConfig = new ToastConfig("Please wait...");
            toastConfig.SetDuration(3000);
            toastConfig.SetBackgroundColor(System.Drawing.Color.FromArgb(12, 131, 193));
            UserDialogs.Instance.Toast(toastConfig);
            this.addUser();
        }

        #endregion
    }
}