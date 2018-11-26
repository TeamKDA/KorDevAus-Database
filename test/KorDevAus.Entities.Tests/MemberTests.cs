using System;

using FluentAssertions;
using FluentAssertions.Common;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KorDevAus.Entities.Tests
{
    [TestClass]
    public class MemberTests
    {
        [TestMethod]
        public void Given_Member_Should_BePublic()
        {
            typeof(Member)
                .Should().HaveAccessModifier(CSharpAccessModifier.Public)
                    .And.Should().NotBeAbstract()
                .And.Subject.Should().BeDerivedFrom<BaseEntity>();
        }

        [TestMethod]
        public void Given_Member_Should_HaveProperties()
        {
            typeof(Member)
                .Should().HaveProperty<Guid>("MeetupId")
                    .Which.Should().BeVirtual()
                        .And.Subject.PropertyType.IsPublic.Should().BeTrue();

            typeof(Member)
                .Should().HaveProperty<Guid>("UserId")
                    .Which.Should().BeVirtual()
                        .And.Subject.PropertyType.IsPublic.Should().BeTrue();

            typeof(Member)
                .Should().HaveProperty<bool>("IsOrganiser")
                    .Which.Should().BeVirtual()
                        .And.Subject.PropertyType.IsPublic.Should().BeTrue();

            typeof(Member)
                .Should().HaveProperty<DateTimeOffset>("DateJoined")
                    .Which.Should().BeVirtual()
                        .And.Subject.PropertyType.IsPublic.Should().BeTrue();

            typeof(Member)
                .Should().HaveProperty<Meetup>("Meetup")
                    .Which.Should().BeVirtual()
                        .And.Subject.PropertyType.IsPublic.Should().BeTrue();

            typeof(Member)
                .Should().HaveProperty<User>("User")
                    .Which.Should().BeVirtual()
                        .And.Subject.PropertyType.IsPublic.Should().BeTrue();
        }
    }
}