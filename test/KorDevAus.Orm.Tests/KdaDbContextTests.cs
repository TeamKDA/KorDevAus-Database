using FluentAssertions;
using FluentAssertions.Common;

using KorDevAus.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KorDevAus.Orm.Tests
{
    [TestClass]
    public class KdaDbContextTests
    {
        [TestMethod]
        public void Given_Type_Should_BePublicAndDerivedFromDbContext()
        {
            typeof(KdaDbContext)
                .Should().HaveAccessModifier(CSharpAccessModifier.Public)
                    .And.Should().NotBeAbstract()
                    .And.BeDerivedFrom<DbContext>();
        }

        [TestMethod]
        public void Given_Type_Should_HaveConstructors()
        {
            typeof(KdaDbContext)
                .Should().HaveConstructor(new[] { typeof(DbContextOptions<KdaDbContext>) });
        }

        [TestMethod]
        public void Given_Type_Should_HaveProperties()
        {
            typeof(KdaDbContext)
                .Should().HaveProperty<DbSet<Event>>("Events")
                    .Which.Should().BeVirtual()
                .And.Subject
                    .Should().BeReadable()
                    .And.BeWritable();

            typeof(KdaDbContext)
                .Should().HaveProperty<DbSet<Group>>("Groups")
                    .Which.Should().BeVirtual()
                .And.Subject
                    .Should().BeReadable()
                    .And.BeWritable();

            typeof(KdaDbContext)
                .Should().HaveProperty<DbSet<GroupUser>>("GroupUsers")
                    .Which.Should().BeVirtual()
                .And.Subject
                    .Should().BeReadable()
                    .And.BeWritable();

            typeof(KdaDbContext)
                .Should().HaveProperty<DbSet<Meetup>>("Meetups")
                    .Which.Should().BeVirtual()
                .And.Subject
                    .Should().BeReadable()
                    .And.BeWritable();
            typeof(KdaDbContext)
                .Should().HaveProperty<DbSet<MeetupEvent>>("MeetupEvents")
                    .Which.Should().BeVirtual()
                .And.Subject
                    .Should().BeReadable()
                    .And.BeWritable();

            typeof(KdaDbContext)
                .Should().HaveProperty<DbSet<Member>>("Members")
                    .Which.Should().BeVirtual()
                .And.Subject
                    .Should().BeReadable()
                    .And.BeWritable();
            typeof(KdaDbContext)
                .Should().HaveProperty<DbSet<Rsvp>>("Rsvps")
                    .Which.Should().BeVirtual()
                .And.Subject
                    .Should().BeReadable()
                    .And.BeWritable();

            typeof(KdaDbContext)
                .Should().HaveProperty<DbSet<User>>("Users")
                    .Which.Should().BeVirtual()
                .And.Subject
                    .Should().BeReadable()
                    .And.BeWritable();

            typeof(KdaDbContext)
                .Should().HaveProperty<DbSet<Venue>>("Venues")
                    .Which.Should().BeVirtual()
                .And.Subject
                    .Should().BeReadable()
                    .And.BeWritable();

            typeof(KdaDbContext)
                .Should().HaveProperty<DbSet<Waitlist>>("Waitlists")
                    .Which.Should().BeVirtual()
                .And.Subject
                    .Should().BeReadable()
                    .And.BeWritable();
        }
    }
}