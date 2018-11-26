using System;

using FluentAssertions;
using FluentAssertions.Common;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KorDevAus.Entities.Tests
{
    [TestClass]
    public class MeetupEventTests
    {
        [TestMethod]
        public void Given_MeetupEvent_Should_BePublic()
        {
            typeof(MeetupEvent)
                .Should().HaveAccessModifier(CSharpAccessModifier.Public)
                    .And.Should().NotBeAbstract()
                .And.Subject.Should().BeDerivedFrom<BaseEntity>();
        }

        [TestMethod]
        public void Given_MeetupEvent_Should_HaveProperties()
        {
            typeof(MeetupEvent)
                .Should().HaveProperty<Guid>("MeetupId")
                    .Which.Should().BeVirtual()
                        .And.Subject.PropertyType.IsPublic.Should().BeTrue();

            typeof(MeetupEvent)
                .Should().HaveProperty<Guid>("EventId")
                    .Which.Should().BeVirtual()
                        .And.Subject.PropertyType.IsPublic.Should().BeTrue();

            typeof(MeetupEvent)
                .Should().HaveProperty<Meetup>("Meetup")
                    .Which.Should().BeVirtual()
                        .And.Subject.PropertyType.IsPublic.Should().BeTrue();

            typeof(MeetupEvent)
                .Should().HaveProperty<Event>("Event")
                    .Which.Should().BeVirtual()
                        .And.Subject.PropertyType.IsPublic.Should().BeTrue();
        }
    }
}