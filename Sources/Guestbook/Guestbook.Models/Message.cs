﻿namespace Guestbook.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Homepage { get; set; }
        public string Text { get; set; }
    }
}