using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Context
{
    public class SqliteContext : DbContext
    {
        public SqliteContext(string connString)
            : base(new SQLiteConnection() { ConnectionString = connString }, true)
        {
            Database.SetInitializer<SqliteContext>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Models.ModelOne> ModelOne { get; set; }
        public DbSet<Models.ModelTwo> ModelTwo { get; set; }
    }
}
