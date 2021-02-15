using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Api.VendaVeiculo.Domain.Entities
{
    public class Venda
    {
        public int Id { get; set; }
        [Required]
        public Status StatusVenda { get; set; }
        [Required]
        public DateTime Data { get; set; }
        [Required]
        public Vendedor Vendedor { get; set; }
        [Required]
        public List<Veiculo> Veiculo { get; set; }

    }
}
