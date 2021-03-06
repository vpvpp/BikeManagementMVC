﻿using BikeManegement.Models;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeManegement.Data
{
    public class ApplicationDBContext : IdentityDbContext<IdentityUser>
    {


        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {     
        }


        public DbSet<BikeMaker> BikeMakers { get; set; }
        public DbSet<BikeModel> bikeModels { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set;}

        public DbSet<Bike> Bikes { get; set;}



    }
}
