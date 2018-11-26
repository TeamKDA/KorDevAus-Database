using System;
using System.Collections.Generic;

using FluentAssertions;
using FluentAssertions.Common;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KorDevAus.Entities.Tests
{
    [TestClass]
    public class UserTests
    {
        [TestMethod]
        public void Given_User_Should_BePublic()
        {
            typeof(User)
                .Should().HaveAccessModifier(CSharpAccessModifier.Public)
                    .And.Should().NotBeAbstract()
                .And.Subject.Should().BeDerivedFrom<BaseEntity>();
        }

        [TestMethod]
        public void Given_User_Should_HaveProperties()
        {
            typeof(User)
                .Should().HaveProperty<string>("FirstName")
                    .Which.Should().BeVirtual()
                        .And.Subject.PropertyType.IsPublic.Should().BeTrue();

            typeof(User)
                .Should().HaveProperty<string>("LastName")
                    .Which.Should().BeVirtual()
                        .And.Subject.PropertyType.IsPublic.Should().BeTrue();

            typeof(User)
                .Should().HaveProperty<string>("DisplayName")
                    .Which.Should().BeVirtual()
                        .And.Subject.PropertyType.IsPublic.Should().BeTrue();

            typeof(User)
                .Should().HaveProperty<string>("Email")
                    .Which.Should().BeVirtual()
                        .And.Subject.PropertyType.IsPublic.Should().BeTrue();

            typeof(User)
                .Should().HaveProperty<string>("ProfileImageUrl")
                    .Which.Should().BeVirtual()
                        .And.Subject.PropertyType.IsPublic.Should().BeTrue();

            typeof(User)
                .Should().HaveProperty<Guid>("ActiveDirectoryId")
                    .Which.Should().BeVirtual()
                        .And.Subject.PropertyType.IsPublic.Should().BeTrue();

            typeof(User)
                .Should().HaveProperty<Guid>("MailChimpId")
                    .Which.Should().BeVirtual()
                        .And.Subject.PropertyType.IsPublic.Should().BeTrue();

            typeof(User)
                .Should().HaveProperty<List<Member>>("Members")
                    .Which.Should().BeVirtual()
                        .And.Subject.PropertyType.IsPublic.Should().BeTrue();

            typeof(User)
                .Should().HaveProperty<List<GroupUser>>("GroupUsers")
                    .Which.Should().BeVirtual()
                        .And.Subject.PropertyType.IsPublic.Should().BeTrue();
        }
    }
}