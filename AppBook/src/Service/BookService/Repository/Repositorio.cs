using BookService.Data;
using BookService.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BookService.Repository
{
    public class Repositorio<TEntity> : IRepositorio<TEntity>, IDisposable where TEntity : class
    {
        private Contexto<TEntity> context = new Contexto<TEntity>();
        public List<TEntity> GetAll()
        {
            return context.Dados();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
