using Data;
using Entities.Items;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Oracle.EntityFrameworkCore;
using System.Reflection;


namespace Data
{
    public class ServiceContext:DbContext
    {
        public ServiceContext(DbContextOptions<ServiceContext> options) : base(options) { }
        public DbSet<SolicitudItem> Solicitudes { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            foreach (var relationship in builder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.NoAction;
            }

            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}

public class ServiceContextFactory : IDesignTimeDbContextFactory<ServiceContext>
{
    public ServiceContext CreateDbContext(string[] args)
    {
        var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", false, true);
        var config = builder.Build();
        var connectionString = config.GetConnectionString("ServiceContext");
        var optionsBuilder = new DbContextOptionsBuilder<ServiceContext>();
        optionsBuilder.UseOracle(config.GetConnectionString("ServiceContext"));

        return new ServiceContext(optionsBuilder.Options);
    }
}
