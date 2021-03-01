using Api.VendaVeiculo.Domain.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Api.VendaVeiculo.Domain.Entities
{
    [Table("vendedores")]
    public class Vendedor : BaseEntity
    {
        [Column("nome")]
        public string Nome { get; set; }
        [Column("cpf")]
        public string CPF { get; set; }
        [Column("email")]
        public string Email { get; set; }
    }
}
