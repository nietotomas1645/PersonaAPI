namespace PersonaAPI.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string LastName { get; set; } = String.Empty;
        public int Age { get; set; } 
        public string City { get; set; } = String.Empty;
    }
}
