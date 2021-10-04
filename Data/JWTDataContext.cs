using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using JWTClassLib.Entities;
using System.IO;

namespace JWTClassLib
{
    public class JWTDataContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        
        private readonly IConfiguration Configuration;

        public JWTDataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public static string GetConnectionString()
        {
            var builder = new ConfigurationBuilder()
             .SetBasePath(Path.Combine(Directory.GetCurrentDirectory()))
             .AddJsonFile("appsettings.json");

            //var config = builder.Build();
            IConfiguration Configuration = builder.Build();
            //return Configuration["ConnectionStrings:DefaultConnection"];
            return Configuration.GetConnectionString("TestJWT");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sqlserver database
            options.UseSqlServer(Configuration.GetConnectionString("JWTDatabase"));
        }
    }
}