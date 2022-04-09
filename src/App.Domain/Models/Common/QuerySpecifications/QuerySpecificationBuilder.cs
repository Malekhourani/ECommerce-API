using System;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore.Query;

namespace App.Domain.Models.Common.QuerySpecifications
{
    public class QuerySpecificationBuilder<TEntity>
        where TEntity : class
    {
        protected QuerySpecification<TEntity> _specification;

        public QuerySpecificationBuilder<TEntity> New()
        {
            _specification = QuerySpecification<TEntity>.Factory();

            return this;
        }

        public QuerySpecificationBuilder<TEntity> JoinWith(Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> include)
        {
            _specification.Includes.Add(include);

            return this;
        }

        public QuerySpecificationBuilder<TEntity> AddCondition(Expression<Func<TEntity, bool>> condition)
        {
            _specification.Conditions.Add(condition);

            return this;
        }

        // public QuerySpecificationBuilder<TEntity> OrderBy(Func<IQueryable<TEntity>, string, bool, IOrderedQueryable<TEntity>> orderBy)
        // {
        //     _specification.OrderBy = orderBy;

        //     return this;
        // }

        public QuerySpecification<TEntity> Build()
        {
            return _specification;
        }
    }
}
