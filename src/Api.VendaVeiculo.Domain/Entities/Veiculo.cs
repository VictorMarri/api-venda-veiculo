using Api.VendaVeiculo.Domain.Entities.Base;
using System;
using System.Text.Json.Serialization;

namespace Api.VendaVeiculo.Domain.Entities
{
    public class Veiculo : BaseEntity
    {
        
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int AnoFabricacao { get; set; }
    }
}
