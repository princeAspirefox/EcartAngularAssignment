using EcartAssiggmnet.Data;
using EcartAssiggmnet.Data.Entity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcartAssiggmnet.Data
{
    public class EcartSeeder
    {
        private readonly EcartContext ctx;
        private readonly IWebHostEnvironment hosting;
        private readonly UserManager<User> userManager;

        public EcartSeeder(EcartContext ctx, IWebHostEnvironment hosting, UserManager<User> userManager)
        {
            this.ctx = ctx;
            this.hosting = hosting;
            this.userManager = userManager;
        }

        public async Task SeedAsync()
        {
            ctx.Database.EnsureCreated();

            User user = await userManager.FindByEmailAsync("shawn@dutchtreat.com");

            if (user == null)
            {
                user = new User()
                {
                    Name = "Prince Kumar",

                    Email = "prince@ecart.com",
                    UserName = "prince@ecart.com"
                };

                var result = await userManager.CreateAsync(user, "P@ssw0rd!");
                if (result != IdentityResult.Success)
                {
                    throw new InvalidOperationException("Could not create new user in Seeder");
                }
            }

        }
    }

}
