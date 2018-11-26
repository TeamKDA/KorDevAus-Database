using System;
using System.Collections.Generic;

using FluentAssertions;
using FluentAssertions.Common;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KorDevAus.Entities.Tests
{
    [TestClass]
    public class EventTests
    {
        [TestMethod]
        public void Given_Event_Should_BePublic()
        {
            typeof(Event)
                .Should().HaveAccessModifier(CSharpAccessModifier.Public)
                    .And.Should().NotBeAbstract()
                .And.Subject.Should().BeDerivedFrom<BaseEntity>();
        }

        [TestMethod]
        public void Given_Event_Should_HaveProperties()
        {
            typeof(Event)
                .Should().HaveProperty<string>("Name")
                    .Which.Should().BeVirtual()
                        .And.Subject.PropertyType.IsPublic.Should().BeTrue();

            typeof(Event)
                .Should().HaveProperty<string>("Description")
                    .Which.Should().BeVirtual()
                        .And.Subject.PropertyType.IsPublic.Should().BeTrue();

            typeof(Event)
                .Should().HaveProperty<bool>("IsPublic")
                    .Which.Should().BeVirtual()
                        .And.Subject.PropertyType.IsPublic.Should().BeTrue();

            typeof(Event)
                .Should().HaveProperty<int>("MaxAttendees")
                    .Which.Should().BeVirtual()
                        .And.Subject.PropertyType.IsPublic.Should().BeTrue();

            typeof(Event)
                .Should().HaveProperty<Guid?>("CampaignId")
                    .Which.Should().BeVirtual()
                        .And.Subject.PropertyType.IsPublic.Should().BeTrue();

            typeof(Event)
                .Should().HaveProperty<Guid?>("VenueId")
                    .Which.Should().BeVirtual()
                        .And.Subject.PropertyType.IsPublic.Should().BeTrue();

            typeof(Event)
                .Should().HaveProperty<Venue>("Venue")
                    .Which.Should().BeVirtual()
                        .And.Subject.PropertyType.IsPublic.Should().BeTrue();

            typeof(Event)
                .Should().HaveProperty<List<MeetupEvent>>("MeetupEvents")
                    .Which.Should().BeVirtual()
                        .And.Subject.PropertyType.IsPublic.Should().BeTrue();

            typeof(Event)
                .Should().HaveProperty<List<Rsvp>>("Rsvps")
                    .Which.Should().BeVirtual()
                        .And.Subject.PropertyType.IsPublic.Should().BeTrue();
        }
    }
}