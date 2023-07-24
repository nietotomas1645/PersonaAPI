namespace PersonaAPI.Services.PersonService
{
    public class PersonService : IPersonService
    {
        private readonly DataContext _context;

        public PersonService(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Person>> AddPerson(Person per)
        {
            _context.Persons.Add(per);

            await _context.SaveChangesAsync();
            return await _context.Persons.ToListAsync();
        }

        public async Task<List<Person>?> DeletePerson(int id)
        {
            var per = await _context.Persons.FindAsync(id);
            if (per == null)
                return null;

            _context.Persons.Remove(per);

            await _context.SaveChangesAsync();
            return await _context.Persons.ToListAsync();
        }

        public async Task<List<Person>> GetAllPersons()
        {
            var persons = await _context.Persons.ToListAsync();
            return persons;
        }

        public async Task<Person?> GetSinglePerson(int id)
        {
            var per = await _context.Persons.FindAsync(id);
            if (per == null)
                return null;
            return per;
        }

        public async Task<List<Person>?> UpdatePerson(int id, Person request)
        {
            var per = await _context.Persons.FindAsync(id);
            if (per == null)
                return null;

            per.Name = request.Name;
            per.LastName = request.LastName;
            per.Age = request.Age;
            per.City = request.City;

            await _context.SaveChangesAsync();

            return await _context.Persons.ToListAsync();


        }
    }
}
