using Api.VendaVeiculo.Domain.Entities.Base;
using Api.VendaVeiculo.Domain.Repositories;
using Api.VendaVeiculo.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Api.VendaVeiculo.Infra.Data.Repositories
{
    public class SqlRepository<T> : ISqlRepository<T> where T : BaseEntity
    {
        private SqlContext _context;

        private DbSet<T> dataset;

        public SqlRepository(SqlContext context)
        {
            _context = context;
            dataset = _context.Set<T>();
        }

        public T Create(T entity)
        {
            dataset.Add(entity);
            _context.SaveChanges();

            return entity;
        }

        public void Delete(int id)
        {
            var delete = dataset.SingleOrDefault(p => p.id.Equals(id));

            if (delete != null)
            {
                dataset.Remove(delete);
                _context.SaveChanges();
            }
        }

        public List<T> FindAll()
        {
            var dataList = dataset.ToList();

            return dataList;
        }

        public T FindById(int id)
        {
            var find = dataset.SingleOrDefault(p => p.id.Equals(id));

            return find;
        }
    }
}
