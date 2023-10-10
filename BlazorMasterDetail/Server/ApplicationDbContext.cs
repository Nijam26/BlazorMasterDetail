using BlazorMasterDetail.Shared;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BlazorMasterDetail.Server
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}
