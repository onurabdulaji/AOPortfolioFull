﻿using AOPortfolioFull.Domain.Interfaces.IBase;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace AOPortfolioFull.Domain.Interfaces.IGenericRepository.ReadGeneric;

public interface IReadGenericRepository<T> where T : class, IEntity , new()
{
    Task<IList<T>> GetAllAsync(Expression<Func<T, bool>>? predicate = null,
            Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null,
            Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
            bool enableTracking = false);

    Task<T> GetAsync(Expression<Func<T, bool>> predicate,
            Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null,
            bool enableTracking = false);
    Task<int> CountAsync(Expression<Func<T, bool>>? predicate = null);
    IQueryable<T> Find(Expression<Func<T, bool>> predicate, bool enableTracking = false);
}
