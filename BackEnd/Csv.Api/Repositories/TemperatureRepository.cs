using Csv.Api.Models;
using Csv.Api.Models.Context;


namespace Csv.Api.Repositories
{
    public class TemperatureRepository : ITemperatureRepository
    {

        private readonly MySqlContext _context;

        public TemperatureRepository(MySqlContext context)
        {
            _context = context;

        }
        public IEnumerable<Temperature> FindAll()
        {
            return _context.Temperatures.ToList();
        }

        public void SaveAll(List<Temperature> temperatures)
        {
            foreach (var value in temperatures)
            {
                _context.Add(value);
                _context.SaveChanges();
            }

        }

    }
}
