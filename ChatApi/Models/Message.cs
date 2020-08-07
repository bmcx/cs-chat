using System;
using System.Threading.Tasks;

namespace ChatApi.Models
{
    public class Message
    {
        public long Id { get; set; }
        public long ChatId { get; set; }
        public long SenderId { get; set; }
        public string Body { get; set; }
        public string imagePath { get; set; }
        public short Type { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
