using System.Collections.Generic;

using FluentAssertions;
using FluentAssertions.Common;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KorDevAus.Entities.Tests
{
    [TestClass]
    public class MeetupTests
    {
        [TestMethod]
        public void Given_Meetup_Should_BePublic()
        {
            typeof(Meetup)
                .Should().HaveAccessModifier(CSharpAccessModifier.Public)
                    .And.Should().NotBeAbstract()
                .And.Subject.Should().BeDerivedFrom<BaseEntity>();
        }

        [TestMethod]
        public void Given_Meetup_Should_HaveProperties()
        {
            typeof(Meetup)
                .Should().HaveProperty<string>("Name")
                    .Which.Should().BeVirtual()
                        .And.Subject.PropertyType.IsPublic.Should().BeTrue();

            typeof(Meetup)
                .Should().HaveProperty<string>("Description")
                    .Which.Should().BeVirtual()
                        .And.Subject.PropertyType.IsPublic.Should().BeTrue();

            typeof(Meetup)
                .Should().HaveProperty<List<Member>>("Members")
                    .Which.Should().BeVirtual()
                        .And.Subject.PropertyType.IsPublic.Should().BeTrue();

            typeof(Meetup)
                .Should().HaveProperty<List<MeetupEvent>>("MeetupEvents")
                    .Which.Should().BeVirtual()
                        .And.Subject.PropertyType.IsPublic.Should().BeTrue();
        }
    }
}