using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ChatClientMobile.Models;
using ChatClientMobile.Models.Chat;
using Newtonsoft.Json;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace ChatClientMobile.ViewModels.Chat
{
    /// <summary>
    /// ViewModel for chat message page.
    /// </summary>
    [Preserve(AllMembers = true)]
    public class ChatMessageViewModel : BaseViewModel
    {
        #region Fields

        /// <summary>
        /// Stores the message text in an array. 
        /// </summary>
        /*private readonly string[] descriptions = { "Hi, can you tell me the specifications of the Dell Inspiron 5370 laptop?",
            " * Processor: Intel Core i5-8250U processor " +
            "\n" + " * OS: Pre-loaded Windows 10 with lifetime validity" +
            "\n" + " * Display: 13.3-inch FHD (1920 x 1080) LED display" +
            "\n" + " * Memory: 8GB DDR RAM with Intel UHD 620 Graphics" +
            "\n" + " * Battery: Lithium battery",
            "How much battery life does it have with wifi and without?",
            "Approximately 5 hours with wifi. About 7 hours without.",
        };*/

        private string profileName;

        private string newMessage;

        private string profileImage;

        private string userPhone;

        private long chatId;
        private long ownerId;
        private long friendId;

        private ObservableCollection<ChatMessage> chatMessageInfo = new ObservableCollection<ChatMessage>();

        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="ChatMessageViewModel" /> class.
        /// </summary>
        public ChatMessageViewModel(ChatDetail data)
        {
            System.Diagnostics.Debug.WriteLine(data);
            profileName = data.SenderName;
            profileImage = data.ImagePath;
            chatId = data.Id;
            ownerId = data.OwnerId;
            friendId = data.FriendId;
            userPhone = data.SenderPhone;


            this.ChatMessageInfo = new ObservableCollection<ChatMessage> { };
            this.MakeVoiceCall = new Command(this.VoiceCallClicked);
            this.MakeVideoCall = new Command(this.VideoCallClicked);
            this.MenuCommand = new Command(this.MenuClicked);
            this.ShowCamera = new Command(this.CameraClicked);
            this.SendAttachment = new Command(this.AttachmentClicked);
            this.SendCommand = new Command(this.SendClicked);
            this.BackCommand = new Command(this.BackButtonClicked);
            this.ProfileCommand = new Command(this.ProfileClicked);
            this.fetchMessageList();
            this.startTimer();
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the profile name.
        /// </summary>
        public string ProfileName
        {
            get
            {
                return this.profileName;
            }

            set
            {
                this.profileName = value;
                this.NotifyPropertyChanged();
            }
        }

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

        /// <summary>
        /// Gets or sets a collection of chat messages.
        /// </summary>
        public ObservableCollection<ChatMessage> ChatMessageInfo
        {
            get
            {
                return this.chatMessageInfo;
            }

            set
            {
                this.chatMessageInfo = value;
                this.NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets a new message.
        /// </summary>
        public string NewMessage
        {
            get
            {
                return this.newMessage;
            }

            set
            {
                this.newMessage = value;
                this.NotifyPropertyChanged();
            }
        }

        #endregion

        #region Commands

        /// <summary>
        /// Gets or sets the command that is executed when the profile name is clicked.
        /// </summary>
        public Command ProfileCommand { get; set; }

        /// <summary>
        /// Gets or sets the command that is executed when the voice call button is clicked.
        /// </summary>
        public Command MakeVoiceCall { get; set; }

        /// <summary>
        /// Gets or sets the command that is executed when the video call button is clicked.
        /// </summary>
        public Command MakeVideoCall { get; set; }

        /// <summary>
        /// Gets or sets the command that is executed when the menu button is clicked.
        /// </summary>
        public Command MenuCommand { get; set; }

        /// <summary>
        /// Gets or sets the command that is executed when the camera button is clicked.
        /// </summary>
        public Command ShowCamera { get; set; }

        /// <summary>
        /// Gets or sets the command that is executed when the attachment button is clicked.
        /// </summary>
        public Command SendAttachment { get; set; }

        /// <summary>
        /// Gets or sets the command that is executed when the send button is clicked.
        /// </summary>
        public Command SendCommand { get; set; }

        /// <summary>
        /// Gets or sets the command that is executed when the back button is clicked.
        /// </summary>
        public Command BackCommand { get; set; }

        #endregion

        #region Methods
        private async void startTimer()
        {
            Device.StartTimer(TimeSpan.FromSeconds(5), () =>
            {

                fetchMessageList();
                return true; // True = Repeat again, False = Stop the timer
            });
        }
        private async void fetchMessageList()
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync(App.BaseApiUrl + "/messages/" + chatId.ToString());
            var list = JsonConvert.DeserializeObject<List<RestMessageModel>>(response);
            var myId = Application.Current.Properties["userID"].ToString();
            bool imOwner = this.ownerId.ToString() == myId;
            var _messagesNew = new ObservableCollection<ChatMessage> { };

            foreach (var single in list)
            {
                var textMsg = new ChatMessage
                {
                    Message = single.Body,
                    Time = single.TimeStamp.ToLocalTime(),
                    IsReceived = single.SenderId == 1? (imOwner? true: false) : (!imOwner ? true : false),
                };
                var imageMsg = new ChatMessage
                {
                    ImagePath = single.imagePath,
                    Time = single.TimeStamp.ToLocalTime(),
                    IsReceived = single.SenderId == 1 ? (imOwner ? true : false) : (!imOwner ? true : false),
                };

                _messagesNew.Add(single.Type == 2 ? imageMsg : textMsg);
            }
            this.ChatMessageInfo = _messagesNew;
        }

        private async void sendMessage(String message)
        {
            var httpClient = new HttpClient();
            var myId = Application.Current.Properties["userID"].ToString();
            bool imOwner = this.ownerId.ToString() == myId;

            var payload = "{\"chatId\": "+this.chatId.ToString()+"," +
                "\"senderId\": "+(imOwner?"0":"1")+"," +
                "\"body\": \""+ message +"\"," +
                "\"type\": 1," +
                "\"timeStamp\": \""+DateTime.UtcNow.ToString("o")+ "\"" +
                "}";
            var url = new Uri(App.BaseApiUrl + "/messages");
            HttpContent c = new StringContent(payload, Encoding.UTF8, "application/json");
            HttpResponseMessage result = await httpClient.PostAsync(url, c);
            System.Diagnostics.Debug.WriteLine(result.Content.ReadAsStringAsync().Result);
            updateLastMessage(message);
           
        }
        private async void updateLastMessage(String message)
        {
            var httpClient = new HttpClient();
            var myId = Application.Current.Properties["userID"].ToString();
            bool imOwner = this.ownerId.ToString() == myId;

            var payload = "{\"id\": " + this.chatId.ToString() + "," +
                "\"ownerId\": " + this.ownerId + "," +
                "\"friendId\": " + this.friendId + "," +
                "\"lastMessage\": \"" + message + "\"," +
                "\"lastMessageBy\": " + (imOwner ? "1" : "0") + "," +
                "\"lastMessageType\": 1," +
                "\"lastMessageAt\": \"" + DateTime.UtcNow.ToString("o") + "\"" +
                "}";
            var url = new Uri(App.BaseApiUrl + "/chats/" + this.chatId.ToString());
            HttpContent c = new StringContent(payload, Encoding.UTF8, "application/json");
            HttpResponseMessage result = await httpClient.PutAsync(url, c);
            System.Diagnostics.Debug.WriteLine(result.Content.ReadAsStringAsync().Result);

        }


        /// <summary>
        /// Initializes a collection and add it to the message items.
        /// </summary>
        private async void GenerateMessageInfo()
        {
            await Task.Delay(TimeSpan.FromSeconds(5));
            var currentTime = DateTime.UtcNow;
            this.ChatMessageInfo = new ObservableCollection<ChatMessage>
            {
                 new ChatMessage
                 {
                     Message = this.descriptions[0],
                     Time = currentTime.AddMinutes(-2517),
                     IsReceived = true,
                 },
                 new ChatMessage
                 {
                     Message = this.descriptions[1],
                     Time = currentTime.AddMinutes(-2408),
                 },
                 new ChatMessage
                 {
                     ImagePath = App.BaseImageUrl + "Electronics.png",
                     Time = currentTime.AddMinutes(-2405),
                 },
                 new ChatMessage
                 {
                     Message = this.descriptions[2],
                     Time = currentTime.AddMinutes(-1103),
                     IsReceived = true,
                 },
                 new ChatMessage
                 {
                     Message = this.descriptions[3],
                     Time = currentTime.AddMinutes(-1006),
                 },
            };
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
        /// Invoked when the voice call button is clicked.
        /// </summary>
        /// <param name="obj">The object</param>
        private void VoiceCallClicked(object obj)
        {
            
            PlacePhoneCall(userPhone);
        }

        /// <summary>
        /// Invoked when the video call button is clicked.
        /// </summary>
        /// <param name="obj">The object</param>
        private void VideoCallClicked(object obj)
        {
            // Do something
        }

        /// <summary>
        /// Invoked when the menu button is clicked.
        /// </summary>
        /// <param name="obj">The object</param>
        private void MenuClicked(object obj)
        {
            // Do something
        }

        /// <summary>
        /// Invoked when the camera icon is clicked.
        /// </summary>
        /// <param name="obj">The object</param>
        private void CameraClicked(object obj)
        {
            // Do something
        }

        /// <summary>
        /// Invoked when the attachment icon is clicked.
        /// </summary>
        /// <param name="obj">The object</param>
        private void AttachmentClicked(object obj)
        {
            // Do something
        }

        /// <summary>
        /// Invoked when the send button is clicked.
        /// </summary>
        /// <param name="obj">The object</param>
        private void SendClicked(object obj)
        {
            if (!string.IsNullOrWhiteSpace(this.NewMessage))
            {
                this.ChatMessageInfo.Add(new ChatMessage
                {
                    Message = this.NewMessage.Trim(),
                    Time = DateTime.UtcNow
                });

                this.sendMessage(this.newMessage.Trim());
            }

            this.NewMessage = null;
        }

        /// <summary>
        /// Invoked when the back button is clicked.
        /// </summary>
        /// <param name="obj">The object</param>
        private async void BackButtonClicked(object obj)
        {
            await Application.Current.MainPage.Navigation.PopAsync();
        }

        /// <summary>
        /// Invoked when the Profile name is clicked.
        /// </summary>
        private async void ProfileClicked(object obj)
        {
            var contactProfilePage = new Views.Profile.ContactProfilePage();
           // await Application.Current.MainPage.Navigation.PushAsync(contactProfilePage);
        }

        #endregion
    }
}
