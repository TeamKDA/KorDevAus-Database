using System.Linq;

using FluentAssertions;
using FluentAssertions.Common;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KorDevAus.Entities.Tests
{
    [TestClass]
    public class StateTypeTests
    {
        [TestMethod]
        public void Given_StateType_Should_BePublic()
        {
            typeof(StateType)
                .Should().HaveAccessModifier(CSharpAccessModifier.Public)
                    .And.Should().NotBeAbstract()
                .And.Subject.Should().BeDerivedFrom<EnumType>();
        }

        [TestMethod]
        public void Given_StateType_Should_NotHaveDefaultConstructor()
        {
            typeof(StateType)
                .Should().NotHaveDefaultConstructor()
                    .And.HaveConstructor(new[] { typeof(string), typeof(int) });
        }

        [TestMethod]
        public void Given_StateType_When_GetAll_Should_ReturnAllEnums()
        {
            var enums = EnumType.GetAll<StateType>().ToList();

            enums.Should().HaveCount(8)
                 .And.Contain(StateType.ACT)
                 .And.Contain(StateType.NSW)
                 .And.Contain(StateType.NT)
                 .And.Contain(StateType.QLD)
                 .And.Contain(StateType.SA)
                 .And.Contain(StateType.TAS)
                 .And.Contain(StateType.VIC)
                 .And.Contain(StateType.WA);
        }

        [TestMethod]
        public void Given_StateType_When_GetNames_Should_ReturnAllNames()
        {
            var names = EnumType.GetNames<StateType>().ToList();

            names.Should().HaveCount(8)
                 .And.Contain(StateType.ACT)
                 .And.Contain(StateType.NSW)
                 .And.Contain(StateType.NT)
                 .And.Contain(StateType.QLD)
                 .And.Contain(StateType.SA)
                 .And.Contain(StateType.TAS)
                 .And.Contain(StateType.VIC)
                 .And.Contain(StateType.WA);
        }

        [TestMethod]
        public void Given_StateType_When_GetValues_Should_ReturnAllValues()
        {
            var values = EnumType.GetValues<StateType>().ToList();

            values.Should().HaveCount(8)
                 .And.Contain(StateType.ACT)
                 .And.Contain(StateType.NSW)
                 .And.Contain(StateType.NT)
                 .And.Contain(StateType.QLD)
                 .And.Contain(StateType.SA)
                 .And.Contain(StateType.TAS)
                 .And.Contain(StateType.VIC)
                 .And.Contain(StateType.WA);
        }
    }
}