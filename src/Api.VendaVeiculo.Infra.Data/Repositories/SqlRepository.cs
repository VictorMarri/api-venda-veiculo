using Api.VendaVeiculo.Domain.Entities.Base;
using Api.VendaVeiculo.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.VendaVeiculo.Infra.Data.Repositories
{
    public class SqlRepository<T> : ISqlRepository<T> where T : BaseEntity
    {
        public T Create(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<T> FindAll()
        {
            throw new NotImplementedException();
        }

        public T FindById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
