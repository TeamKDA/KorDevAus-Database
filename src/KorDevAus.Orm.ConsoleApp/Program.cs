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
                var groups = context.Groups.AsQueryable().Count();
                var groupUsers = context.GroupUsers.AsQueryable().Count();
                var meetups = context.Meetups.AsQueryable().Count();
                var meetupEvents = context.MeetupEvents.AsQueryable().Count();
                var members = context.Members.AsQueryable().Count();
                var rsvps = context.Rsvps.AsQueryable().Count();
                var users = context.Users.AsQueryable().Count();
                var venues = context.Venues.AsQueryable().Count();
                var waitlists = context.Waitlists.AsQueryable().Count();

                Console.WriteLine($"Events: {events}");
                Console.WriteLine($"Groups: {groups}");
                Console.WriteLine($"GroupUsers: {groupUsers}");
                Console.WriteLine($"Meetups: {meetups}");
                Console.WriteLine($"MeetupEvents: {meetupEvents}");
                Console.WriteLine($"Members: {members}");
                Console.WriteLine($"Rsvps: {rsvps}");
                Console.WriteLine($"Users: {users}");
                Console.WriteLine($"Venues: {venues}");
                Console.WriteLine($"Waitlists: {waitlists}");
            }
        }
    }
}
