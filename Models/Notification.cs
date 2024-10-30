namespace BlazorApp1.Models
{
    // Models/Notification.cs
    public class Notification
    {
        public int ID { get; set; }
        public int RecipientId { get; set; }
        public string Content { get; set; }
        public DateTime SentAt { get; set; }
        public bool IsRead { get; set; }

        public Person Recipient { get; set; }
    }

}
