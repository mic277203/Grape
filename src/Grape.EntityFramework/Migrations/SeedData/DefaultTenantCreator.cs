using System.Linq;
using Grape.EntityFramework;
using Grape.MultiTenancy;

namespace Grape.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly GrapeDbContext _context;

        public DefaultTenantCreator(GrapeDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
