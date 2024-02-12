using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using AspnetBoilerplate.Demo.Authorization.Roles;
using AspnetBoilerplate.Demo.Authorization.Users;
using AspnetBoilerplate.Demo.MultiTenancy;

namespace AspnetBoilerplate.Demo.EntityFrameworkCore
{
    public sealed class DemoDbContext : AbpZeroDbContext<Tenant, Role, User, DemoDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public DemoDbContext(DbContextOptions<DemoDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("Latin1_General_100_CI_AI");

            base.OnModelCreating(modelBuilder);
        }
    }
}
