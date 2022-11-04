
namespace Csv.Api.Data.ValueObject
{
    public class TemperatureVO
    {

        public string Temperatura { get; set; }

        public string Hora { get; set; }

        public TemperatureVO() { }

        public TemperatureVO(string temperatura, string hora)
        {
            Temperatura = temperatura;
            Hora = hora;
        }

    }
}