using System;
using System.Collections.Generic;
using System.Text;

namespace Api.VendaVeiculo.Domain.Entities
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
    }
}
