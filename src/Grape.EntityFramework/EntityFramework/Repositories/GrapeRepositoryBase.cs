using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace Grape.EntityFramework.Repositories
{
    public abstract class GrapeRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<GrapeDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected GrapeRepositoryBase(IDbContextProvider<GrapeDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class GrapeRepositoryBase<TEntity> : GrapeRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected GrapeRepositoryBase(IDbContextProvider<GrapeDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
