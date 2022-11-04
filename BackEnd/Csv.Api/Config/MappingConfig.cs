using AutoMapper;
using Csv.Api.Data.ValueObject;
using Csv.Api.Models;

namespace Csv.Api.Config
{
    public class MappingConfig
    {

        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<TemperatureVO, Temperature>();
                config.CreateMap<Temperature, TemperatureVO>();
            });

            return mappingConfig;

        }

    }
}