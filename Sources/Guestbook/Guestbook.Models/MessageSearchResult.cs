namespace Guestbook.Models
{
    using System.Collections.Generic;

    public class MessageSearchResult
    {
        public IEnumerable<Message> Items { get; set; }
        public int TotalCount { get; set; }
    }
}