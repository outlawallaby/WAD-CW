using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using USMALL.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace USMALL.DAL
{
    public static class SeedData
    {
        //This method receives an IApplicationBuilder argument, which is the interface used in the Configure method
        //of the Startup class to register middleware components to handle HTTP requests
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Niacinamide 10% + Zinc 1%",
                        Description = "Niacinamide (Vitamin B3) is indicated to reduce the appearance of skin blemishes and congestion. A high 10% concentration of this vitamin is supported in the formula by zinc salt of pyrrolidone carboxylic acid to balance visible aspects of sebum activity.",
                        Category = "Serums",
                        Price = 10
                    },
                    new Product
                    {
                        Name = "Natural Moisturizing Factors + HA",
                        Description = "Natural Moisturizing Factors (NMF) are elements that keep the outer layer of the skin protected and well-hydrated. NMF are made up of multiple amino acids, fatty acids, triglycerides, urea, ceramides, phospholipids, glycerin, saccharides, sodium PCA, hyaluronic acid and many other compounds that are naturally present in the skin.",
                        Category = "Moisturizers",
                        Price = 8
                    },
                    new Product
                    {
                        Name = "Glycolic Acid 7% Toning Solution",
                        Description = "Glycolic Acid is an alpha hydroxy acid that exfoliates the skin. This 7% toning solution offers mild exfoliation for improved skin radiance and visible clarity. The formula also improves the appearance of skin texture with continued use.",
                        Category = "Toners",
                        Price = 14
                    },
                    new Product
                    {
                        Name = "Vitamin C Suspension 23% + HA Spheres 2%",
                        Description = "Vitamin C is an effective antioxidant that brightens the skin tone and reduces the appearance of signs of aging. This water-free, silicone-free formula provides 23% pure L-Ascorbic Acid which remains completely stable due to the absence of water. The system is supported with addition of dehydrated spheres of Hyaluronic Acid to offer visible surface smoothing alongside the benefits of Vitamin C. This treatment is ideally applied at bedtime.",
                        Category = "Serums",
                        Price = 10
                    },
                    new Product
                    {
                        Name = "Mineral UV Filters SPF 30 with Antioxidants",
                        Description = "The Mineral UV Filter formulas avoid the use of any nanoparticles. Instead, a refined dispersion of micronized ZnO and TiO2 in flexible, high-volatility, non-comedogenic silicones allows the formulations to remain extremely lightweight by optimizing the amount of the blocking agents.",
                        Category = "Suncare",
                        Price = 14
                    },
                    new Product
                    {
                        Name = "Retinol 1% in Squalane",
                        Description = "This water-free solution contains 1% pure Retinol, an ingredient that can reduce the appearances of fine lines, of photo damage and of general skin aging. While Retinol has been studied extensively, it is irritating to the skin and newer technologies exist that mimic the visible effects of Retinol without causing skin irritation. For this reason, we generally recommend using Granactive Retinoid 2% or Granactive Retinoid 5% instead of this formula.",
                        Category = "Serums",
                        Price = 12
                    },
                    new Product
                    {
                        Name = "Amino Acids + B5",
                        Description = "This concentrated solution includes Amino Acids and Amino Acid derivatives creating a combined total concentration of 17% (by weight). This resembles the composition of Amino Acids found in the skin’s own Natural Moisturising Factors and provides enhanced barrier support, elasticity, osmotic balance and desquamation.",
                        Category = "Serums",
                        Price = 12
                    },
                    new Product
                    {
                        Name = "AHA- 30% + BHA 2%",
                        Description = "AHA 30% + BHA 2% Peeling Solution from The Ordinary offers deeper exfoliation to help fight signs of pore congestion and improve skin radiance. The formula also improves the appearance of skin texture and reduces the look of fine lines.",
                        Category = "Serums",
                        Price = 13
                    },
                    new Product
                    {
                        Name = "Lactic Acid 10% + HA",
                        Description = "Lactic Acid is an alpha hydroxy acid that exfoliates the skin. This 10% formulation offers mild exfoliation and is supported with a purified Tasmanian pepperberry known to reduce signs of inflammation and sensitivity that is often associated with exfoliation.",
                        Category = "Exfoliators",
                        Price = 12
                    },
                    new Product
                    {
                        Name = "Hyaluronic Acid 2% + B5",
                        Description = "The molecular size of HA determines its depth of delivery in the skin. This formulation combines low-, medium- and high-molecular weight HA, as well as a next-generation HA crosspolymer at a combined concentration of 2% for multi-depth hydration in a water-based formula. This system is supported with the addition of Vitamin B5 which also enhances surface hydration. ",
                        Category = "Serums",
                        Price = 11
                    }
               );
                context.SaveChanges();
            }
        }
    }
}

