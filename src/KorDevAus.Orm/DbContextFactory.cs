using System;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace KorDevAus.Orm
{
    /// <summary>
    /// This represents the factory entity to create <see cref="DbContext"/> instance.
    /// </summary>
    /// <typeparam name="TContext">Type of <see cref="DbContext"/>.</typeparam>
    public class DbContextFactory<TContext> : IDesignTimeDbContextFactory<TContext> where TContext : DbContext
    {
        private const string AppSettingsJson = "appsettings.json";
        private const string KdaDbConnection = "KorDevAus";

        private string _connstring;

        /// <summary>
        /// Creates a new instance of a derived context.
        /// </summary>
        /// <returns>A new instance of the derived context.</returns>
        public TContext CreateDbContext()
        {
            return this.CreateDbContext(null);
        }

        /// <inheritdoc />
        public TContext CreateDbContext(string[] args)
        {
            if (string.IsNullOrWhiteSpace(this._connstring))
            {
                this.LoadConnectionString(args);
            }

            var builder = new DbContextOptionsBuilder<TContext>()
                              .UseSqlServer(this._connstring);

            var dbContext = (TContext)Activator.CreateInstance(typeof(TContext), builder.Options);

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