using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Context
{
   public class ProjectDBContext:DbContext
    {
        public ProjectDBContext()
        {
            Database.Connection.ConnectionString = "server=DESKTOP-M3JLO0L;database=YMS3144ProjectDB;Trusted_Connection=True;";
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
