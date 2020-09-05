using E_VAS.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_VAS.Context
{
    public class DataContext : DbContext
    {
        public DbSet<GveLocationModel> GveLocationModel { get; set; }
        public DbSet<GveModel> GveModel { get; set; }
        public DbSet<GvePlaceModel> GvePlaceModel { get; set; }
        public DbSet<GvePlacePointModel> GvePlacePointModel { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            Database.Migrate();
        }
    }
}
