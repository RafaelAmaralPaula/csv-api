using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CsvHelper.Configuration.Attributes;

namespace Csv.Api.Models
{
    [Table("tb_temperature")]
    public class Temperature
    {

        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Name("temperatura")]
        [Column("temperatura")]
        public string Temperatura { get; set; }

        [Name("hora")]
        [Column("hora")]
        public string Hora { get; set; }

        public Temperature() { }

        public Temperature(int id, string temperatura, string hora)
        {
            Id = id;
            Temperatura = temperatura;
            Hora = hora;
        }

    }
}