using ArkkanCore.DAL.Models;
using ArkkanCore.DAL.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkanCore.DAL.Common
{
    public partial class CustomDbContext : DbContext
    {
        public CustomDbContext()
        {
        }

        public CustomDbContext(DbContextOptions<CustomDbContext> options)
            : base(options)
        {
        }

        public DbSet<vmCoursePaymentsReport> coursePaymentsReport => Set<vmCoursePaymentsReport>();
        public DbSet<vmStudentPaymentsReport> studentPaymentsReport => Set<vmStudentPaymentsReport>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<vmStudentPaymentsReport>(eb => { eb.HasNoKey(); });
            modelBuilder.Entity<vmCoursePaymentsReport>(eb => { eb.HasNoKey(); });
        }
    }
}
