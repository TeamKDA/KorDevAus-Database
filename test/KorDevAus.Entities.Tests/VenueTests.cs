using System.Collections.Generic;

using FluentAssertions;
using FluentAssertions.Common;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KorDevAus.Entities.Tests
{
    [TestClass]
    public class VenueTests
    {
        [TestMethod]
        public void Given_Venue_Should_BePublic()
        {
            typeof(Venue)
                .Should().HaveAccessModifier(CSharpAccessModifier.Public)
                    .And.Should().NotBeAbstract()
                .And.Subject.Should().BeDerivedFrom<BaseEntity>();
        }

        [TestMethod]
        public void Given_Venue_Should_HaveProperties()
        {
            typeof(Venue)
                .Should().HaveProperty<string>("Name")
                    .Which.Should().BeVirtual()
                        .And.Subject.PropertyType.IsPublic.Should().BeTrue();

            typeof(Venue)
                .Should().HaveProperty<string>("Description")
                    .Which.Should().BeVirtual()
                        .And.Subject.PropertyType.IsPublic.Should().BeTrue();

            typeof(Venue)
                .Should().HaveProperty<string>("Address1")
                    .Which.Should().BeVirtual()
                        .And.Subject.PropertyType.IsPublic.Should().BeTrue();

            typeof(Venue)
                .Should().HaveProperty<string>("Address2")
                    .Which.Should().BeVirtual()
                        .And.Subject.PropertyType.IsPublic.Should().BeTrue();

            typeof(Venue)
                .Should().HaveProperty<string>("Suburb")
                    .Which.Should().BeVirtual()
                        .And.Subject.PropertyType.IsPublic.Should().BeTrue();

            typeof(Venue)
                .Should().HaveProperty<string>("State")
                    .Which.Should().BeVirtual()
                        .And.Subject.PropertyType.IsPublic.Should().BeTrue();

            typeof(Venue)
                .Should().HaveProperty<string>("Postcode")
                    .Which.Should().BeVirtual()
                        .And.Subject.PropertyType.IsPublic.Should().BeTrue();

            typeof(Venue)
                .Should().HaveProperty<string>("Country")
                    .Which.Should().BeVirtual()
                        .And.Subject.PropertyType.IsPublic.Should().BeTrue();

            typeof(Venue)
                .Should().HaveProperty<List<Event>>("Events")
                    .Which.Should().BeVirtual()
                        .And.Subject.PropertyType.IsPublic.Should().BeTrue();
        }
    }
}