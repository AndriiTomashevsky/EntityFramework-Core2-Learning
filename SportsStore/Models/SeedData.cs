using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace SportsStore.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            DataContext context = app.ApplicationServices
                .GetRequiredService<DataContext>();

            context.Database.Migrate();

            if (!context.Products.Any())
            {
                context.Products.AddRange(
                new Product
                {
                    Name = "Kayak",
                    Category = "Watersports",
                    PurchasePrice = 200,
                    RetailPrice = 275
                },
                new Product
                {
                    Name = "Lifejacket",
                    Category = "Watersports",
                    PurchasePrice = 30,
                    RetailPrice = 48.95m
                },
                new Product
                {
                    Name = "Soccer Ball",
                    Category = "Soccer",
                    PurchasePrice = 15.50m,
                    RetailPrice = 19.50m
                });

                context.SaveChanges();
            }
        }
    }
}