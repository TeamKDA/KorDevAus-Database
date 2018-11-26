using System;

using FluentAssertions;
using FluentAssertions.Common;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KorDevAus.Entities.Tests
{
    [TestClass]
    public class BaseEntityTests
    {
        [TestMethod]
        public void Given_BaseEntity_Should_BePublic()
        {
            typeof(BaseEntity)
                .Should().HaveAccessModifier(CSharpAccessModifier.Public)
                    .And.Should().BeAbstract();
        }

        [TestMethod]
        public void Given_BaseEntity_Should_NotHaveDefaultConstructor()
        {
            typeof(BaseEntity)
                .Should().HaveDefaultConstructor()
                    .Which.Should().HaveAccessModifier(CSharpAccessModifier.Protected);
        }

        [TestMethod]
        public void Given_BaseEntity_Should_HaveProperties()
        {
            typeof(BaseEntity)
                .Should().HaveProperty<Guid>("Id")
                    .Which.Should().BeVirtual()
                        .And.Subject.PropertyType.IsPublic.Should().BeTrue();

            typeof(BaseEntity)
                .Should().HaveProperty<DateTimeOffset>("DateCreated")
                    .Which.Should().BeVirtual()
                        .And.Subject.PropertyType.IsPublic.Should().BeTrue();

            typeof(BaseEntity)
                .Should().HaveProperty<Guid>("CreatedBy")
                    .Which.Should().BeVirtual()
                        .And.Subject.PropertyType.IsPublic.Should().BeTrue();

            typeof(BaseEntity)
                .Should().HaveProperty<DateTimeOffset>("DateUpdated")
                    .Which.Should().BeVirtual()
                        .And.Subject.PropertyType.IsPublic.Should().BeTrue();

            typeof(BaseEntity)
                .Should().HaveProperty<Guid>("UpdatedBy")
                    .Which.Should().BeVirtual()
                        .And.Subject.PropertyType.IsPublic.Should().BeTrue();
        }
    }
}