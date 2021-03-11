using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Text.Json.Serialization;

namespace Api.VendaVeiculo.Domain.Entities.Base
{
    public abstract class BaseEntity
    {
        [JsonIgnore]
        [Column("id")]
        public int id { get; set; }
    }
}
