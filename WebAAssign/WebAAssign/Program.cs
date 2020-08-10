using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using WebAAssign.Data;
using WebAAssign.Models;

namespace WebAAssign
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //var host = CreateWebHostBuilder(args).Build();

            //using (var services = host.Services.CreateScope())
            //{
            //    var dbContext = services.ServiceProvider.GetRequiredService<ApplicationDbContext>();
            //    var userRole = services.ServiceProvider.GetRequiredService<SysUser<IdentityUser>>();
            //}

            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
