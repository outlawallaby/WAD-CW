using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using USMALL.Models;
using USMALL.DAL;

namespace USMALL.Models
{
    public static class IdentitySeedData
    {
        private const string adminUser = "00008487";
        private const string adminPassword = "Ovosikov8487$";
        public static async void EnsurePopulated(IApplicationBuilder app)
        {
            AppIdentityDbContext context = app.ApplicationServices
            .CreateScope().ServiceProvider
            .GetRequiredService<AppIdentityDbContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            UserManager<IdentityUser> userManager = app.ApplicationServices
            .CreateScope().ServiceProvider
            .GetRequiredService<UserManager<IdentityUser>>();
            IdentityUser user = await userManager.FindByIdAsync(adminUser);
            if (user == null)
            {
                user = new IdentityUser("00008487");
                user.Email = "ovosikov@students.wiut.uz";
                user.PhoneNumber = "90-9663633";
                await userManager.CreateAsync(user, adminPassword);
            }
        }
    }

}
