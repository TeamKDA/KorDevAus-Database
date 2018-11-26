using FluentAssertions;
using FluentAssertions.Common;

using KorDevAus.Entities;
using KorDevAus.Orm.Configurations;

using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KorDevAus.Orm.Tests.Configurations
{
    [TestClass]
    public class BaseEntityConfigurationTests
    {
        [TestMethod]
        public void Given_Type_Should_BeAbstract()
        {
            typeof(BaseEntityConfiguration<BaseEntity>)
                .Should().HaveAccessModifier(CSharpAccessModifier.Public)
                .And.Should().BeAbstract()
                    .And.Implement(typeof(IEntityTypeConfiguration<BaseEntity>));
        }
    }
}