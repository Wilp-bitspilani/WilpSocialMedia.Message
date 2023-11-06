using WilpSocialMedia.Common;
using WilpSocialMedia.Message.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace WilpSocialMedia.Message.Infrastructure
{
    public class DataContextFactory : IDesignTimeDbContextFactory<Wilpsocialmedia_MessageContext>
    {
        public Wilpsocialmedia_MessageContext CreateDbContext(string[] args)
        {
            // Used only for EF .NET Core CLI tools (update database/migrations etc.)
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory()))
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            var config = builder.Build();

            var optionsBuilder = new DbContextOptionsBuilder<Wilpsocialmedia_MessageContext>()
                .UseSqlServer(config.GetConnectionString(Global.DbConnection.MessageConnection));

            return new Wilpsocialmedia_MessageContext(optionsBuilder.Options);
        }
    }
}
