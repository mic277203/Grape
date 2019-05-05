using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Grape.EntityFramework;

namespace Grape.Migrator
{
    [DependsOn(typeof(GrapeDataModule))]
    public class GrapeMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<GrapeDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}