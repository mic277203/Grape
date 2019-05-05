using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using Grape.Authorization.Roles;
using Grape.Authorization.Users;
using Grape.MultiTenancy;
using Grape.Authorization.GpUsers;

namespace Grape.EntityFramework
{
    public class GrapeDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...
        public virtual IDbSet<GpUser> GpUsers { get; set; }

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public GrapeDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in GrapeDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of GrapeDbContext since ABP automatically handles it.
         */
        public GrapeDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public GrapeDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public GrapeDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
