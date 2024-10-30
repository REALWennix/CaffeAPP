namespace BlazorApp1.Models
{
    // Models/Task.cs
    public class Task
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? CompletedAt { get; set; }
    }

}
