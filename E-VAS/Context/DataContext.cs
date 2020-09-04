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
    }
}
