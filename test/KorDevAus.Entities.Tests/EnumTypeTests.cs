using System;
using System.Collections.Generic;
using System.Linq;

using FluentAssertions;
using FluentAssertions.Common;

using KorDevAus.Entities.Tests.Fixtures;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KorDevAus.Entities.Tests
{
    [TestClass]
    public class EnumTypeTests
    {
        [TestMethod]
        public void Given_EnumType_Should_BePublicAndAbstract()
        {
            typeof(EnumType)
                .Should().HaveAccessModifier(CSharpAccessModifier.Public)
                    .And.Should().BeAbstract();
        }

        [TestMethod]
        public void Given_EnumType_Should_NotHaveDefaultConstructor()
        {
            typeof(EnumType)
                .Should().NotHaveDefaultConstructor()
                    .And.HaveConstructor(new[] { typeof(string), typeof(int) })
                        .Which.Should().HaveAccessModifier(CSharpAccessModifier.Protected);
        }

        [TestMethod]
        public void Given_EnumType_Should_HaveProperties()
        {
            typeof(EnumType)
                .Should().HaveProperty<string>("Name")
                    .Which.Should().BeVirtual()
                        .And.Subject.PropertyType.IsPublic.Should().BeTrue();

            typeof(EnumType)
                .Should().HaveProperty<int>("Value")
                    .Which.Should().BeVirtual()
                        .And.Subject.PropertyType.IsPublic.Should().BeTrue();
        }

        [TestMethod]
        public void Given_EnumType_Should_HaveStaticMethods()
        {
            typeof(EnumType)
                .Should().HaveMethod("GetAll", new List<Type>());

            typeof(EnumType)
                .Should().HaveMethod("GetAll", new List<Type>())
                    .Which.ReturnType.IsGenericType.Should().BeTrue();

            typeof(EnumType)
                .Should().HaveMethod("GetAll", new List<Type>())
                    .Which.Should().HaveAccessModifier(CSharpAccessModifier.Public)
                        .And.Subject.IsStatic.Should().BeTrue();

            typeof(EnumType)
                .Should().HaveMethod("GetNames", new List<Type>())
                    .Which.Should().Return<IEnumerable<string>>();

            typeof(EnumType)
                .Should().HaveMethod("GetNames", new List<Type>())
                    .Which.Should().HaveAccessModifier(CSharpAccessModifier.Public)
                        .And.Subject.IsStatic.Should().BeTrue();

            typeof(EnumType)
                .Should().HaveMethod("GetValues", new List<Type>())
                    .Which.Should().Return<IEnumerable<int>>();

            typeof(EnumType)
                .Should().HaveMethod("GetValues", new List<Type>())
                    .Which.Should().HaveAccessModifier(CSharpAccessModifier.Public)
                        .And.Subject.IsStatic.Should().BeTrue();
        }

        [TestMethod]
        public void Given_FakeEnumType_When_GetAll_Should_ReturnAllEnums()
        {
            var enums = EnumType.GetAll<FakeEnumType>().ToList();

            enums.Should().HaveCount(2)
                 .And.Contain(FakeEnumType.Lorem)
                 .And.Contain(FakeEnumType.Ipsum);
        }

        [TestMethod]
        public void Given_FakeEnumType_When_GetNames_Should_ReturnAllNames()
        {
            var names = EnumType.GetNames<FakeEnumType>().ToList();

            names.Should().HaveCount(2)
                 .And.Contain(FakeEnumType.Lorem)
                 .And.Contain(FakeEnumType.Ipsum);
        }

        [TestMethod]
        public void Given_FakeEnumType_When_GetValues_Should_ReturnAllValues()
        {
            var values = EnumType.GetValues<FakeEnumType>().ToList();

            values.Should().HaveCount(2)
                  .And.Contain(FakeEnumType.Lorem)
                  .And.Contain(FakeEnumType.Ipsum);
        }
    }
}