using Microsoft.AspNetCore.Identity;

namespace TeamsWebApp.Models
{
    public class Message
    {
        public int MessageId { get; set; }
        public int IDUserFrom { get; set; }
        public int IDUserTo {  get; set; }
        public string ChatText { get; set; }
        public DateTime DateTime { get; set; }

        public Message() { }
    }
}
