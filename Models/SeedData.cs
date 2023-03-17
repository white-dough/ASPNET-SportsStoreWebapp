using Eyac_SportsStore.Models;
using Microsoft.EntityFrameworkCore;

namespace Eyac_SportsStore.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider
                .GetRequiredService<StoreDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Kayak",
                        Description = "A boat for one person",
                        Category = "Watersports",
                        Price = 275
                    },
                    new Product
                    {
                        Name = "Lifejacket",
                        Description = "Protective and fashionable",
                        Category = "Watersports",
                        Price = 49.95m
                    },
                    new Product
                    {
                        Name = "Soccerball",
                        Description = "FIFA-approved size and weight",
                        Category = "Soccer",
                        Price = 19.50m
                    },
                    new Product
                    {
                        Name = "Corner Flags",
                        Description = "Give your playing field a professional touch",
                        Category = "Soccer",
                        Price = 34.5m
                    },
                    new Product
                    {
                        Name = "Yoga Mat",
                        Description = "Used by professional yoga instructors.",
                        Category = "Yoga",
                        Price = 54.5m
                    },
                    new Product
                    {
                        Name = "Tumbler",
                        Description = "Drink your water beach",
                        Category = "General",
                        Price = 32.5m
                    },
                    new Product
                    {
                        Name = "Gym Bag",
                        Description = "Large capacity bag.",
                        Category = "General",
                        Price = 54.5m
                    }

                );
                context.SaveChanges();

            }
        }
    }
}