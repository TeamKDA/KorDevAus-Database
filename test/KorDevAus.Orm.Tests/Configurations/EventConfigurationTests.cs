﻿using FluentAssertions;
using FluentAssertions.Common;

using KorDevAus.Entities;
using KorDevAus.Orm.Configurations;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KorDevAus.Orm.Tests.Configurations
{
    [TestClass]
    public class EventConfigurationTests
    {
        [TestMethod]
        public void Given_Type_Should_NotBeAbstract()
        {
            typeof(EventConfiguration)
                .Should().HaveAccessModifier(CSharpAccessModifier.Public)
                .And.Should().NotBeAbstract()
                    .And.BeDerivedFrom<BaseEntityConfiguration<Event>>();
        }
    }
}