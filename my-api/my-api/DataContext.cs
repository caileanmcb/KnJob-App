﻿using Microsoft.EntityFrameworkCore;
using my_api.Models;

namespace my_api
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        DbSet<Job> Jobs { get; set; }
    }
}
