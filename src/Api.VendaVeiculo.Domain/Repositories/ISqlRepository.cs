using Api.VendaVeiculo.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.VendaVeiculo.Domain.Repositories
{
    public interface ISqlRepository<T> where T : BaseEntity
    {

    }
}
