using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tg_crud_solution.Models.DataBase;

namespace tg_crud_solution.Models
{
    public class ApplicationContext : DbContext
    {

        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Founder> Founder { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();
            Console.WriteLine(configuration.GetConnectionString("test_db"));
            if (!builder.IsConfigured)
            {
                builder.UseSqlServer(configuration.GetConnectionString("test_db"));
            }
        }
    }
}
