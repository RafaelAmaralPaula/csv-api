using Csv.Api.Data.ValueObject;

namespace Csv.Api.Services
{
    public interface ITemperatureService
    {
        IEnumerable<TemperatureVO> FindAll();

    }
}
