using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore.Query;

namespace App.Domain.Models.Common.QuerySpecifications
{
    public class QuerySpecification<TEntity>
         where TEntity : class
    {
        public ICollection<Expression<Func<TEntity, bool>>> Conditions { get; set; } = new List<Expression<Func<TEntity, bool>>>();
        public ICollection<Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>> Includes { get; set; } = new List<Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>>();

        // public Func<IQueryable<TEntity>, string, bool, IOrderedQueryable<TEntity>> OrderBy { get; set; }


        public static QuerySpecification<TEntity> Factory()
        {
            return new QuerySpecification<TEntity>();
        }
    }
}
