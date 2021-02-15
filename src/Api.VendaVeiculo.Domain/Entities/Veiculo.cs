using System;
using System.Collections.Generic;
using System.Text;

namespace Api.VendaVeiculo.Domain.Entities
{
    public class Veiculo
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int AnoFabricacao { get; set; }
    }
}
