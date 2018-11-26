using System;
using System.Linq;

namespace KorDevAus.Orm.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new DbContextFactory<KdaDbContext>().CreateDbContext(args))
            {
                var events = context.Events.AsQueryable().Count();

                Console.WriteLine($"Events: {events}");
            }
        }
    }
}
