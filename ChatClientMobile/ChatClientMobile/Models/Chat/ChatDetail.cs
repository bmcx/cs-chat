using Xamarin.Forms.Internals;

namespace ChatClientMobile.Models.Chat
{
    /// <summary>
    /// Model for recent chat
    /// </summary>
    [Preserve(AllMembers = true)]
    public class ChatDetail
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the chat id.
        /// </summary>
        public long Id { get; set; }
        public long OwnerId { get; set; }
        public long FriendId { get; set; }
        
        /// <summary>
        /// Gets or sets the profile image path.
        /// </summary>
        public string ImagePath { get; set; }

        /// <summary>
        /// Gets or sets the profile name.
        /// </summary>
        public string SenderName { get; set; }
        public string SenderPhone { get; set; }

        /// <summary>
        /// Gets or sets the message sent/received time.
        /// </summary>
        public string Time { get; set; }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the MessageType.
        /// </summary>
        public string MessageType { get; set; }

        /// <summary>
        /// Gets or sets the message sent/received notification type.
        /// </summary>
        public string NotificationType { get; set; }

        /// <summary>
        /// Gets or sets the recipient's available status.
        /// </summary>
        public string AvailableStatus { get; set; }

        #endregion
    }
}
