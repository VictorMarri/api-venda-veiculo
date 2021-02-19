using System;
using System.Text.Json.Serialization;

namespace Api.VendaVeiculo.Domain.Entities
{
    public class Vendedor
    {
        [JsonIgnore]
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
    }
}
