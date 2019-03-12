using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using _05_Escuela.NetCore.Models;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace _05_Escuela.NetCore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateSqliteDatabase();
            CreateWebHostBuilder(args).Build().Run();
        }

        private static void CreateSqliteDatabase()
        {
            using (var db = new SqliteDbContext())
            {
                db.Database.EnsureCreated();
            }
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
