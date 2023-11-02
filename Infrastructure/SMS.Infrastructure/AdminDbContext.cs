using Microsoft.EntityFrameworkCore;
using SMS.Infrastructure.Database.Schools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Infrastructure
{
    public class AdminDbContext : DbContext
    {
        //protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer()


        public virtual DbSet<School> Schools { get; set; }
    }
}
