using System;
using System.Collections.Generic;
using System.Text;

namespace ChatClientMobile.Models
{
    class RestChatModel
    {
        public long Id { get; set; }
        public long OwnerId { get; set; }
        public long FriendId { get; set; }
        public string LastMessage { get; set; }
        public short LastMessageBy { get; set; }
        public short LastMessageType { get; set; }
        public DateTime LastMessageAt { get; set; }
    }
}
