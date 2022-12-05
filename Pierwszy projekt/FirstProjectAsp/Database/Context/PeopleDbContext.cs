using FirstProjectAsp.Database.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstProjectAsp.Database.Context
{
    //add-migration CreateDatabaseFirstMigration -outputdir Database\Migrations
    //update-database
    public class PeopleDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PeopleDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Person> Persons { get; set; }
    }
}
