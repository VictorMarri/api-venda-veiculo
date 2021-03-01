using Api.VendaVeiculo.Domain.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Api.VendaVeiculo.Domain.Entities
{
    [Table("veiculos")]
    public class Veiculo : BaseEntity
    {
        [Column("marca")]
        public string Marca { get; set; }
        [Column("modelo")]
        public string Modelo { get; set; }
        [Column("ano_fabricacao")]
        public int AnoFabricacao { get; set; }
    }
}
