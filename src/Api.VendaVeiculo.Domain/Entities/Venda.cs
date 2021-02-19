using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Api.VendaVeiculo.Domain.Entities
{
    public class Venda
    {
        public Guid Id { get; set; }
        
        public Status StatusVenda { get; set; }
        
        public DateTime Data { get; set; }
        
        public Vendedor Vendedor { get; set; }
        
        public List<Veiculo> Veiculo { get; set; }

    }
}
