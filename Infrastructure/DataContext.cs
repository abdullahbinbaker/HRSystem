using Core;
using Core.Entity;
using Microsoft.EntityFrameworkCore;
using System;
namespace Infrastructure
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {

        }

       
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Holiday> Holidays { get; set; }
        public DbSet<Login> Logins { get; set; }
    }
}
