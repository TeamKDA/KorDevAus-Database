using System;

using FluentAssertions;
using FluentAssertions.Common;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KorDevAus.Entities.Tests
{
    [TestClass]
    public class GroupUserTests
    {
        [TestMethod]
        public void Given_GroupUser_Should_BePublic()
        {
            typeof(GroupUser)
                .Should().HaveAccessModifier(CSharpAccessModifier.Public)
                    .And.Should().NotBeAbstract()
                .And.Subject.Should().BeDerivedFrom<BaseEntity>();
        }

        [TestMethod]
        public void Given_GroupUser_Should_HaveProperties()
        {
            typeof(GroupUser)
                .Should().HaveProperty<Guid>("GroupId")
                    .Which.Should().BeVirtual()
                        .And.Subject.PropertyType.IsPublic.Should().BeTrue();

            typeof(GroupUser)
                .Should().HaveProperty<Guid>("UserId")
                    .Which.Should().BeVirtual()
                        .And.Subject.PropertyType.IsPublic.Should().BeTrue();

            typeof(GroupUser)
                .Should().HaveProperty<DateTimeOffset>("DateJoined")
                    .Which.Should().BeVirtual()
                        .And.Subject.PropertyType.IsPublic.Should().BeTrue();

            typeof(GroupUser)
                .Should().HaveProperty<Group>("Group")
                    .Which.Should().BeVirtual()
                        .And.Subject.PropertyType.IsPublic.Should().BeTrue();

            typeof(GroupUser)
                .Should().HaveProperty<User>("User")
                    .Which.Should().BeVirtual()
                        .And.Subject.PropertyType.IsPublic.Should().BeTrue();
        }
    }
}