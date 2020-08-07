using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace ChatClientMobile.ViewModels.Profile
{
    /// <summary>
    /// ViewModel for profile page
    /// </summary>
    [Preserve(AllMembers = true)]
    public class ChatProfileViewModel : BaseViewModel
    {

        private string email;
        private string fullName;
        private string phone;

        #region Constructor

        /// <summary>
        /// Initializes a new instance for the <see cref="ProfileViewModel" /> class
        /// </summary>
        public ChatProfileViewModel()
        {
            email = Application.Current.Properties["userEmail"].ToString();
            fullName = Application.Current.Properties["userFullName"].ToString();
            phone = Application.Current.Properties["userPhone"].ToString();
            System.Diagnostics.Debug.WriteLine(Email);
            this.EditCommand = new Command(this.EditButtonClicked);
            this.AvailableCommand = new Command(this.AvailableStatusClicked);
            this.LogoutCommand = new Command(this.LogoutOptionClicked);
        }

        #endregion

        public string FullName
        {
            get
            {
                return this.fullName;
            }

            set
            {
                this.fullName = value;
                this.NotifyPropertyChanged();
            }
        }
        public string Email
        {
            get
            {
                return this.email;
            }

            set
            {
                this.email = value;
                this.NotifyPropertyChanged();
            }
        }
        public string Phone
        {
            get
            {
                return this.phone;
            }

            set
            {
                this.phone = value;
                this.NotifyPropertyChanged();
            }
        }

        #region Command

        /// <summary>
        /// Gets or sets the command that is executed when the edit button is clicked.
        /// </summary>
        public Command EditCommand { get; set; }

        /// <summary>
        /// Gets or sets the command that is executed when the available status is clicked.
        /// </summary>
        public Command AvailableCommand { get; set; }

        /// <summary>
        /// Gets or sets the command that is executed when the logout option is clicked.
        /// </summary>
        public Command LogoutCommand { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Invoked when the edit button is clicked.
        /// </summary>
        /// <param name="obj">The object</param>
        private void EditButtonClicked(object obj)
        {
            // Do something
        }

        /// <summary>
        /// Invoked when the available status is clicked.
        /// </summary>
        /// <param name="obj">The object</param>
        private async void AvailableStatusClicked(object obj)
        {
            Application.Current.Resources.TryGetValue("Gray-100", out var retVal);
            (obj as Grid).BackgroundColor = (Color)retVal;
            await Task.Delay(100);
            (obj as Grid).BackgroundColor = Color.Transparent;
        }

        /// <summary>
        /// Invoked when the notification option is clicked.
        /// </summary>
        /// <param name="obj">The object</param>
        private async void LogoutOptionClicked(object obj)
        {
            Application.Current.Resources.TryGetValue("Gray-100", out var retVal);
            (obj as Grid).BackgroundColor = (Color)retVal;
            await Task.Delay(100);
            (obj as Grid).BackgroundColor = Color.Transparent;

            await Application.Current.MainPage.Navigation.PopToRootAsync();
        }

        #endregion
    }
}
