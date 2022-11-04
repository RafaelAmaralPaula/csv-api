using AutoMapper;
using Csv.Api.Data.ValueObject;
using Csv.Api.Repositories;
using Csv.Api.Utils;

namespace Csv.Api.Services
{
    public class TemperatureService : ITemperatureService
    {

        private ITemperatureRepository _repository;

        private IMapper _mapper;

        private FileUtil _file;

        public TemperatureService(ITemperatureRepository repository, IMapper mapper, FileUtil file)
        {

            _repository = repository;
            _mapper = mapper;
            _file = file;

        }

        public IEnumerable<TemperatureVO> FindAll()
        {
            var temperatures = _repository.FindAll();

            /* Coloquei esse bloco if para não encher
               a base de dados
            */
            if (temperatures.Count() == 0)
            {
                SaveAll();
            }

            return _mapper.Map<List<TemperatureVO>>(temperatures);

        }


        private void SaveAll()
        {
            var list = _file.ReadCsv();
            _repository.SaveAll(list);

        }
    }
}