﻿using Microsoft.EntityFrameworkCore;
using TaskApp.Models;

namespace TaskApp.DataBaseContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<MyTask> Tasks { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
