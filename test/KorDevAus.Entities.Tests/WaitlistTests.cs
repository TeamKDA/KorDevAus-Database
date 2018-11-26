using System;

using FluentAssertions;
using FluentAssertions.Common;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KorDevAus.Entities.Tests
{
    [TestClass]
    public class WaitlistTests
    {
        [TestMethod]
        public void Given_Waitlist_Should_BePublic()
        {
            typeof(Waitlist)
                .Should().HaveAccessModifier(CSharpAccessModifier.Public)
                    .And.Should().NotBeAbstract()
                .And.Subject.Should().BeDerivedFrom<BaseEntity>();
        }

        [TestMethod]
        public void Given_Waitlist_Should_HaveProperties()
        {
            typeof(Waitlist)
                .Should().HaveProperty<Guid>("EventId")
                    .Which.Should().BeVirtual()
                        .And.Subject.PropertyType.IsPublic.Should().BeTrue();

            typeof(Waitlist)
                .Should().HaveProperty<Guid>("MemberId")
                    .Which.Should().BeVirtual()
                        .And.Subject.PropertyType.IsPublic.Should().BeTrue();

            typeof(Waitlist)
                .Should().HaveProperty<bool>("IsShortlisted")
                    .Which.Should().BeVirtual()
                        .And.Subject.PropertyType.IsPublic.Should().BeTrue();

            typeof(Waitlist)
                .Should().HaveProperty<Event>("Event")
                    .Which.Should().BeVirtual()
                        .And.Subject.PropertyType.IsPublic.Should().BeTrue();

            typeof(Waitlist)
                .Should().HaveProperty<Member>("Member")
                    .Which.Should().BeVirtual()
                        .And.Subject.PropertyType.IsPublic.Should().BeTrue();
        }
    }
}