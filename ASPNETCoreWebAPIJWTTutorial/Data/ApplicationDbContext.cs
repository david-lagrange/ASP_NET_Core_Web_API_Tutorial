﻿using ASPNETCoreWebAPIJWTTutorial.Configuration;
using ASPNETCoreWebAPIJWTTutorial.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ASPNETCoreWebAPIJWTTutorial.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions options)
            :base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new RolesConfiguration());
        }


    }
}
