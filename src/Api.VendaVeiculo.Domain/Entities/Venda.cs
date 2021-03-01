using Api.VendaVeiculo.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.VendaVeiculo.Domain.Entities
{
    [Table("vendas")]
    public class Venda : BaseEntity
    {
       [Column("status_venda")]
        public Status StatusVenda { get; set; }

        [Column("data")]
        public DateTime Data { get; set; }

        [Column("id_vendedor")]
        public int IdVendedor { get; set; }

        [Column("veiculo")]
        public List<Veiculo> Veiculo { get; set; }

    }
}
