using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EMTracker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
            using(var db = new SamplingContext())
            {
                Console.Write("Enter a UserID to Login: ");
                var UserI = Console.ReadLine();

                var Users = new Login { UserID = UserI };
                db.Logins.Add(Users);
                db.SaveChanges();

                var query = from u in db.Logins
                            orderby u.UserID
                            select u;

                Console.WriteLine("All UserIDs in the database:");
                foreach(var item in query)
                {
                    Console.WriteLine(item.UserID);
                }
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
    public class Login
    {
        public string UserID { get; set; }
        public string Password { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Roles { get; set; }
    }
    public class SamplingContext : DbContext
    {
        public DbSet<Login> Logins { get; set; }
    }
}
