﻿using Microsoft.EntityFrameworkCore;
using WebBlogForSurfers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebBlogForSurfers.DAL
{
    public class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<News> News { get; set; }
        public DataContext()
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=surfing;Username=postgres;Password=admin");
        }
    }
}
