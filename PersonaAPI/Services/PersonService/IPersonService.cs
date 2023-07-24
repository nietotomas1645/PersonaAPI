namespace PersonaAPI.Services.PersonService
{
    public interface IPersonService
    {
        Task<List<Person>> GetAllPersons();
        Task<Person?> GetSinglePerson(int id);
        Task<List<Person>> AddPerson(Person per);
        Task<List<Person>?> UpdatePerson(int id, Person request);
        Task<List<Person>?> DeletePerson(int id);
    }
}
