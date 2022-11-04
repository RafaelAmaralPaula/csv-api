using System.Globalization;
using Csv.Api.Config;
using Csv.Api.Models;
using CsvHelper;

namespace Csv.Api.Utils
{
    public class FileUtil
    {

        public const string CSV_FILE_PATH = "example_csv.csv";

        public List<Temperature> ReadCsv()
        {
            List<Temperature> list = new List<Temperature>();
            using (var reader = new StreamReader(CSV_FILE_PATH))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Context.RegisterClassMap<TemperatureMap>();
                var records = csv.GetRecords<Temperature>();

                foreach (var temperature in records)
                {
                    list.Add(temperature);
                }
            }

            return list;
        }

    }
}