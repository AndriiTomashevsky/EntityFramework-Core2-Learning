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

            if (!context.Categories.Any())
            {
                context.Categories.AddRange(
                new Category
                {
                    Name = "Watersports",
                    Description = "Make a splash",
                },
                new Category
                {
                    Name = "Soccer",
                    Description = "The world’s favorite game",
                },
                new Category
                {
                    Name = "Running",
                    Description = "Run like the wind",
                });

                context.SaveChanges();
            }
        }
    }
}