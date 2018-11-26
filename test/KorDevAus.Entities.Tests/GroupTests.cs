using System.Collections.Generic;

using FluentAssertions;
using FluentAssertions.Common;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KorDevAus.Entities.Tests
{
    [TestClass]
    public class GroupTests
    {
        [TestMethod]
        public void Given_Group_Should_BePublic()
        {
            typeof(Group)
                .Should().HaveAccessModifier(CSharpAccessModifier.Public)
                    .And.Should().NotBeAbstract()
                .And.Subject.Should().BeDerivedFrom<BaseEntity>();
        }

        [TestMethod]
        public void Given_Group_Should_HaveProperties()
        {
            typeof(Group)
                .Should().HaveProperty<string>("Name")
                    .Which.Should().BeVirtual()
                        .And.Subject.PropertyType.IsPublic.Should().BeTrue();

            typeof(Group)
                .Should().HaveProperty<string>("Description")
                    .Which.Should().BeVirtual()
                        .And.Subject.PropertyType.IsPublic.Should().BeTrue();

            typeof(Group)
                .Should().HaveProperty<List<GroupUser>>("GroupUsers")
                    .Which.Should().BeVirtual()
                        .And.Subject.PropertyType.IsPublic.Should().BeTrue();
        }
    }
}