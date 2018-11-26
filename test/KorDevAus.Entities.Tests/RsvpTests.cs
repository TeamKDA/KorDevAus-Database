using System;

using FluentAssertions;
using FluentAssertions.Common;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KorDevAus.Entities.Tests
{
    [TestClass]
    public class RsvpTests
    {
        [TestMethod]
        public void Given_Rsvp_Should_BePublic()
        {
            typeof(Rsvp)
                .Should().HaveAccessModifier(CSharpAccessModifier.Public)
                    .And.Should().NotBeAbstract()
                .And.Subject.Should().BeDerivedFrom<BaseEntity>();
        }

        [TestMethod]
        public void Given_Rsvp_Should_HaveProperties()
        {
            typeof(Rsvp)
                .Should().HaveProperty<Guid>("EventId")
                    .Which.Should().BeVirtual()
                        .And.Subject.PropertyType.IsPublic.Should().BeTrue();

            typeof(Rsvp)
                .Should().HaveProperty<Guid>("MemberId")
                    .Which.Should().BeVirtual()
                        .And.Subject.PropertyType.IsPublic.Should().BeTrue();

            typeof(Rsvp)
                .Should().HaveProperty<bool>("IsHost")
                    .Which.Should().BeVirtual()
                        .And.Subject.PropertyType.IsPublic.Should().BeTrue();

            typeof(Rsvp)
                .Should().HaveProperty<string>("Status")
                    .Which.Should().BeVirtual()
                        .And.Subject.PropertyType.IsPublic.Should().BeTrue();

            typeof(Rsvp)
                .Should().HaveProperty<Event>("Event")
                    .Which.Should().BeVirtual()
                        .And.Subject.PropertyType.IsPublic.Should().BeTrue();

            typeof(Rsvp)
                .Should().HaveProperty<Member>("Member")
                    .Which.Should().BeVirtual()
                        .And.Subject.PropertyType.IsPublic.Should().BeTrue();
        }
    }
}