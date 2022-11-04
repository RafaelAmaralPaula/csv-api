using Csv.Api.Models;
using CsvHelper.Configuration;

namespace Csv.Api.Config
{
    public class TemperatureMap : ClassMap<Temperature>
    {

        public TemperatureMap()
        {
            Map(m => m.Temperatura).Name("temperatura");
            Map(m => m.Hora).Name("hora");
        }

    }
}