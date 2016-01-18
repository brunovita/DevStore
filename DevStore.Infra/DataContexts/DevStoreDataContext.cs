using DevStore.Domain;
using System.Data.Entity;

namespace DevStore.Infra.DataContexts
{
    public class DevStoreDataContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        // Method Constructor
        public DevStoreDataContext() : base ("DevStoreConnectionString")
        {
            // Será executado no início da aplicação
            Database.SetInitializer<DevStoreDataContext>(new DevStoreDataContextInitializer());
        }
    }

    public class DevStoreDataContextInitializer : DropCreateDatabaseIfModelChanges<DevStoreDataContext>
    {
        protected override void Seed(DevStoreDataContext context)
        {
            // Adiciona ao contexto
            context.Categories.Add(new Category { Id = 1, Title = "Informática" });
            context.Categories.Add(new Category { Id = 2, Title = "Games" });
            context.Categories.Add(new Category { Id = 3, Title = "Papelaria" });
            context.SaveChanges(); // Efetiva gravação no BD

            // Adiciona ao contexto
            context.Products.Add(new Product { Id = 1, CategoryId = 1, Title = "Mouse", IsActive = true, Price = 35.90M });
            context.Products.Add(new Product { Id = 2, CategoryId = 1, Title = "Monitor LCD", IsActive = true, Price = 134.99M });
            context.Products.Add(new Product { Id = 3, CategoryId = 1, Title = "Processador Intel Core i7", IsActive = true, Price = 279.90M });
            context.Products.Add(new Product { Id = 4, CategoryId = 2, Title = "Metal Gear", IsActive = true, Price = 250.00M });
            context.Products.Add(new Product { Id = 5, CategoryId = 2, Title = "Antil Dawn", IsActive = true, Price = 135.50M });
            context.Products.Add(new Product { Id = 6, CategoryId = 2, Title = "The Last of Us", IsActive = true, Price = 290.90M });
            context.Products.Add(new Product { Id = 7, CategoryId = 3, Title = "Papel Sulfite", IsActive = true, Price = 15.90M });
            context.SaveChanges();// Efetiva gravação no BD

            base.Seed(context);
        }
    }
}
