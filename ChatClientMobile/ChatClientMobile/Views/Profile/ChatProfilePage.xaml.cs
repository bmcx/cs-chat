using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace ChatClientMobile.Views.Profile
{
    /// <summary>
    /// Page to show chat profile page
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChatProfilePage
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatProfilePage" /> class.
        /// </summary>
        public ChatProfilePage(string ProfileImage)
        {
            InitializeComponent();
            this.ProfileImage.Source = ProfileImage;
        }
    }
}