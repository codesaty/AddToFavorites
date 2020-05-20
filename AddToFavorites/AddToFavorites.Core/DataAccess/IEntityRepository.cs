﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace AddToFavorites.Core.DataAccess
{
    public interface IEntityRepository<T> where T : class, new()
    {
        T Get(Expression<Func<T, bool>> filter = null);
        
        List<T> GetList(Expression<Func<T, bool>> filter = null);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}