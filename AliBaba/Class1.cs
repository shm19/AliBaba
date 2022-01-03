using AliBaba;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Web.Migrations.EntityConfigurations;
using Web.Models.Config;
using Web.Models.Identity;
using Web.Models.Orders;
using Web.Models.Products;

namespace Web.Models
{
    public class ApplicationDBContext : IdentityDbContext<User, IdentityRole<int>, int>
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
            builder.ApplyConfiguration<Order>(new OrderConfiguration());
            builder.ApplyConfiguration<Weight>(new WeightConfiguration());
            builder.ApplyConfiguration<Product>(new ProductConfiguration());
            builder.ApplyConfiguration<User>(new UserConfiguration());
            builder.ApplyConfiguration<PriceHistory>(new PriceHistoryConfiguration());
            builder.ApplyConfiguration<Category>(new CategoryConfiguration());
            builder.ApplyConfiguration<Configuration>(new ConfigurationConfiguration());
            //builder.ApplyConfigurationsFromAssembly(typeof(UserConfiguration).Assembly);
            //builder.ApplyConfigurationsFromAssembly(GetType().Assembly);

        }

        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Weight> Weight { get; set; }
        public virtual DbSet<PriceHistory> PriceHistory { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<IdentityRole<int>> Role { get; set; }
        public virtual DbSet<Configuration> Configuration { get; set; }
    }
}
