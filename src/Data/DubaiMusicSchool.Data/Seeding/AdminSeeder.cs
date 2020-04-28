namespace DubaiMusicSchool.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using DubaiMusicSchool.Common;
    using DubaiMusicSchool.Data.Models;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.Extensions.DependencyInjection;

    internal class AdminSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            var userManager = serviceProvider.GetRequiredService<UserManager<SchoolAppUser>>();

            if (dbContext.Users.Count() == 1)
            {
                var user = dbContext.Users.First();

                if (!user.Roles.Any())
                {
                    await userManager.AddToRoleAsync(user, GlobalConstants.AdministratorRoleName);
                }
            }

            await dbContext.SaveChangesAsync();

        }
    }
}
