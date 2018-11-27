using System;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace KorDevAus.Orm
{
    /// <summary>
    /// This represents the factory entity to create <see cref="KdaDbContext"/> instance.
    /// </summary>
    public class KdaDbContextFactory : IDesignTimeDbContextFactory<KdaDbContext>
    {
        private const string AppSettingsJson = "appsettings.json";
        private const string KdaDbConnection = "KorDevAus";

        private string _connstring;

        /// <summary>
        /// Creates a new instance of a derived context.
        /// </summary>
        /// <returns>A new instance of the derived context.</returns>
        public KdaDbContext CreateDbContext()
        {
            return this.CreateDbContext(null);
        }

        /// <inheritdoc />
        public KdaDbContext CreateDbContext(string[] args)
        {
            if (string.IsNullOrWhiteSpace(this._connstring))
            {
                this.LoadConnectionString(args);
            }

            var builder = new DbContextOptionsBuilder<KdaDbContext>()
                              .UseSqlServer(this._connstring);

            var dbContext = (KdaDbContext)Activator.CreateInstance(typeof(KdaDbContext), builder.Options);

            return dbContext;
        }

        private void LoadConnectionString(string[] args)
        {
            var config = new ConfigurationBuilder()
                             .AddJsonFile(AppSettingsJson, optional: true)
                             .AddEnvironmentVariables()
                             .AddCommandLine(args)
                             .Build();

            this._connstring = config.GetConnectionString(KdaDbConnection);
        }
    }
}