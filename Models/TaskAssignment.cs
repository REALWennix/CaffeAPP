namespace BlazorApp1.Models
{
    // Models/TaskAssignment.cs
    public class TaskAssignment
    {
        public int ID { get; set; }
        public int TaskId { get; set; }
        public int AssignedTo { get; set; }

        public Task Task { get; set; }
        public Person AssignedPerson { get; set; }
    }

}
