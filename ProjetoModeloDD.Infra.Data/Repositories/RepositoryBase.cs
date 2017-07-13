﻿
using ProjetoModeloDD.Domain.Interfaces.Repositories;
using ProjetoModeloDD.Infra.Data.Contexto;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ProjetoModeloDD.Infra.Data.Repositories
{
    //Repositorio Generecio
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        protected ProjetoModeloContext Db = new ProjetoModeloContext();

        public void Add(TEntity obj)
        {
            
            Db.Set<TEntity>().Add(obj);
            Db.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
             //AsNoTrancking desabilitando o lazLoad
          return Db.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
           return Db.Set<TEntity>().Find(id);
           
        }

        public void Remove(TEntity obj)
        {
            Db.Set<TEntity>().Remove(obj);
            Db.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            Db.Entry(obj).State = EntityState.Modified;
            Db.SaveChanges();
        }
    }
}
