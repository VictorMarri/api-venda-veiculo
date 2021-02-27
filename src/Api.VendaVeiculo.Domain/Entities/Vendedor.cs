using Api.VendaVeiculo.Domain.Entities.Base;
using System;
using System.Text.Json.Serialization;

namespace Api.VendaVeiculo.Domain.Entities
{
    public class Vendedor : BaseEntity
    {
        
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
    }
}
