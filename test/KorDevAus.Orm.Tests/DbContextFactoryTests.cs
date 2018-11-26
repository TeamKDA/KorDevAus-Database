using System;
using System.Collections.Generic;

using FluentAssertions;
using FluentAssertions.Common;

using Microsoft.EntityFrameworkCore.Design;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KorDevAus.Orm.Tests
{
    [TestClass]
    public class DbContextFactoryTests
    {
        [TestMethod]
        public void Given_Type_Should_BePublicAndImplementIDesignTimeDbContextFactory()
        {
            typeof(DbContextFactory<KdaDbContext>)
                .Should().HaveAccessModifier(CSharpAccessModifier.Public)
                    .And.Should().NotBeAbstract()
                    .And.Implement<IDesignTimeDbContextFactory<KdaDbContext>>();
        }

        [TestMethod]
        public void Given_Type_Should_HaveConstructors()
        {
            typeof(DbContextFactory<KdaDbContext>)
                .Should().HaveDefaultConstructor();
        }

        [TestMethod]
        public void Given_Type_Should_HaveMethod()
        {
            typeof(DbContextFactory<KdaDbContext>)
                .Should().HaveMethod("CreateDbContext", new List<Type>())
                    .Which.Should().Return<KdaDbContext>();

            typeof(DbContextFactory<KdaDbContext>)
                .Should().HaveMethod("CreateDbContext", new[] { typeof(string[]) })
                    .Which.Should().Return<KdaDbContext>();
        }
    }
}