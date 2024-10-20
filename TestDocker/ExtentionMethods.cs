using Microsoft.EntityFrameworkCore;
using TestDocker.Models;

namespace TestDocker
{
    public static class ExtentionMethods
    {
        public static void SeedData(this IServiceProvider serviceProvider)
        {

           // using var scope = serviceProvider.CreateScope();
            ////Automatic Update DataBase After migration
            //var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
            //context.Database.Migrate();
            //context.Database.EnsureCreated();
            //if (!context.Products.Any())
            //{
            //    context.Products.AddRange(
            //        new Product { Name = "Product A", Price = 9.99m },
            //        new Product { Name = "Product B", Price = 19.99m },
            //        new Product { Name = "Product C", Price = 29.99m }
            //    );
            //    context.SaveChanges();
            //}
        }
    }
}
