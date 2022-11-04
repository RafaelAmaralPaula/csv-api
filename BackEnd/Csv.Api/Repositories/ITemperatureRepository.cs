using Csv.Api.Models;

namespace Csv.Api.Repositories
{
    public interface ITemperatureRepository
    {

        IEnumerable<Temperature> FindAll();

        void SaveAll(List<Temperature> list);

    }
}