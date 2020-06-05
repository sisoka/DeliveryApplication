using Microsoft.AspNetCore.Identity;
using Panda.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Panda.Data
{
    public static class MyRoleSeeder
    {
        public static void SeedRoles(RoleManager<PandaUserRole> roleManager)
        {
            if (!roleManager.RoleExistsAsync("User").Result)
            {
                PandaUserRole role = new PandaUserRole();
                role.Name = "User";
                IdentityResult roleResult = roleManager.CreateAsync(role).Result;
            }
            if (!roleManager.RoleExistsAsync("Admin").Result)
            {
                PandaUserRole role = new PandaUserRole();
                role.Name = "Admin";
                IdentityResult roleResult = roleManager.CreateAsync(role).Result;
            }
        }
    }
}
