using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BookService.Interface
{
    public interface IRepositorio<TEntity> where TEntity : class
    {
        List<TEntity> GetAll();
    }
}
