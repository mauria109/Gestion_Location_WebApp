using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestionLocationWebApp.Models.Data;
using GestionLocationWebApp.Models.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace GestionLocationWebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        private async Task AddUser(int id, string nom, string prenom, string login, string pwd, string droit)
        {
            using (var context = new DataContext())
            {
                var user = new User
                {
                    DroitUsr = droit,
                    IdUsr = id,
                    LoginUsr = login,
                    NomUsr = nom,
                    PrenomUsr = prenom,
                    PwdUsr = pwd
                };
                context.Add(user);
                var records = await context.SaveChangesAsync();
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
    }
}