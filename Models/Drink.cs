namespace BlazorApp1.Models
{
    // Models/Drink.cs
    public class Drink
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public int IdPerson { get; set; }
        public int IdTypes { get; set; }

        public Person Person { get; set; }
        public Type Type { get; set; }
    }

}
