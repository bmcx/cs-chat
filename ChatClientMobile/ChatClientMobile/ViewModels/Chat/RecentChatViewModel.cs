using System.Collections.ObjectModel;
using ChatClientMobile.Models.Chat;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections.Generic;
using ChatClientMobile.Models;
using System.Threading.Tasks;
using Xamarin.Essentials;
using System;

namespace ChatClientMobile.ViewModels.Chat
{
    /// <summary>
    /// View model for recent chat page 
    /// </summary> 
    [Preserve(AllMembers = true)]
    public class RecentChatViewModel : BaseViewModel
    {
        #region Fields

        private ObservableCollection<ChatDetail> chatItems;

        private string profileImage;

        private Command itemSelectedCommand;

        private string myId = "-1";
        private bool isVisible;

        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="RecentChatViewModel" /> class.
        /// </summary>
        public RecentChatViewModel()
        {
            myId = Application.Current.Properties["userID"].ToString();
            profileImage = Application.Current.Properties["userImage"].ToString();
            this.ChatItems = new ObservableCollection<ChatDetail>
            {
                /* new ChatDetail
                 {
                     ImagePath = App.BaseImageUrl + "ProfileImage2.png",
                     SenderName = "Alice Russell",
                     MessageType = "Text",
                     Message = "https://app.syncfusion",
                     Time = "15 min",
                     NotificationType = "New"
                 },
                 new ChatDetail
                 {
                     ImagePath = App.BaseImageUrl + "ProfileImage3.png",
                     SenderName = "Danielle Schneider",
                     MessageType = "Audio",
                     Time = "23 min",
                     AvailableStatus = "Available",
                     NotificationType = "Viewed"
                 },
                 new ChatDetail
                 {
                     ImagePath = App.BaseImageUrl + "ProfileImage4.png",
                     SenderName = "Jessica Park",
                     MessageType = "Text",
                     Message = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                     Time = "1 hr",
                     NotificationType = "New"
                 },
                 new ChatDetail
                 {
                     ImagePath = App.BaseImageUrl + "ProfileImage5.png",
                     SenderName = "Julia Grant",
                     MessageType = "Video",
                     Time = "3 hr",
                     AvailableStatus = "Available",
                     NotificationType = "Received"
                 },
                 new ChatDetail
                 {
                     ImagePath = App.BaseImageUrl + "ProfileImage6.png",
                     SenderName = "kyle Greene",
                     MessageType = "Contact",
                     Message = "Jhone Deo Sync",
                     Time = "Yesterday",
                     NotificationType = "Viewed"
                 },
                 new ChatDetail
                 {
                     ImagePath = App.BaseImageUrl + "ProfileImage7.png",
                     SenderName = "Danielle Booker",
                     MessageType = "Text",
                     Message = "Val Geisier is a writer who",
                     Time = "Jan 30",
                     AvailableStatus = "Available",
                     NotificationType = "Sent"
                 },
                 new ChatDetail
                 {
                     ImagePath = App.BaseImageUrl + "ProfileImage8.png",
                     SenderName = "Jazmine Simmons",
                     MessageType = "Text",
                     Message = "Contrary to popular belief, Lorem Ipsum is not simply random text." +
                               "It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old.",
                     Time = "12/8/2018",
                     NotificationType = "Sent"
                 },
                 new ChatDetail
                 {
                     ImagePath = App.BaseImageUrl + "ProfileImage9.png",
                     SenderName = "Ira Membrit",
                     MessageType = "Photo",
                     Time = "8/8/2018",
                     AvailableStatus = "Available",
                     NotificationType = "Viewed"
                 },
                 new ChatDetail
                 {
                     ImagePath = App.BaseImageUrl + "ProfileImage10.png",
                     MessageType = "Text",
                     Message = "A customer who bought your",
                     SenderName = "Serina Willams",
                     Time = "10/6/2018",
                     NotificationType = "Sent"
                 },
                  new ChatDetail
                  {
                     ImagePath = App.BaseImageUrl + "ProfileImage11.png",
                     SenderName = "Alise Valasquez",
                     MessageType = "Text",
                     Message = "Syncfusion components help you deliver applications with great user experiences across iOS, Android, and Universal Windows Platform from a single code base.",
                     Time = "2/5/2018",
                     NotificationType = "New"
                 },
                 new ChatDetail
                 {
                     ImagePath = App.BaseImageUrl + "ProfileImage12.png",
                     SenderName = "Allie Bellew",
                     MessageType = "Audio",
                     Time = "24/4/2018",
                     AvailableStatus = "Available",
                     NotificationType = "Viewed"
                 },
                 new ChatDetail
                 {
                     ImagePath = App.BaseImageUrl + "ProfileImage13.png",
                     SenderName = "Navya Sharma",
                     MessageType = "Text",
                     Message = "https://www.syncfusion.com",
                     Time = "10/4/2018",
                     NotificationType = "New"
                 },
                 new ChatDetail
                 {
                     ImagePath = App.BaseImageUrl + "ProfileImage14.png",
                     SenderName = "Carly Ling",
                     MessageType = "Video",
                     Time = "22/3/2018",
                     AvailableStatus = "Available",
                     NotificationType = "Received"
                 },
                 new ChatDetail
                 {
                     ImagePath = App.BaseImageUrl + "ProfileImage15.png",
                     SenderName = "Diayana Sebastine",
                     MessageType = "Contact",
                     Message = "Kishore Nisanth",
                     Time = "15/3/2018",
                     NotificationType = "Viewed"
                 },
                 new ChatDetail
                 {
                     ImagePath = App.BaseImageUrl + "ProfileImage16.png",
                     SenderName = "Marc Sherry",
                     MessageType = "Text",
                     Message = "Val Geisier is a writer who",
                     Time = "12/3/2018",
                     AvailableStatus = "Available",
                     NotificationType = "Sent"
                 },
                 new ChatDetail
                 {
                     ImagePath = App.BaseImageUrl + "ProfileImage17.png",
                     SenderName = "Dona Merina",
                     MessageType = "Text",
                     Message = "Contrary to popular belief, Lorem Ipsum is not simply random text." +
                               "It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old.",
                     Time = "3/2/2018",
                     NotificationType = "Sent"
                 },*/
            };

            this.MakeVoiceCallCommand = new Command(this.VoiceCallClicked);
            this.MakeVideoCallCommand = new Command(this.VideoCallClicked);
            this.ShowSettingsCommand = new Command(this.SettingsClicked);
            this.MenuCommand = new Command(this.MenuClicked);
            this.ProfileImageCommand = new Command(this.ProfileImageClicked);

            this.fetchChatList();
            this.startTimer();
        }
        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the profile image.
        /// </summary>
        public string ProfileImage
        {
            get
            {
                return this.profileImage;
            }

            set
            {
                this.profileImage = value;
                this.NotifyPropertyChanged();
            }
        }
        public bool IsVisible
        {
            get
            {
                return this.isVisible;
            }

            set
            {
                this.isVisible = value;
                this.NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the property that has been bound with a list view, which displays the profile items.
        /// </summary>
        public ObservableCollection<ChatDetail> ChatItems
        {
            get
            {
                return this.chatItems;
            }

            set
            {
                if (this.chatItems == value)
                {
                    return;
                }

                this.chatItems = value;
                this.NotifyPropertyChanged();
            }
        }

        #endregion

        #region Commands
        /// <summary>
        /// Gets or sets the command that is executed when the voice call button is clicked.
        /// </summary>
        public Command MakeVoiceCallCommand { get; set; }

        /// <summary>
        /// Gets or sets the command that is executed when the video call button is clicked.
        /// </summary>
        public Command MakeVideoCallCommand { get; set; }

        /// <summary>
        /// Gets or sets the command that is executed when the settings button is clicked.
        /// </summary>
        public Command ShowSettingsCommand { get; set; }

        /// <summary>
        /// Gets or sets the command that is executed when the menu button is clicked.
        /// </summary>
        public Command MenuCommand { get; set; }

        /// <summary>
        /// Gets the command that is executed when an item is selected.
        /// </summary>
        public Command ItemSelectedCommand
        {
            get { return this.itemSelectedCommand ?? (this.itemSelectedCommand = new Command(this.ItemSelected)); }
        }

        /// <summary>
        /// Gets or sets the command that is executed when the profile image is clicked.
        /// </summary>
        public Command ProfileImageCommand { get; set; }

        #endregion

        #region Methods
        private void startTimer()
        {
            Device.StartTimer(TimeSpan.FromSeconds(5), () =>
            {
                fetchChatList();
                return true; // True = Repeat again, False = Stop the timer
            });
        }

        private async void fetchChatList()
        {
            var httpClient = new HttpClient();
            myId = Application.Current.Properties["userID"].ToString();
            var response = await httpClient.GetStringAsync(App.BaseApiUrl + "/chats/"+ (myId.Length != 0?myId:"0"));
            var chatList = JsonConvert.DeserializeObject<List<RestChatModel>>(response);
            var _chatItemsNew = new ObservableCollection<ChatDetail> { };
            foreach (var singleChat in chatList)
            {
 
            //System.Diagnostics.Debug.WriteLine(singleChat.OwnerId.ToString()+" "+myId);
                bool imOwner = singleChat.OwnerId.ToString() == myId;

                RestUserModel user;
                if (imOwner)
                {
                   user = await fetchChatUserDetails(singleChat.FriendId.ToString());
                }
                else
                {
                     user = await fetchChatUserDetails(singleChat.OwnerId.ToString());
                }
                
                _chatItemsNew.Add(
                    new ChatDetail
                    {
                        Id = singleChat.Id,
                        SenderPhone = user.Phone,
                        OwnerId = singleChat.OwnerId,
                        FriendId = singleChat.FriendId,
                        ImagePath = user.Image,
                        SenderName = user.FirstName+" "+user.LastName,
                        MessageType = singleChat.LastMessageType == 1 ? "Text" : singleChat.LastMessageType == 2 ? "Audio" : "Video",
                        Message = singleChat.LastMessage,
                        Time = Helpers.DateTimeHelper.GetFriendlyRelativeTime(singleChat.LastMessageAt),
                        NotificationType = singleChat.LastMessageBy == 1 ? (imOwner? "Sent" : "New" ) : (!imOwner ? "Sent" : "New")
                    });

            }
            if(_chatItemsNew.Count == 0)
            {
                this.IsVisible = true;
            }else
            {
                this.IsVisible = false;
            }
            if(this.ChatItems.Count <= _chatItemsNew.Count)
            {
            this.ChatItems = _chatItemsNew;
            }

        }
        private async Task<RestUserModel> fetchChatUserDetails(string id)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync(App.BaseApiUrl + "/users/"+ id);
            var user = JsonConvert.DeserializeObject<RestUserModel>(response);
            return user;
        }
        public void PlacePhoneCall(string number)
        {
            try
            {
                PhoneDialer.Open(number);
            }
            catch (FeatureNotSupportedException ex)
            {
                // Phone Dialer is not supported on this device.
            }
            catch (Exception ex)
            {
                // Other error has occurred.
            }
        }

        /// <summary>
        /// Invoked when an item is selected.
        /// </summary>
        private async void ItemSelected(object selectedItem)
        {
            var args = selectedItem as Syncfusion.ListView.XForms.ItemTappedEventArgs;
            var chatDetail = args.ItemData as ChatDetail;


            System.Diagnostics.Debug.WriteLine(chatDetail.SenderName);
            var chatMessagePage = new Views.Chat.ChatMessagePage(chatDetail);
            await Application.Current.MainPage.Navigation.PushAsync(chatMessagePage);
        }

        /// <summary>
        /// Invoked when the Profile image is clicked.
        /// </summary>
        private async void ProfileImageClicked(object obj)
        {
            var userImage = Application.Current.Properties["userImage"];
            var chatProfilePage = new Views.Profile.ChatProfilePage(userImage.ToString());
            await Application.Current.MainPage.Navigation.PushAsync(chatProfilePage);
        }

        /// <summary>
        /// Invoked when the voice call button is clicked.
        /// </summary>
        /// <param name="obj">The Object</param>
        private void VoiceCallClicked(object obj)
        {
           // var args = obj as Syncfusion.ListView.XForms.ItemTappedEventArgs;
            //var chatDetail = args.ItemData as ChatDetail;


            System.Diagnostics.Debug.WriteLine(obj);
            string phone = Application.Current.Properties["userPhone"].ToString();
            //PlacePhoneCall(phone);
        }

        /// <summary>
        /// Invoked when the video call button is clicked.
        /// </summary>
        /// <param name="obj">The Object</param>
        private void VideoCallClicked(object obj)
        {
            // Do something
        }

        /// <summary>
        /// Invoked when the settings button is clicked.
        /// </summary>
        /// <param name="obj">The Object</param>
        private async void SettingsClicked(object obj)
        {

        }

        /// <summary>
        /// Invoked when the menu button is clicked.
        /// </summary>
        /// <param name="obj">The Object</param>
        private async void MenuClicked(object obj)
        {
            var simpleForgotPasswordPage = new Views.Forms.SimpleForgotPasswordPage();
            await Application.Current.MainPage.Navigation.PushAsync(simpleForgotPasswordPage);
        }

        #endregion
    }
}
