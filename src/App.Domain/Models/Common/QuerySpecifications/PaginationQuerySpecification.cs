using System;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore.Query;

namespace App.Domain.Models.Common.QuerySpecifications
{
    public class PaginationQuerySpecification<TEntity> : QuerySpecification<TEntity>
            where TEntity : class
    {
        public int? Take { get; set; }
        public int? Skip { get; set; }
        public Func<IQueryable<TEntity>, string, IQueryable<TEntity>> SearchBy { get; set; }
        public ICollection<Expression<Func<TEntity, bool>>> Conditions { get; set; } = new List<Expression<Func<TEntity, bool>>>();
        public ICollection<Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>> Includes { get; set; } = new List<Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>>();
    }
}
