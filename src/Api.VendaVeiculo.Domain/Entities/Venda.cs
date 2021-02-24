using System;
using System.Collections.Generic;

namespace Api.VendaVeiculo.Domain.Entities
{
    public class Venda
    {
        public Guid Id { get; set; }

        public Status StatusVenda { get; set; }

        public DateTime Data { get; set; }

        public Guid IdVendedor { get; set; }

        public List<Veiculo> Veiculo { get; set; }

    }
}
