using System.Linq;
using App.Domain.Exceptions.LogicalExceptions.CategoryExceptions;
using App.Domain.Exceptions.TechnicalExceptions;
using App.Domain.Models.Products.Categories;
using TanvirArjel.EFCore.GenericRepository;

namespace App.Application.Extensions
{
    public static class IRepositoryExtensions
    {
        public static async Task<IEnumerable<TEntity>> GetByRangeAsync<TEntity, TKey>(this IRepository repo, IEnumerable<TKey> keys, CancellationToken cancellationToken)
        {
            // var keyListAsString = keys.Aggregate("", (a, b) =>
            // {
            //     if (string.IsNullOrEmpty(a)) return b?.ToString();

            //     return a.ToString() + ", " + b?.ToString();
            // });

            if(! keys.Any()) return new List<TEntity>();

            var keyListAsString = string.Join(',', keys.ToList());

            var query = "Select * " +
                        $"From {nameof(TEntity)}" +
                        $"Where Id in({keyListAsString})";

            var result = await repo.GetFromRawSqlAsync<TEntity>(query, cancellationToken);

            if (result is null) throw new NoEntityWasFound($"No {nameof(TEntity)}s Was Found");

            return result;
        }

        public static async Task<TKey> InsertAsync<TEntity, TKey>(this IRepository repo, TEntity entity, CancellationToken cancellationToken = default) where TEntity : class
        {
            var keys = await repo.InsertAsync<TEntity>(entity, cancellationToken);

            return keys.First()
                        .CastTo<TKey>();
        }
    }
}
