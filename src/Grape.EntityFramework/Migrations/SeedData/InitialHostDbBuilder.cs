using Grape.EntityFramework;
using EntityFramework.DynamicFilters;

namespace Grape.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly GrapeDbContext _context;

        public InitialHostDbBuilder(GrapeDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
